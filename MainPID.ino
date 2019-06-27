#include <CONTROL.h>
#include <Arduino.h>

//init variables
#define ANALOG_PIN A3
incrementalPID inc_pid;
incrementalPID sec_pid;
incrementalPID esr_pid;
Plant TF1;
Plant TF2;
Plant TF3;
unsigned long new_time_pid;
unsigned long old_time_pid;
unsigned long new_time_serial;
unsigned long old_time_serial;
unsigned ts;




void setup() {
  // put your setup code here, to run once:
  ts=250;//ms
  // PID parameters
  inc_pid.K=2; inc_pid.Ti=5; inc_pid.Td=0.5; inc_pid.N=1; inc_pid.b=1; inc_pid.c=0; inc_pid.CSmin=-10; inc_pid.CSmax=10; inc_pid.Ts=0.25; inc_pid.TS=0; inc_pid.Fp=0; inc_pid.Fm=0; inc_pid.S_P=10;
  sec_pid.K=2.12; sec_pid.Ti=5; sec_pid.Td=0.5; sec_pid.N=1; sec_pid.b=1; sec_pid.c=0; sec_pid.CSmin=-10; sec_pid.CSmax=10; sec_pid.Ts=0.25; sec_pid.TS=0; sec_pid.Fp=0; sec_pid.Fm=0; sec_pid.S_P=10;
  esr_pid.K=2.12; esr_pid.Ti=5; esr_pid.Td=0.5; esr_pid.N=1; esr_pid.b=1; esr_pid.c=0; esr_pid.CSmin=-10; esr_pid.CSmax=10; esr_pid.Ts=0.25; esr_pid.TS=0; esr_pid.Fp=0; esr_pid.Fm=0; esr_pid.S_P=10;

  //TF parameters
  TF1.mu=4;
  TF1.T=10;
  TF1.Ts=0.25;// ts/1000.0;

  TF2.mu=4;
  TF2.T=10;
  TF2.Ts=0.25;// ts/1000.0;
  
  TF3.mu=4;
  TF3.T=10;
  TF3.Ts=0.25;// ts/1000.0;
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
   inc_pid.PV=TF1.y;
   inc_pid.calculate_CS();
   TF1.u=inc_pid.CS;
   TF1.calculate_PV();
   inc_pid.PV=TF1.y;

   sec_pid.PV=TF2.y;
   sec_pid.calculate_CS();
   TF2.u=sec_pid.CS;
   TF2.calculate_PV();
   sec_pid.PV=TF2.y;

   esr_pid.PV=TF3.y;
   esr_pid.calculate_CS();
   TF3.u=esr_pid.CS;
   TF3.calculate_PV();
   esr_pid.PV=TF3.y;
   
  }
  //Serial loop
    if ((new_time_serial-old_time_serial)>1000)
  {
    old_time_serial=new_time_serial;

    inc_pid.communicateControllerVision("EC_Pid");
    //delay(100);
    sec_pid.communicateControllerVision("SC_Pid");
    //delay(100);
    esr_pid.communicateControllerVision("ESR_Pid");
  }

}
