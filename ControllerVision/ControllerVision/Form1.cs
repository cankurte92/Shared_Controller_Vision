using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace ControllerVision
{
    public partial class Form1 : Form
    {
        string[] PortNames = SerialPort.GetPortNames(); //Get all connected port names
        string SerialMessage = "0"; //initialize RX serial message
        int counter = 0; // timer counter
        double TimeInSec = 0; //elapsed time in Sec
        UInt16 SerialPeriod; // it is used as periad of update data in the logging files and chart        
        List<PID> PIDs = new List<PID>(); // list of PID controllers which sent by Arduino
        List<String> PIDnames = new List<String>(); // list of PID controller names which sent by Arduino
        string ChosenPID; //the PID controller name chosen by user in the "comboBoxPIDs"
        int ChosenPIDindex=0;// index of the PID controller chosen by user in the "comboBoxPIDs". This is used to select PID which shall be manipulated.
        string PlotPID; //the PID controller name chosen by user in the "PlotPIDlist". This is used to select PID which shall be plotted.
        int PlotPIDindex = 0; //index of the PID controller name chosen by user in the "PlotPIDlist". This is used to select PID which shall be plotted.
        Boolean IsAnyPIDSelectedByUser = false; //state: any PID is selected by user to manipulate
        float chartHorizon = 20;

        public Form1()
        {           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //when form loaded
        {
          // Add Port names to Portname List
            foreach (string port in PortNames) 
            {
                SerialPortBox.Items.Add(port);
                SerialPortBox.SelectedIndex = 0;
            }
            // Add baud rate options to Baud Rate List
            BaudRateBox.Items.Add("4800");
            BaudRateBox.Items.Add("9600");
            BaudRateBox.Items.Add("115200");
            BaudRateBox.SelectedIndex = 2;
            ConnectionStatus.Text = "Port Status : Not Connected";

            // init Start/Stop Button
            if (serialPort1.IsOpen==false)
            {
                buttonStrtStp.Text = "Start";
                buttonStrtStp.ForeColor = Color.Green;
            }
            else
            { serialPort1.Close(); }
            //init folder path
            FolderPath.Text = @"C:\Users\Default\Documents\ControllerVision";
        }
        
        // Start/Stop Button  
        private void buttonStrtStp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(FolderPath.Text))
                { Directory.CreateDirectory(FolderPath.Text); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            if (serialPort1.IsOpen == false)
            {
                if (SerialPortBox.Text == "")
                    return;
                serialPort1.PortName = SerialPortBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(BaudRateBox.Text);
                try
                {
                    serialPort1.Open();
                    serialPort1.ReadTimeout = 20000;
                    serialPort1.WriteTimeout = 20000;
                    ConnectionStatus.Text = "Port Status : Connected";
                    buttonStrtStp.Text = "Stop";
                    buttonStrtStp.ForeColor = Color.Red;
                    SerialPeriod = Convert.ToUInt16(SerialPeriodInBox.Text);
                    if (SerialPeriod >= 1)
                    {
                        timer1.Interval = SerialPeriod;
                    }
                    else
                    {
                        SerialPeriod = 100;
                        SerialPeriodInBox.Text = "100";
                        timer1.Interval = SerialPeriod;
                        MessageBox.Show("Serial Communication Period Must Be Greater Than 0");
                    }
                    timer1.Start();
                    //Reset Chart
                    chart1.Series[0].Points.Clear();
                    chart1.Series[1].Points.Clear();
                    chart1.Series[2].Points.Clear();
                    chart1.Series[3].Points.Clear();
                    chart1.Series[4].Points.Clear();
                    chart1.Update();
                    chart1.ResetAutoValues();
                    chart1.ChartAreas[0].AxisX.Maximum = TimeInSec;
                    chart1.ChartAreas[0].AxisX.Minimum = TimeInSec - 1;

                    label8.Visible = false;
                    MeasFilePathBox.Visible = false;
                    PlotButton.Visible = false;
                    chartHorizon = Convert.ToSingle(HorizonInBox.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed\n" + ex.Message);
                    throw;
                }
        

            }
            else
            {
                ConnectionStatus.Text = "Port Status : Not Connected";
                serialPort1.Close();
                buttonStrtStp.Text = "Start";
                buttonStrtStp.ForeColor = Color.Green;
                timer1.Stop();

                label8.Visible = true;
                MeasFilePathBox.Visible = true;
                PlotButton.Visible = true;
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            double SerialPeriodinSec= Math.Round((double)SerialPeriod / 1000.0, 2);
            TimeInSec=(counter * SerialPeriod / 1000.0);
            label1.Text = SerialMessage;
            
            if (TimeInSec<=1.0)
            {
                counter++;
                return;
            }
            
            foreach (String name in PIDnames)
            {
                if(!(comboBoxPIDs.Items.Contains(name)))
                    { comboBoxPIDs.Items.Add(name); }

                if (!(PlotPIDlist.Items.Contains(name)))
                { PlotPIDlist.Items.Add(name); }
            }
            if (comboBoxPIDs.Items.Count > 0)
            {
                if(comboBoxPIDs.SelectedIndex==-1)
                {
                    comboBoxPIDs.SelectedIndex = 0;
                    ChosenPID = comboBoxPIDs.Text;
                    ChosenPIDindex = PIDnames.IndexOf(ChosenPID);
                }

                if (PlotPIDlist.SelectedIndex == -1)
                {
                    PlotPIDlist.SelectedIndex = 0;
                    PlotPID = PlotPIDlist.Text;
                    PlotPIDindex = PIDnames.IndexOf(PlotPID);
                }

                IsAnyPIDSelectedByUser = true;

                        labelK.Text = PIDs.ElementAt(ChosenPIDindex).K;
                        labelTi.Text = PIDs.ElementAt(ChosenPIDindex).Ti;
                        labelTd.Text = PIDs.ElementAt(ChosenPIDindex).Td;
                        labelN.Text = PIDs.ElementAt(ChosenPIDindex).N;
                        labelB.Text = PIDs.ElementAt(ChosenPIDindex).b;
                        labelC.Text = PIDs.ElementAt(ChosenPIDindex).c;
                        labelCSmin.Text = PIDs.ElementAt(ChosenPIDindex).CSmin;
                        labelCSmax.Text = PIDs.ElementAt(ChosenPIDindex).CSmax;
                        labelSamplingTime.Text = PIDs.ElementAt(ChosenPIDindex).Ts;
                        labelSetPoint.Text = PIDs.ElementAt(ChosenPIDindex).S_P;
                        labelPV.Text = PIDs.ElementAt(ChosenPIDindex).PV;
                        labelCS.Text = PIDs.ElementAt(ChosenPIDindex).CS;
                        labelHI.Text = PIDs.ElementAt(ChosenPIDindex).HI;
                        labelLO.Text = PIDs.ElementAt(ChosenPIDindex).LO;
                        labelTR.Text = PIDs.ElementAt(ChosenPIDindex).TR;
                        labelTS.Text = PIDs.ElementAt(ChosenPIDindex).TS;
                        labelFp.Text = PIDs.ElementAt(ChosenPIDindex).Fp;
                        labelFm.Text = PIDs.ElementAt(ChosenPIDindex).Fm;
                        

                //Record PID values to file {Time, SP, PV, CS, HI, LO, TR, TS, Fp, Fm, CSmax, CSmin, K, Ti, Td, N, b, c, Ts}

                foreach (PID ctrl in PIDs)
                {
                    string content = String.Concat(TimeInSec.ToString(),",", ctrl.S_P,",", ctrl.PV,",", ctrl.CS,"," ,ctrl.HI,",",ctrl.LO,",", ctrl.TR,",", ctrl.TS,",",
                        ctrl.Fp,",", ctrl.Fm,",", ctrl.CSmax,",", ctrl.CSmin,",", ctrl.K,",", ctrl.Ti,",",
                        ctrl.Td,",", ctrl.N,",", ctrl.b,",", ctrl.c,"," ,ctrl.Ts,"\n") ;
                    
                    using (System.IO.StreamWriter Ctrl_Logger = new System.IO.StreamWriter(Path.Combine(FolderPath.Text, ctrl.fileName), true))
                    { Ctrl_Logger.Write(content); }

                }

                //Plot chart
                try
                {
                    if ((chart1.ChartAreas[0].AxisX.Maximum - chart1.ChartAreas[0].AxisX.Minimum) > chartHorizon)
                    {
                        chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Maximum - chartHorizon;
                        chart1.ChartAreas[0].AxisX.Interval = 1;
                        try
                        {
                            chart1.Series[0].Points.RemoveAt(1);
                            chart1.Series[1].Points.RemoveAt(1);
                            chart1.Series[2].Points.RemoveAt(1);
                            chart1.Series[3].Points.RemoveAt(1);
                            chart1.Series[4].Points.RemoveAt(1);
                            chart1.ChartAreas[0].RecalculateAxesScale();
                        }
                        catch {; }
                    }
                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "#.#";
                    chart1.ChartAreas[0].AxisX.Maximum = TimeInSec;

                    if (SPcheckbox.Checked == true) { chart1.Series[0].Points.AddXY(Math.Round(counter * SerialPeriodinSec, 2), Convert.ToSingle(PIDs.ElementAt(PlotPIDindex).S_P)); }
                    else { chart1.Series[0].Points.Clear(); }
                    if (PVcheck.Checked == true) { chart1.Series[1].Points.AddXY(Math.Round(counter * SerialPeriodinSec, 2), Convert.ToSingle(PIDs.ElementAt(PlotPIDindex).PV)); }
                    else { chart1.Series[1].Points.Clear(); }
                    if (CScheck.Checked == true) { chart1.Series[2].Points.AddXY(Math.Round(counter * SerialPeriodinSec, 2), Convert.ToSingle(PIDs.ElementAt(PlotPIDindex).CS)); }
                    else { chart1.Series[2].Points.Clear(); }
                    if (HIcheck.Checked == true) { chart1.Series[3].Points.AddXY(Math.Round(counter * SerialPeriodinSec, 2), Convert.ToSingle(PIDs.ElementAt(PlotPIDindex).HI)); }
                    else { chart1.Series[3].Points.Clear(); }
                    if (LOcheck.Checked == true) { chart1.Series[4].Points.AddXY(Math.Round(counter * SerialPeriodinSec, 2), Convert.ToSingle(PIDs.ElementAt(PlotPIDindex).LO)); }
                    else { chart1.Series[4].Points.Clear(); }

                    chart1.Series[0].Color = Color.Blue;
                    chart1.Series[1].Color = Color.Red;
                    chart1.Series[2].Color = Color.Brown;
                    chart1.Series[3].Color = Color.DarkOrange;
                    chart1.Series[4].Color = Color.DarkTurquoise;
                    chart1.Series[0].BorderWidth = 5;
                    chart1.Series[1].BorderWidth = 5;
                    chart1.Series[2].BorderWidth = 5;
                    chart1.Series[3].BorderWidth = 5;
                    chart1.Series[4].BorderWidth = 5;
                }
                catch
                {; }

            }
            counter++;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(serialPort1.IsOpen==true)
            { serialPort1.Close(); }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SetPointInBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SetPointInBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void SetPointInBox_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void SetPointInBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SetPointInBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           // PIDs.ElementAt(ChosenPIDindex).internalCommode = 2;
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateParams_Click(object sender, EventArgs e)
        {
            PIDs.ElementAt(ChosenPIDindex).internalCommode = 1;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PIDs.ElementAt(ChosenPIDindex).internalCommode = 2;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            try
            {

                SerialMessage = serialPort1.ReadLine();
                
                string[] SplitMessage = SerialMessage.Split(',');
                int lngt = SplitMessage.Length;
                if ((SplitMessage[0]=="start")&&(SplitMessage[lngt-1].Contains("end")))
                {
                    
                    if(!(PIDnames.Contains(SplitMessage[2])))
                    {
                        PIDnames.Add(SplitMessage[2]);
                        PIDs.Add(new PID(SplitMessage[2]));
                    }

                    int IndexOfPIDs= PIDnames.IndexOf(SplitMessage[2]);
                    PIDs.ElementAt(IndexOfPIDs).ArduinoCommode = Int32.Parse(SplitMessage[1]);

                    if (IsAnyPIDSelectedByUser)
                    {

                        switch (PIDs.ElementAt(ChosenPIDindex).internalCommode)
                        {
                            case 0:
                                PIDs.ElementAt(ChosenPIDindex).TXmessage = String.Concat("start,0,", PIDs.ElementAt(ChosenPIDindex).ControllerName, ",end");
                                break;
                            case 1:
                                PIDs.ElementAt(ChosenPIDindex).TXmessage = String.Concat("start", ",", "1", ',', PIDs.ElementAt(ChosenPIDindex).ControllerName, ",", textBoxK.Text, ",", textBoxTi.Text, ",", textBoxTd.Text, ",", textBoxN.Text, ",", textBoxB.Text, ",", textBoxC.Text, ",", textBoxSamplingTime.Text, ",", "end");
                                break;
                            case 2:
                                PIDs.ElementAt(ChosenPIDindex).TXmessage = String.Concat("start", ",", "2", ",", PIDs.ElementAt(ChosenPIDindex).ControllerName, ",", textBoxTR.Text, ",", textBoxTS.Text, ",", textBoxFp.Text, ",", textBoxFm.Text, ",", textBoxCSmin.Text, ",", textBoxCSmax.Text, ",", SetPointInBox.Text, ",", "end");
                                break;
                            default:
                                PIDs.ElementAt(ChosenPIDindex).TXmessage = String.Concat("start,3,", PIDs.ElementAt(ChosenPIDindex).ControllerName, ",end");
                                break;
                        }


                        serialPort1.WriteLine(PIDs.ElementAt(ChosenPIDindex).TXmessage);
                    }

                    switch (PIDs.ElementAt(IndexOfPIDs).ArduinoCommode)
                    {
                        case 0:
                            PIDs.ElementAt(IndexOfPIDs).K= SplitMessage[3];
                            PIDs.ElementAt(IndexOfPIDs).Ti= SplitMessage[4];
                            PIDs.ElementAt(IndexOfPIDs).Td = SplitMessage[5];
                            PIDs.ElementAt(IndexOfPIDs).N = SplitMessage[6];
                            PIDs.ElementAt(IndexOfPIDs).b = SplitMessage[7];
                            PIDs.ElementAt(IndexOfPIDs).c = SplitMessage[8];
                            PIDs.ElementAt(IndexOfPIDs).CSmin = SplitMessage[9];
                            PIDs.ElementAt(IndexOfPIDs).CSmax = SplitMessage[10];
                            PIDs.ElementAt(IndexOfPIDs).Ts = SplitMessage[11];
                            PIDs.ElementAt(IndexOfPIDs).S_P = SplitMessage[12];
                            PIDs.ElementAt(IndexOfPIDs).PV = SplitMessage[13];
                            PIDs.ElementAt(IndexOfPIDs).CS = SplitMessage[14];
                            PIDs.ElementAt(IndexOfPIDs).HI = SplitMessage[15];
                            PIDs.ElementAt(IndexOfPIDs).LO = SplitMessage[16];
                            PIDs.ElementAt(IndexOfPIDs).TR = SplitMessage[17];
                            PIDs.ElementAt(IndexOfPIDs).TS = SplitMessage[18];
                            PIDs.ElementAt(IndexOfPIDs).Fp = SplitMessage[19];
                            PIDs.ElementAt(IndexOfPIDs).Fm = SplitMessage[20];
                            //if (PIDs.ElementAt(IndexOfPIDs).internalCommode == 0) { PIDs.ElementAt(IndexOfPIDs).internalCommode =3 ; }
                            break;
                        case 1:
                            PIDs.ElementAt(IndexOfPIDs).K = SplitMessage[3];
                            PIDs.ElementAt(IndexOfPIDs).Ti = SplitMessage[4];
                            PIDs.ElementAt(IndexOfPIDs).Td = SplitMessage[5];
                            PIDs.ElementAt(IndexOfPIDs).N = SplitMessage[6];
                            PIDs.ElementAt(IndexOfPIDs).b = SplitMessage[7];
                            PIDs.ElementAt(IndexOfPIDs).c = SplitMessage[8];
                            PIDs.ElementAt(IndexOfPIDs).Ts = SplitMessage[9];
                            PIDs.ElementAt(IndexOfPIDs).S_P = SplitMessage[10];
                            PIDs.ElementAt(IndexOfPIDs).PV = SplitMessage[11];
                            PIDs.ElementAt(IndexOfPIDs).CS = SplitMessage[12];
                            PIDs.ElementAt(IndexOfPIDs).HI = SplitMessage[13];
                            PIDs.ElementAt(IndexOfPIDs).LO = SplitMessage[14];
                            if (PIDs.ElementAt(IndexOfPIDs).internalCommode == 1) { PIDs.ElementAt(IndexOfPIDs).internalCommode = 0; }
                            break;
                        case 2:
                            PIDs.ElementAt(IndexOfPIDs).TR = SplitMessage[3];
                            PIDs.ElementAt(IndexOfPIDs).TS = SplitMessage[4];
                            PIDs.ElementAt(IndexOfPIDs).Fp = SplitMessage[5];
                            PIDs.ElementAt(IndexOfPIDs).Fm = SplitMessage[6];
                            PIDs.ElementAt(IndexOfPIDs).CSmin = SplitMessage[7];
                            PIDs.ElementAt(IndexOfPIDs).CSmax = SplitMessage[8];
                            PIDs.ElementAt(IndexOfPIDs).S_P = SplitMessage[9];
                            PIDs.ElementAt(IndexOfPIDs).PV = SplitMessage[10];
                            PIDs.ElementAt(IndexOfPIDs).CS = SplitMessage[11];
                            PIDs.ElementAt(IndexOfPIDs).HI = SplitMessage[12];
                            PIDs.ElementAt(IndexOfPIDs).LO = SplitMessage[13];
                            if (PIDs.ElementAt(IndexOfPIDs).internalCommode == 2) { PIDs.ElementAt(IndexOfPIDs).internalCommode = 0; }

                            break;
                        default:
                            PIDs.ElementAt(IndexOfPIDs).S_P = SplitMessage[3];
                            PIDs.ElementAt(IndexOfPIDs).PV = SplitMessage[4];
                            PIDs.ElementAt(IndexOfPIDs).CS = SplitMessage[5];
                            PIDs.ElementAt(IndexOfPIDs).HI = SplitMessage[6];
                            PIDs.ElementAt(IndexOfPIDs).LO = SplitMessage[7];
                            
                            break;
                    }
 
                }


            }
            catch 
            {
            }

        }

        private void comboBoxPIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenPID = comboBoxPIDs.Text;
            ChosenPIDindex = PIDnames.IndexOf(ChosenPID);
            PIDs.ElementAt(ChosenPIDindex).internalCommode = 0;

            textBoxK.Text = PIDs.ElementAt(ChosenPIDindex).K; labelK.Text = PIDs.ElementAt(ChosenPIDindex).K;
            textBoxTi.Text = PIDs.ElementAt(ChosenPIDindex).Ti; labelTi.Text = PIDs.ElementAt(ChosenPIDindex).Ti;
            textBoxTd.Text = PIDs.ElementAt(ChosenPIDindex).Td; labelTd.Text = PIDs.ElementAt(ChosenPIDindex).Td;
            textBoxN.Text = PIDs.ElementAt(ChosenPIDindex).N; labelN.Text = PIDs.ElementAt(ChosenPIDindex).N;
            textBoxB.Text = PIDs.ElementAt(ChosenPIDindex).b; labelB.Text = PIDs.ElementAt(ChosenPIDindex).b;
            textBoxC.Text = PIDs.ElementAt(ChosenPIDindex).c; labelC.Text = PIDs.ElementAt(ChosenPIDindex).c;
            textBoxCSmin.Text = PIDs.ElementAt(ChosenPIDindex).CSmin; labelCSmin.Text = PIDs.ElementAt(ChosenPIDindex).CSmin;
            textBoxCSmax.Text = PIDs.ElementAt(ChosenPIDindex).CSmax; labelCSmax.Text = PIDs.ElementAt(ChosenPIDindex).CSmax;
            textBoxSamplingTime.Text = PIDs.ElementAt(ChosenPIDindex).Ts; labelSamplingTime.Text = PIDs.ElementAt(ChosenPIDindex).Ts;
            SetPointInBox.Text = PIDs.ElementAt(ChosenPIDindex).S_P; labelSetPoint.Text = PIDs.ElementAt(ChosenPIDindex).S_P;
            labelPV.Text = PIDs.ElementAt(ChosenPIDindex).PV;
            labelCS.Text = PIDs.ElementAt(ChosenPIDindex).CS;
            labelHI.Text = PIDs.ElementAt(ChosenPIDindex).HI;
            labelLO.Text = PIDs.ElementAt(ChosenPIDindex).LO;
            textBoxTR.Text = PIDs.ElementAt(ChosenPIDindex).TR; labelTR.Text = PIDs.ElementAt(ChosenPIDindex).TR;
            textBoxTS.Text = PIDs.ElementAt(ChosenPIDindex).TS; labelTS.Text = PIDs.ElementAt(ChosenPIDindex).TS;
            textBoxFp.Text = PIDs.ElementAt(ChosenPIDindex).Fp; labelFp.Text = PIDs.ElementAt(ChosenPIDindex).Fp;
            textBoxFm.Text = PIDs.ElementAt(ChosenPIDindex).Fm; labelFm.Text = PIDs.ElementAt(ChosenPIDindex).Fm;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void PlotPIDlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PlotPID = PlotPIDlist.Text;
                PlotPIDindex = PIDnames.IndexOf(PlotPID);
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                chart1.Series[3].Points.Clear();
                chart1.Series[4].Points.Clear();
                chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Maximum - SerialPeriod / 1000.0;
            }
            catch {; }
        }

        private void PlotButton_Click(object sender, EventArgs e)
        {
            try
                {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                chart1.Series[3].Points.Clear();
                chart1.Series[4].Points.Clear();
                chart1.Update();
                chart1.ResetAutoValues();
                }
            catch {; }

            string[] Lines;
            string[] SplitLine;
            Boolean plotInited = true;
            Single axisMin=0;
            Single axisMax=1;
            try
            {
                if (!File.Exists(MeasFilePathBox.Text))
                { MessageBox.Show("Invalid Measurement File"); }
                else
                {
                    Lines = File.ReadAllLines(MeasFilePathBox.Text);
                    foreach (string line in Lines)
                    {
                        SplitLine = line.Split(',');
                        if (SplitLine.Length == 19)
                        {
                            if (plotInited)
                            {
                                axisMin = Convert.ToSingle(SplitLine[0]);
                                plotInited = false;
                            }
                            else { axisMax = Convert.ToSingle(SplitLine[0]); }
                            if (SPcheckbox.Checked == true) { chart1.Series[0].Points.AddXY(Convert.ToSingle(SplitLine[0]), Convert.ToSingle(SplitLine[1])); }
                            if (PVcheck.Checked == true) { chart1.Series[1].Points.AddXY(Convert.ToSingle(SplitLine[0]), Convert.ToSingle(SplitLine[2])); }
                            if (CScheck.Checked == true) { chart1.Series[2].Points.AddXY(Convert.ToSingle(SplitLine[0]), Convert.ToSingle(SplitLine[3])); }
                            if (HIcheck.Checked == true) { chart1.Series[3].Points.AddXY(Convert.ToSingle(SplitLine[0]), Convert.ToSingle(SplitLine[4])); }
                            if (LOcheck.Checked == true) { chart1.Series[4].Points.AddXY(Convert.ToSingle(SplitLine[0]), Convert.ToSingle(SplitLine[5])); }
                        }

                        chart1.ChartAreas[0].AxisX.LabelStyle.Format = "#.##";
                        chart1.Series[0].Color = Color.Blue;
                        chart1.Series[1].Color = Color.Red;
                        chart1.Series[2].Color = Color.Brown;
                        chart1.Series[3].Color = Color.DarkOrange;
                        chart1.Series[4].Color = Color.DarkTurquoise;
                        chart1.Series[0].BorderWidth = 5;
                        chart1.Series[1].BorderWidth = 5;
                        chart1.Series[2].BorderWidth = 5;
                        chart1.Series[3].BorderWidth = 5;
                        chart1.Series[4].BorderWidth = 5;
                    }
                    chart1.ChartAreas[0].AxisX.Maximum = axisMax;
                    chart1.ChartAreas[0].AxisX.Minimum = axisMin;
                    chart1.ChartAreas[0].AxisX.Interval = (axisMax-axisMin)/20;
                    chart1.ResetAutoValues();
                }
            }
            catch {; }

        }


    }

    class PID
    {
        public string K, Ti, Td, N, b, c, CSmin, CSmax, Ts; 
        public string TS, Fp, Fm, HI, LO;
        public string S_P, PV, TR, CS;
        public int internalCommode, ArduinoCommode;
        public string TXmessage;
        public string ControllerName;
        public Boolean active;
        public string fileName;
        
        public PID(string Name)
        { internalCommode = 0;
          ArduinoCommode = 0;
          active = false;
          ControllerName = Name;
          fileName=String.Concat(ControllerName,"_",DateTime.Now.ToString("yyyy_M_d_hh_mm"),".txt");
        }
    }
}
