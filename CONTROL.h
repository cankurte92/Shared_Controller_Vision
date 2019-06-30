#ifndef CONTROL_h
#define CONTROL_h
#include <Arduino.h>
	
	static int GLB_inpMsgCounter;
	static String GLB_inpMsg[50];

class incrementalPID
{
  public:
  float K,Ti,Td,N,b,c,CSmin,CSmax,Ts; // parameters
  float CSo,Do; // state vars
  float SPo,PVo; // input mem
  float S_P,PV,TR,CS; // I/O vars
  int TS,Fp,Fm,HI,LO; //I/O vars
  float DSP,DPV,DP,DI,D,DD,DCS;
  
  int CommMode=0;//Controller Visio Communication Mode 
  String inpMsg[50];//incoming message
  String inString;
  char inChar;
  int inpMsgCounter=0;
  char MsgSuccessful;
  
  incrementalPID();
  void calculate_CS();
  void communicateControllerVision(String ControllerName);
  
  
};


class positionalPID
{
  public:
  float K,Ti,Td,N,b,c,CSmin,CSmax,Ts; // parameters
  float Io,Do; // state vars
  float CSo; // for locks
  float SPo,PVo; // input mem
  float S_P,PV,TR,CS; // I/O vars
  int TS,Fp,Fm,HI,LO;//I/O vars
  float DSP,DPV,P,I,D;
  
  int CommMode=0;//Controller Vision Communication Mode 
  String inpMsg[50];//incoming message
  String inString;
  char inChar;
  int inpMsgCounter=0;
  char MsgSuccessful;

  positionalPID();
  void calculate_CS();
  void communicateControllerVision(String ControllerName);
};

class Plant
{
  public:
  float mu,T,Ts; // parameters
  float xo; // state vars
  float u,y; // I/O vars
 
  Plant();
  void calculate_PV();
  };

#endif
