#include <CONTROL.h>
#include <Arduino.h>

//init variables

incrementalPID RC_pid;
incrementalPID Disturbance;//This is a dummy PID to measure disturbance switch output voltage
#define ANALOG_IN A3
#define SwitchOutput A4
#define ANALOG_OUT 3

unsigned long new_time_pid;
unsigned long old_time_pid;

unsigned ts;
int PWM_value;




void setup() {
  // put your setup code here, to run once:
  ts=100;//ms
  // PID parameters
  RC_pid.K=10; RC_pid.Ti=3; RC_pid.Td=0.5; RC_pid.N=1; RC_pid.b=1; RC_pid.c=0; RC_pid.CSmin=0; RC_pid.CSmax=5; RC_pid.Ts=ts/1000.0; RC_pid.TS=0; RC_pid.Fp=0; RC_pid.Fm=0; RC_pid.S_P=0;



  Serial.begin(115200);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  new_time_pid=millis();
  

  //PID loop
  if ((new_time_pid-old_time_pid)>ts)
  {
   old_time_pid=new_time_pid;

   Disturbance.PV=((analogRead(SwitchOutput)*5.0)/1023.0);
   RC_pid.PV=((analogRead(ANALOG_IN)*5.0)/1023.0);
   RC_pid.calculate_CS();
   //TF1.u=RC_pid.CS;
   PWM_value=RC_pid.CS*51;
   analogWrite(ANALOG_OUT,PWM_value);

   RC_pid.communicateControllerVision("RCpid");
   Disturbance.communicateControllerVision("Disturbance");
   
  }

}
