#include <CONTROL.h>

#include <CONTROL.h>
#include <Arduino.h>

//init variables
#define ANALOG_PIN A3
incrementalPID w_PID;
incrementalPID I_PID;

Plant electrical;
Plant mechanical;

unsigned long new_time_pid;
unsigned long old_time_pid;
unsigned long new_time_serial;
unsigned long old_time_serial;
unsigned ts; //ms

float L=0.5; float R=1; float Kt=0.1; float Ke=0.1; //circuit parameters 
float J=0.01; float B=0.1;//mechanical parameters
float Vemf=0; float Vin=0; float Torque=0; float I=0; float w=0;


void setup() {
  // put your setup code here, to run once:
  ts=10;//ms
  // PID parameters
  w_PID.K=4; w_PID.Ti=1; w_PID.Td=0; w_PID.N=1; w_PID.b=1; w_PID.c=0; w_PID.CSmin=-200; w_PID.CSmax=200; w_PID.Ts=0.010; w_PID.TS=0; w_PID.Fp=0; w_PID.Fm=0; w_PID.S_P=0;
  I_PID.K=5; I_PID.Ti=0.5; I_PID.Td=0; I_PID.N=1; I_PID.b=1; I_PID.c=0; I_PID.CSmin=-250; I_PID.CSmax=250; I_PID.Ts=0.010; I_PID.TS=0; I_PID.Fp=0; I_PID.Fm=0; I_PID.S_P=10;

  //TF parameters


  electrical.mu=1/R;
  electrical.T=L/R;
  electrical.Ts=0.010;// ts/1000.0;

  mechanical.mu=1/B;
  mechanical.T=J/B;
  mechanical.Ts=0.010;// ts/1000.0;
  
 
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
   //inc_pid.S_P=((analogRead(ANALOG_PIN)*100.0)/1023.0)-50.0; 
  
  electrical.u=Vin-Vemf;
  electrical.calculate_PV();
  I=electrical.y;

  Torque=Kt*I;
  mechanical.u=Torque;
  mechanical.calculate_PV();
  w=mechanical.y;
  Vemf=Ke*w;

  I_PID.PV=I;
  I_PID.S_P=w_PID.CS;
  I_PID.calculate_CS();
  Vin=I_PID.CS;

  w_PID.PV=w;
  w_PID.calculate_CS();
    
  }
  //Serial loop
    if ((new_time_serial-old_time_serial)>100)
  {
    old_time_serial=new_time_serial;

    I_PID.communicateControllerVisio("I_Pid");
    //delay(20);
    w_PID.communicateControllerVisio("w_Pid");

    
  }

}
