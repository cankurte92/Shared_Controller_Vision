#include <CONTROL.h>
#include <Arduino.h>

//init variables
//init PID controllers
incrementalPID w_PID;//speed controller
positionalPID I_PID;//Current Controller
//init Plant models
Plant electrical;
Plant mechanical;
//init timer variables
unsigned long new_time_pid;
unsigned long old_time_pid;
unsigned long new_time_serial;
unsigned long old_time_serial;
unsigned ts; //ms
//DC motor parameters
float L=0.5; float R=0.1; float Kt=0.1; float Ke=0.1; //circuit parameters 
float J=1; float B=0.1;//mechanical parameters
float Vemf=0; float Vin=0; float Torque=0; float I=0; float w=0;


void setup() {
  // put your setup code here, to run once:
     ts=100;//ms
  // PID parameters
  w_PID.K=0; w_PID.Ti=1; w_PID.Td=0; w_PID.N=1; w_PID.b=1; w_PID.c=0; w_PID.CSmin=-200; w_PID.CSmax=200; w_PID.Ts=ts/1000.0; w_PID.TS=0; w_PID.Fp=0; w_PID.Fm=0; w_PID.S_P=0;
  I_PID.K=1; I_PID.Ti=5; I_PID.Td=0; I_PID.N=1; I_PID.b=1; I_PID.c=0; I_PID.CSmin=-250; I_PID.CSmax=250; I_PID.Ts=ts/1000.0; I_PID.TS=0; I_PID.Fp=0; I_PID.Fm=0; I_PID.S_P=10;

  //TF parameters
  electrical.mu=1/R;
  electrical.T=L/R;
  electrical.Ts=ts/1000.0;

  mechanical.mu=1/B;
  mechanical.T=J/B;
  mechanical.Ts=ts/1000.0;
  
 
  Serial.begin(115200);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  new_time_pid=millis();
  new_time_serial=millis();

  //PID loop
  if ((new_time_pid-old_time_pid)>ts)
  {
   old_time_pid=new_time_pid;
  
  
  electrical.u=Vin-Vemf;
  electrical.calculate_PV();
  I=electrical.y;

  Torque=Kt*I;
  mechanical.u=Torque;
  mechanical.calculate_PV();
  w=mechanical.y;
  Vemf=Ke*w;

  w_PID.PV=w;
  w_PID.calculate_CS();

  I_PID.PV=I;
  //I_PID.S_P=w_PID.CS;
  I_PID.calculate_CS();
  Vin=I_PID.CS;

    
  }

  
  //Serial loop
    if ((new_time_serial-old_time_serial)>100)
  {
    old_time_serial=new_time_serial;
//communicate with Controller Vision
    I_PID.communicateControllerVision("I_Pid");
    w_PID.communicateControllerVision("w_Pid");

    
  }

}
