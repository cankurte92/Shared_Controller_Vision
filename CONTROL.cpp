#include "CONTROL.h"
#include <Arduino.h>

incrementalPID::incrementalPID()
{
}
void incrementalPID::calculate_CS()
{

   if (TS==0) { // Automatic mode
                DSP = S_P-SPo;
                DPV = PV-PVo;
                DP = K*(b*DSP-DPV);
                DI = K*Ts/Ti*(S_P-PV);
                D = (Td*Do+K*N*Td*(c*DSP-DPV))/(Td+N*Ts);
                DD = D-Do;
                DCS = DP+DI+DD;
                if ((DCS>0 & Fp) | (DCS<0 & Fm))
                {DCS = 0;}
                CS = CSo+DCS; }
    else { // Tracking mode (can override locks)
          CS = TR;
          D = 0; }
          // Saturation signalling
          HI = CS>=CSmax;
          LO = CS<=CSmin;
          // Antiwindup
          if (CS>CSmax) CS = CSmax;
          if (CS<CSmin) CS = CSmin;
          // State variables stored for next step
          CSo = CS;
          Do = D;
          // Input mem udated for next step
          SPo = S_P;
          PVo = PV;
		  
            }
			

void incrementalPID::communicateControllerVision( String ControllerName )
	//This function communicates with ControllerVision tool
{	
	//Read serial buffer line and split by ','
if (Serial.available() > 0) 
	{
		inChar = Serial.read();
		while (inChar != '\n') 
		{
			if 	(inChar == ',')	
				{
				inpMsgCounter++;
				inString="";
				}	
			else
				{	
				inString += (char)inChar;
				inpMsg[inpMsgCounter]=inString;
				}	
			inChar = Serial.read();
		}
	}
	
if ((inpMsg[0]=="start")&&((inpMsg[inpMsgCounter]=="end"))) //if split message starts and ends with specified strings
	{
       MsgSuccessful=1;
		   if(inpMsg[2]==ControllerName)//if received message is specified for class member
				{
				CommMode=inpMsg[1].toInt(); //update communication mode
				}
			//write received message to global buffer
			for(int i=0;i<=inpMsgCounter;i++) { GLB_inpMsg[i]=inpMsg[i];}
			GLB_inpMsgCounter=inpMsgCounter;
	}
else //if recieved message is broken
	{
		MsgSuccessful=0;
		CommMode = 0; //Set communication mode to 0. to default
		//read message from global buffer
		for(int i=0;i<= GLB_inpMsgCounter;i++) {inpMsg[i]= GLB_inpMsg[i];}
		inpMsgCounter= GLB_inpMsgCounter;
		
		if(inpMsg[2]==ControllerName)
			{
			CommMode=inpMsg[1].toInt();
			}
	}
inpMsgCounter=0;
inString="";
	
switch (CommMode)
	{
		case 0: //Transmit all parameters, outputs and inputs
			//initial key word, communication mode and controller name
			Serial.print("start");
			Serial.print(',');
			Serial.print(CommMode);
			Serial.print(',');
			Serial.print(ControllerName);
			Serial.print(',');
			//Parameters
			Serial.print(K);
			Serial.print(',');
			Serial.print(Ti);
			Serial.print(',');
			Serial.print(Td);
			Serial.print(',');
			Serial.print(N);
			Serial.print(',');
			Serial.print(b);
			Serial.print(',');
			Serial.print(c);
			Serial.print(',');
			Serial.print(CSmin);
			Serial.print(',');
			Serial.print(CSmax);
			Serial.print(',');
			Serial.print(Ts);
			Serial.print(',');
			//Controller Outputs
			Serial.print(S_P);
			Serial.print(',');
			Serial.print(PV);
			Serial.print(',');
			Serial.print(CS);
			Serial.print(',');
			Serial.print(HI);
			Serial.print(',');
			Serial.print(LO);
			Serial.print(',');
			//Controller Inputs
			Serial.print(TR);
			Serial.print(',');
			Serial.print(TS);
			Serial.print(',');
			Serial.print(Fp);
			Serial.print(',');
			Serial.print(Fm);
			Serial.print(',');
			Serial.println("end");
		break;

		
		case 1: //Change parameters and transmit parameters and controller outputs
			if(inpMsg[2]==ControllerName)
				{
				K=inpMsg[3].toFloat();
				Ti=inpMsg[4].toFloat();
				Td=inpMsg[5].toFloat();
				N=inpMsg[6].toFloat();
				b=inpMsg[7].toFloat();
				c=inpMsg[8].toFloat();
				Ts=inpMsg[9].toFloat();
				}
			//initial key word, communication mode and controller name
			Serial.print("start");
			Serial.print(',');
			Serial.print(CommMode);
			Serial.print(',');
			Serial.print(ControllerName);
			Serial.print(',');
			//Parameters
			Serial.print(K);
			Serial.print(',');
			Serial.print(Ti);
			Serial.print(',');
			Serial.print(Td);
			Serial.print(',');
			Serial.print(N);
			Serial.print(',');
			Serial.print(b);
			Serial.print(',');
			Serial.print(c);
			Serial.print(',');
			Serial.print(Ts);
			Serial.print(',');
			//Controller Outputs
			Serial.print(S_P);
			Serial.print(',');
			Serial.print(PV);
			Serial.print(',');
			Serial.print(CS);
			Serial.print(',');
			Serial.print(HI);
			Serial.print(',');
			Serial.print(LO);
			Serial.print(',');
			Serial.println("end");
		break;
	
		case 2: 	//Update controller Inputs and transmit controller inputs and outputs
			if(inpMsg[2]==ControllerName)
				{
				TR=inpMsg[3].toFloat();
				TS=inpMsg[4].toInt();
				Fp=inpMsg[5].toInt();
				Fm=inpMsg[6].toInt();
				CSmin=inpMsg[7].toFloat();
				CSmax=inpMsg[8].toFloat();
				S_P=inpMsg[9].toFloat();
				}
			//initial key word, communication mode and controller name
			Serial.print("start");
			Serial.print(',');
			Serial.print(CommMode);
			Serial.print(',');
			Serial.print(ControllerName);
			Serial.print(',');
			//Controller Inputs
			Serial.print(TR);
			Serial.print(',');
			Serial.print(TS);
			Serial.print(',');
			Serial.print(Fp);
			Serial.print(',');
			Serial.print(Fm);
			Serial.print(',');
			Serial.print(CSmin);
			Serial.print(',');
			Serial.print(CSmax);
			Serial.print(',');		
			//Controller Outputs
			Serial.print(S_P);
			Serial.print(',');
			Serial.print(PV);
			Serial.print(',');
			Serial.print(CS);
			Serial.print(',');
			Serial.print(HI);
			Serial.print(',');
			Serial.print(LO);
			Serial.print(',');
			Serial.println("end");
		break;
		
		default: //Transmit only outputs
		//initial key word, communication mode and controller name
			Serial.print("start");
			Serial.print(',');
			Serial.print(CommMode);
			Serial.print(',');
			Serial.print(ControllerName);
			Serial.print(',');
			//Controller Outputs
			Serial.print(S_P);
			Serial.print(',');
			Serial.print(PV);
			Serial.print(',');
			Serial.print(CS);
			Serial.print(',');
			Serial.print(HI);
			Serial.print(',');
			Serial.print(LO);
			Serial.print(',');
			Serial.println("end");
		break;
		
	}
	
}

