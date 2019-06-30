#include <CONTROL.h>
#include <Arduino.h>

//init variables

incrementalPID inc_pid;

Plant TF1;

unsigned long new_time_pid;
unsigned long old_time_pid;

unsigned ts;




void setup() {
  // put your setup code here, to run once:
  ts=100;//ms
  // PID parameters
  inc_pid.K=4; inc_pid.Ti=3; inc_pid.Td=1.6; inc_pid.N=10; inc_pid.b=1; inc_pid.c=0; inc_pid.CSmin=-10; inc_pid.CSmax=10; inc_pid.Ts=ts/1000.0; inc_pid.TS=0; inc_pid.Fp=0; inc_pid.Fm=0; inc_pid.S_P=0;

  //TF parameters
  TF1.mu=1;
  TF1.T=8;
  TF1.Ts=ts/1000.0;

  Serial.begin(115200);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  new_time_pid=millis();
  

  //PID loop
  if ((new_time_pid-old_time_pid)>ts)
  {
   old_time_pid=new_time_pid;
  
   inc_pid.PV=TF1.y;
   inc_pid.calculate_CS();
   TF1.u=inc_pid.CS;
   TF1.calculate_PV();
   inc_pid.PV=TF1.y;

   inc_pid.communicateControllerVision("1stOrder");
   
  }

}