//POSITIONAL PID
positionalPID::positionalPID()
{
}
void positionalPID::calculate_CS()
{
   
   if (TS==0) { // Automatic mode
      DSP = S_P-SPo;
      DPV = PV-PVo;
      P = K*(b*S_P-PV);
      I = Io+K*Ts/Ti*(S_P-PV);
      D = (Td*Do+K*N*Td*(c*DSP-DPV))/(Td+N*Ts);
      CS = P+I+D;
        if ((CS>CSo & Fp)|(CS<CSo & Fm))
            {CS = CSo;}
              }
    else { // Tracking mode (can override locks)
      CS = TR;
      D = 0; }
          // Antiwindup
    if (CS>CSmax) CS = CSmax;
    if (CS<CSmin) CS = CSmin;
    Io = CS-P-D;
    // Saturation signalling
    HI = CS>=CSmax;
    LO = CS<=CSmin;
    // State variables stored for next step
    CSo = CS;
    Do = D;
    // Input mem udated for next step
    SPo = S_P;
    PVo = PV;
}

void positionalPID::communicateControllerVision( String ControllerName )
	//This function communicates with ControllerVision tool
{	
	//Read serial buffer and split by ','
if (Serial.available() > 0) 
	{
		inChar = Serial.read();
		while (inChar != '\n') 
		{
			if 	(inChar == ',')	
				{
				inpMsgCounter++;
				inString="";
				}	
			else
				{	
				inString += (char)inChar;
				inpMsg[inpMsgCounter]=inString;
				}	
			inChar = Serial.read();
		}
	}
	
if ((inpMsg[0]=="start")&&((inpMsg[inpMsgCounter]=="end"))) //if split message starts and ends with specified strings
	{
       MsgSuccessful=1;
		   if(inpMsg[2]==ControllerName)//if received message is specified for class member
				{
				CommMode=inpMsg[1].toInt(); //update communication mode
				}
			//write received message to global buffer
			for(int i=0;i<=inpMsgCounter;i++) { GLB_inpMsg[i]=inpMsg[i];}
			GLB_inpMsgCounter=inpMsgCounter;
	}
else //if recieved message is broken
	{
		MsgSuccessful=0;
		CommMode = 0; //Set communication mode to 0. to default
		//read message from global buffer
		for(int i=0;i<= GLB_inpMsgCounter;i++) {inpMsg[i]= GLB_inpMsg[i];}
		inpMsgCounter= GLB_inpMsgCounter;
		
		if(inpMsg[2]==ControllerName)
			{
			CommMode=inpMsg[1].toInt();
			}
	}
inpMsgCounter=0;
inString="";
	
switch (CommMode)
	{
		case 0: //Transmit all parameters, outputs and inputs
			//initial key word, communication mode and controller name		
			Serial.print("start");
			Serial.print(',');
			Serial.print(CommMode);
			Serial.print(',');
			Serial.print(ControllerName);
			Serial.print(',');
			//Parameters
			Serial.print(K);
			Serial.print(',');
			Serial.print(Ti);
			Serial.print(',');
			Serial.print(Td);
			Serial.print(',');
			Serial.print(N);
			Serial.print(',');
			Serial.print(b);
			Serial.print(',');
			Serial.print(c);
			Serial.print(',');
			Serial.print(CSmin);
			Serial.print(',');
			Serial.print(CSmax);
			Serial.print(',');
			Serial.print(Ts);
			Serial.print(',');
			//Controller Outputs
			Serial.print(S_P);
			Serial.print(',');
			Serial.print(PV);
			Serial.print(',');
			Serial.print(CS);
			Serial.print(',');
			Serial.print(HI);
			Serial.print(',');
			Serial.print(LO);
			Serial.print(',');
			//Controller Inputs
			Serial.print(TR);
			Serial.print(',');
			Serial.print(TS);
			Serial.print(',');
			Serial.print(Fp);
			Serial.print(',');
			Serial.print(Fm);
			Serial.print(',');
			Serial.println("end");
		break;

		
		case 1: //Change parameters and transmit parameters and controller outputs
			if(inpMsg[2]==ControllerName)
				{
				K=inpMsg[3].toFloat();
				Ti=inpMsg[4].toFloat();
				Td=inpMsg[5].toFloat();
				N=inpMsg[6].toFloat();
				b=inpMsg[7].toFloat();
				c=inpMsg[8].toFloat();
				Ts=inpMsg[9].toFloat();
				}
			//initial key word, communication mode and controller name
			Serial.print("start");
			Serial.print(',');
			Serial.print(CommMode);
			Serial.print(',');
			Serial.print(ControllerName);
			Serial.print(',');
			//Parameters
			Serial.print(K);
			Serial.print(',');
			Serial.print(Ti);
			Serial.print(',');
			Serial.print(Td);
			Serial.print(',');
			Serial.print(N);
			Serial.print(',');
			Serial.print(b);
			Serial.print(',');
			Serial.print(c);
			Serial.print(',');
			Serial.print(Ts);
			Serial.print(',');
			//Controller Outputs
			Serial.print(S_P);
			Serial.print(',');
			Serial.print(PV);
			Serial.print(',');
			Serial.print(CS);
			Serial.print(',');
			Serial.print(HI);
			Serial.print(',');
			Serial.print(LO);
			Serial.print(',');
			Serial.println("end");
		break;
	
		case 2: 	//Update controller Inputs and transmit controller inputs and outputs
			if(inpMsg[2]==ControllerName)
				{
				TR=inpMsg[3].toFloat();
				TS=inpMsg[4].toInt();
				Fp=inpMsg[5].toInt();
				Fm=inpMsg[6].toInt();
				CSmin=inpMsg[7].toFloat();
				CSmax=inpMsg[8].toFloat();
				S_P=inpMsg[9].toFloat();
				}			
			//initial key word, communication mode and controller name
			Serial.print("start");
			Serial.print(',');
			Serial.print(CommMode);
			Serial.print(',');
			Serial.print(ControllerName);
			Serial.print(',');
			//Controller Inputs
			Serial.print(TR);
			Serial.print(',');
			Serial.print(TS);
			Serial.print(',');
			Serial.print(Fp);
			Serial.print(',');
			Serial.print(Fm);
			Serial.print(',');
			Serial.print(CSmin);
			Serial.print(',');
			Serial.print(CSmax);
			Serial.print(',');		
			//Controller Outputs
			Serial.print(S_P);
			Serial.print(',');
			Serial.print(PV);
			Serial.print(',');
			Serial.print(CS);
			Serial.print(',');
			Serial.print(HI);
			Serial.print(',');
			Serial.print(LO);
			Serial.print(',');
			Serial.println("end");
		break;
		
		default: //Transmit only outputs
			//initial key word, communication mode and controller name
			Serial.print("start");
			Serial.print(',');
			Serial.print(CommMode);
			Serial.print(',');
			Serial.print(ControllerName);
			Serial.print(',');
			//Controller Outputs
			Serial.print(S_P);
			Serial.print(',');
			Serial.print(PV);
			Serial.print(',');
			Serial.print(CS);
			Serial.print(',');
			Serial.print(HI);
			Serial.print(',');
			Serial.print(LO);
			Serial.print(',');
			Serial.println("end");
		break;
		
	}
	
}





Plant::Plant()
  {
   y=0;
  }
  void Plant::calculate_PV()
 {
  float x;
  x = (T*(xo+u))/(T+Ts);
  y = mu*Ts/(T+Ts)*(x+u);
  xo = x;
 }
