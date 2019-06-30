namespace ControllerVision
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStrtStp = new System.Windows.Forms.Button();
            this.SerialPortBox = new System.Windows.Forms.ComboBox();
            this.BaudRateBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialPeriodInBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.SetPointInBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelTS = new System.Windows.Forms.Label();
            this.labelFp = new System.Windows.Forms.Label();
            this.labelFm = new System.Windows.Forms.Label();
            this.labelCSmax = new System.Windows.Forms.Label();
            this.labelCSmin = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelTR = new System.Windows.Forms.Label();
            this.labelSetPoint = new System.Windows.Forms.Label();
            this.textBoxTR = new System.Windows.Forms.TextBox();
            this.textBoxTS = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBoxFp = new System.Windows.Forms.TextBox();
            this.textBoxFm = new System.Windows.Forms.TextBox();
            this.textBoxCSmax = new System.Windows.Forms.TextBox();
            this.textBoxCSmin = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxTi = new System.Windows.Forms.TextBox();
            this.textBoxTd = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.labelT_R = new System.Windows.Forms.Label();
            this.labelT_S = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.textBoxSamplingTime = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.labelSamplingTime = new System.Windows.Forms.Label();
            this.labelTi = new System.Windows.Forms.Label();
            this.labelTd = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelPV = new System.Windows.Forms.Label();
            this.labelCS = new System.Windows.Forms.Label();
            this.labelHI = new System.Windows.Forms.Label();
            this.labelLO = new System.Windows.Forms.Label();
            this.buttonUpdateParams = new System.Windows.Forms.Button();
            this.ButtonUpdateInputs = new System.Windows.Forms.Button();
            this.comboBoxPIDs = new System.Windows.Forms.ComboBox();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlotPIDlist = new System.Windows.Forms.ComboBox();
            this.SPcheckbox = new System.Windows.Forms.CheckBox();
            this.PVcheck = new System.Windows.Forms.CheckBox();
            this.CScheck = new System.Windows.Forms.CheckBox();
            this.HIcheck = new System.Windows.Forms.CheckBox();
            this.LOcheck = new System.Windows.Forms.CheckBox();
            this.MeasFilePathBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PlotButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.HorizonInBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStrtStp
            // 
            this.buttonStrtStp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStrtStp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStrtStp.Location = new System.Drawing.Point(281, 9);
            this.buttonStrtStp.Name = "buttonStrtStp";
            this.buttonStrtStp.Size = new System.Drawing.Size(164, 44);
            this.buttonStrtStp.TabIndex = 0;
            this.buttonStrtStp.Text = "Start";
            this.buttonStrtStp.UseVisualStyleBackColor = true;
            this.buttonStrtStp.Click += new System.EventHandler(this.buttonStrtStp_Click);
            // 
            // SerialPortBox
            // 
            this.SerialPortBox.FormattingEnabled = true;
            this.SerialPortBox.Location = new System.Drawing.Point(96, 9);
            this.SerialPortBox.Name = "SerialPortBox";
            this.SerialPortBox.Size = new System.Drawing.Size(149, 24);
            this.SerialPortBox.TabIndex = 2;
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.FormattingEnabled = true;
            this.BaudRateBox.Location = new System.Drawing.Point(96, 39);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(149, 24);
            this.BaudRateBox.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.AutoSize = true;
            this.ConnectionStatus.Location = new System.Drawing.Point(14, 793);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(184, 17);
            this.ConnectionStatus.TabIndex = 4;
            this.ConnectionStatus.Text = "Port Status : Not Connected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 810);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 810);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1153, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // SerialPeriodInBox
            // 
            this.SerialPeriodInBox.Location = new System.Drawing.Point(139, 69);
            this.SerialPeriodInBox.Name = "SerialPeriodInBox";
            this.SerialPeriodInBox.Size = new System.Drawing.Size(106, 22);
            this.SerialPeriodInBox.TabIndex = 10;
            this.SerialPeriodInBox.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Serial Period(ms):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(15, 486);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "SP";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Legend = "Legend1";
            series7.Name = "PV";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.Name = "CS";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Legend = "Legend1";
            series9.Name = "HI";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Legend = "Legend1";
            series10.Name = "LO";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(1512, 304);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Set Point :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // SetPointInBox
            // 
            this.SetPointInBox.Location = new System.Drawing.Point(96, 128);
            this.SetPointInBox.Name = "SetPointInBox";
            this.SetPointInBox.Size = new System.Drawing.Size(100, 22);
            this.SetPointInBox.TabIndex = 17;
            this.SetPointInBox.TextChanged += new System.EventHandler(this.SetPointInBox_TextChanged);
            this.SetPointInBox.Enter += new System.EventHandler(this.SetPointInBox_Enter);
            this.SetPointInBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPointInBox_KeyPress);
            this.SetPointInBox.Leave += new System.EventHandler(this.SetPointInBox_Leave);
            this.SetPointInBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SetPointInBox_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "TR :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "TS :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Controller Inputs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Fp :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "K :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "Ti :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(236, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Td :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(243, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "N :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(244, 238);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "b :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(244, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 17);
            this.label20.TabIndex = 27;
            this.label20.Text = "c :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(237, 290);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 17);
            this.label21.TabIndex = 28;
            this.label21.Text = "Ts :";
            // 
            // labelTS
            // 
            this.labelTS.AutoSize = true;
            this.labelTS.Location = new System.Drawing.Point(1104, 186);
            this.labelTS.Name = "labelTS";
            this.labelTS.Size = new System.Drawing.Size(16, 17);
            this.labelTS.TabIndex = 29;
            this.labelTS.Text = "0";
            // 
            // labelFp
            // 
            this.labelFp.AutoSize = true;
            this.labelFp.Location = new System.Drawing.Point(1104, 212);
            this.labelFp.Name = "labelFp";
            this.labelFp.Size = new System.Drawing.Size(16, 17);
            this.labelFp.TabIndex = 30;
            this.labelFp.Text = "0";
            // 
            // labelFm
            // 
            this.labelFm.AutoSize = true;
            this.labelFm.Location = new System.Drawing.Point(1104, 238);
            this.labelFm.Name = "labelFm";
            this.labelFm.Size = new System.Drawing.Size(16, 17);
            this.labelFm.TabIndex = 31;
            this.labelFm.Text = "0";
            // 
            // labelCSmax
            // 
            this.labelCSmax.AutoSize = true;
            this.labelCSmax.Location = new System.Drawing.Point(1104, 264);
            this.labelCSmax.Name = "labelCSmax";
            this.labelCSmax.Size = new System.Drawing.Size(16, 17);
            this.labelCSmax.TabIndex = 32;
            this.labelCSmax.Text = "0";
            // 
            // labelCSmin
            // 
            this.labelCSmin.AutoSize = true;
            this.labelCSmin.Location = new System.Drawing.Point(1104, 290);
            this.labelCSmin.Name = "labelCSmin";
            this.labelCSmin.Size = new System.Drawing.Size(16, 17);
            this.labelCSmin.TabIndex = 33;
            this.labelCSmin.Text = "0";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(1206, 136);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(16, 17);
            this.labelK.TabIndex = 34;
            this.labelK.Text = "0";
            // 
            // labelTR
            // 
            this.labelTR.AutoSize = true;
            this.labelTR.Location = new System.Drawing.Point(1104, 160);
            this.labelTR.Name = "labelTR";
            this.labelTR.Size = new System.Drawing.Size(16, 17);
            this.labelTR.TabIndex = 35;
            this.labelTR.Text = "0";
            // 
            // labelSetPoint
            // 
            this.labelSetPoint.AutoSize = true;
            this.labelSetPoint.Location = new System.Drawing.Point(1104, 134);
            this.labelSetPoint.Name = "labelSetPoint";
            this.labelSetPoint.Size = new System.Drawing.Size(16, 17);
            this.labelSetPoint.TabIndex = 36;
            this.labelSetPoint.Text = "0";
            // 
            // textBoxTR
            // 
            this.textBoxTR.Location = new System.Drawing.Point(96, 154);
            this.textBoxTR.Name = "textBoxTR";
            this.textBoxTR.Size = new System.Drawing.Size(100, 22);
            this.textBoxTR.TabIndex = 37;
            // 
            // textBoxTS
            // 
            this.textBoxTS.Location = new System.Drawing.Point(96, 180);
            this.textBoxTS.Name = "textBoxTS";
            this.textBoxTS.Size = new System.Drawing.Size(100, 22);
            this.textBoxTS.TabIndex = 38;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(59, 233);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 17);
            this.label30.TabIndex = 21;
            this.label30.Text = "Fm :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(35, 260);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 17);
            this.label31.TabIndex = 21;
            this.label31.Text = "CSmax :";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(38, 288);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 17);
            this.label32.TabIndex = 21;
            this.label32.Text = "CSmin :";
            this.label32.Click += new System.EventHandler(this.label31_Click);
            // 
            // textBoxFp
            // 
            this.textBoxFp.Location = new System.Drawing.Point(96, 206);
            this.textBoxFp.Name = "textBoxFp";
            this.textBoxFp.Size = new System.Drawing.Size(100, 22);
            this.textBoxFp.TabIndex = 39;
            // 
            // textBoxFm
            // 
            this.textBoxFm.Location = new System.Drawing.Point(96, 232);
            this.textBoxFm.Name = "textBoxFm";
            this.textBoxFm.Size = new System.Drawing.Size(100, 22);
            this.textBoxFm.TabIndex = 40;
            // 
            // textBoxCSmax
            // 
            this.textBoxCSmax.Location = new System.Drawing.Point(96, 258);
            this.textBoxCSmax.Name = "textBoxCSmax";
            this.textBoxCSmax.Size = new System.Drawing.Size(100, 22);
            this.textBoxCSmax.TabIndex = 41;
            // 
            // textBoxCSmin
            // 
            this.textBoxCSmin.Location = new System.Drawing.Point(96, 284);
            this.textBoxCSmin.Name = "textBoxCSmin";
            this.textBoxCSmin.Size = new System.Drawing.Size(100, 22);
            this.textBoxCSmin.TabIndex = 42;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(244, 105);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(167, 17);
            this.label33.TabIndex = 20;
            this.label33.Text = "Controller Parameters";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(271, 131);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 22);
            this.textBoxK.TabIndex = 43;
            // 
            // textBoxTi
            // 
            this.textBoxTi.Location = new System.Drawing.Point(271, 157);
            this.textBoxTi.Name = "textBoxTi";
            this.textBoxTi.Size = new System.Drawing.Size(100, 22);
            this.textBoxTi.TabIndex = 44;
            // 
            // textBoxTd
            // 
            this.textBoxTd.Location = new System.Drawing.Point(271, 183);
            this.textBoxTd.Name = "textBoxTd";
            this.textBoxTd.Size = new System.Drawing.Size(100, 22);
            this.textBoxTd.TabIndex = 45;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(271, 209);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 46;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(271, 235);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 47;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(271, 261);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 22);
            this.textBoxC.TabIndex = 48;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(1029, 105);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(152, 17);
            this.label34.TabIndex = 20;
            this.label34.Text = "Controller Variables";
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(1029, 134);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(73, 17);
            this.labelSP.TabIndex = 16;
            this.labelSP.Text = "Set Point :";
            this.labelSP.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelT_R
            // 
            this.labelT_R.AutoSize = true;
            this.labelT_R.Location = new System.Drawing.Point(1067, 160);
            this.labelT_R.Name = "labelT_R";
            this.labelT_R.Size = new System.Drawing.Size(35, 17);
            this.labelT_R.TabIndex = 18;
            this.labelT_R.Text = "TR :";
            // 
            // labelT_S
            // 
            this.labelT_S.AutoSize = true;
            this.labelT_S.Location = new System.Drawing.Point(1068, 186);
            this.labelT_S.Name = "labelT_S";
            this.labelT_S.Size = new System.Drawing.Size(34, 17);
            this.labelT_S.TabIndex = 19;
            this.labelT_S.Text = "TS :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(1070, 212);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(32, 17);
            this.label38.TabIndex = 21;
            this.label38.Text = "Fp :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(1067, 238);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 17);
            this.label39.TabIndex = 21;
            this.label39.Text = "Fm :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(1043, 264);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(59, 17);
            this.label40.TabIndex = 21;
            this.label40.Text = "CSmax :";
            this.label40.Click += new System.EventHandler(this.label31_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1046, 290);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(56, 17);
            this.label41.TabIndex = 21;
            this.label41.Text = "CSmin :";
            this.label41.Click += new System.EventHandler(this.label31_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(1183, 136);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(25, 17);
            this.label42.TabIndex = 22;
            this.label42.Text = "K :";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(1180, 162);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(28, 17);
            this.label43.TabIndex = 23;
            this.label43.Text = "Ti :";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1175, 188);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(33, 17);
            this.label44.TabIndex = 24;
            this.label44.Text = "Td :";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(1182, 214);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(26, 17);
            this.label45.TabIndex = 25;
            this.label45.Text = "N :";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(1183, 240);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(25, 17);
            this.label46.TabIndex = 26;
            this.label46.Text = "B :";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(1183, 266);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(25, 17);
            this.label47.TabIndex = 27;
            this.label47.Text = "C :";
            // 
            // textBoxSamplingTime
            // 
            this.textBoxSamplingTime.Location = new System.Drawing.Point(271, 287);
            this.textBoxSamplingTime.Name = "textBoxSamplingTime";
            this.textBoxSamplingTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxSamplingTime.TabIndex = 49;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(1175, 292);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(32, 17);
            this.label48.TabIndex = 28;
            this.label48.Text = "Ts :";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(1275, 136);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(34, 17);
            this.label49.TabIndex = 22;
            this.label49.Text = "PV :";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(1275, 162);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(34, 17);
            this.label50.TabIndex = 23;
            this.label50.Text = "CS :";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(1280, 188);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(29, 17);
            this.label51.TabIndex = 24;
            this.label51.Text = "HI :";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(1275, 214);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(35, 17);
            this.label52.TabIndex = 25;
            this.label52.Text = "LO :";
            // 
            // labelSamplingTime
            // 
            this.labelSamplingTime.AutoSize = true;
            this.labelSamplingTime.Location = new System.Drawing.Point(1206, 292);
            this.labelSamplingTime.Name = "labelSamplingTime";
            this.labelSamplingTime.Size = new System.Drawing.Size(16, 17);
            this.labelSamplingTime.TabIndex = 50;
            this.labelSamplingTime.Text = "0";
            // 
            // labelTi
            // 
            this.labelTi.AutoSize = true;
            this.labelTi.Location = new System.Drawing.Point(1206, 162);
            this.labelTi.Name = "labelTi";
            this.labelTi.Size = new System.Drawing.Size(16, 17);
            this.labelTi.TabIndex = 51;
            this.labelTi.Text = "0";
            // 
            // labelTd
            // 
            this.labelTd.AutoSize = true;
            this.labelTd.Location = new System.Drawing.Point(1206, 188);
            this.labelTd.Name = "labelTd";
            this.labelTd.Size = new System.Drawing.Size(16, 17);
            this.labelTd.TabIndex = 52;
            this.labelTd.Text = "0";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(1206, 214);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(16, 17);
            this.labelN.TabIndex = 53;
            this.labelN.Text = "0";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(1206, 240);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(16, 17);
            this.labelB.TabIndex = 54;
            this.labelB.Text = "0";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(1206, 266);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(16, 17);
            this.labelC.TabIndex = 55;
            this.labelC.Text = "0";
            // 
            // labelPV
            // 
            this.labelPV.AutoSize = true;
            this.labelPV.Location = new System.Drawing.Point(1306, 136);
            this.labelPV.Name = "labelPV";
            this.labelPV.Size = new System.Drawing.Size(16, 17);
            this.labelPV.TabIndex = 56;
            this.labelPV.Text = "0";
            // 
            // labelCS
            // 
            this.labelCS.AutoSize = true;
            this.labelCS.Location = new System.Drawing.Point(1306, 162);
            this.labelCS.Name = "labelCS";
            this.labelCS.Size = new System.Drawing.Size(16, 17);
            this.labelCS.TabIndex = 57;
            this.labelCS.Text = "0";
            // 
            // labelHI
            // 
            this.labelHI.AutoSize = true;
            this.labelHI.Location = new System.Drawing.Point(1306, 188);
            this.labelHI.Name = "labelHI";
            this.labelHI.Size = new System.Drawing.Size(16, 17);
            this.labelHI.TabIndex = 58;
            this.labelHI.Text = "0";
            // 
            // labelLO
            // 
            this.labelLO.AutoSize = true;
            this.labelLO.Location = new System.Drawing.Point(1306, 214);
            this.labelLO.Name = "labelLO";
            this.labelLO.Size = new System.Drawing.Size(16, 17);
            this.labelLO.TabIndex = 59;
            this.labelLO.Text = "0";
            // 
            // buttonUpdateParams
            // 
            this.buttonUpdateParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateParams.Location = new System.Drawing.Point(271, 315);
            this.buttonUpdateParams.Name = "buttonUpdateParams";
            this.buttonUpdateParams.Size = new System.Drawing.Size(100, 64);
            this.buttonUpdateParams.TabIndex = 60;
            this.buttonUpdateParams.Text = "Update Parameters";
            this.buttonUpdateParams.UseVisualStyleBackColor = true;
            this.buttonUpdateParams.Click += new System.EventHandler(this.buttonUpdateParams_Click);
            // 
            // ButtonUpdateInputs
            // 
            this.ButtonUpdateInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateInputs.Location = new System.Drawing.Point(96, 315);
            this.ButtonUpdateInputs.Name = "ButtonUpdateInputs";
            this.ButtonUpdateInputs.Size = new System.Drawing.Size(100, 64);
            this.ButtonUpdateInputs.TabIndex = 64;
            this.ButtonUpdateInputs.Text = "Update Inputs";
            this.ButtonUpdateInputs.UseVisualStyleBackColor = true;
            this.ButtonUpdateInputs.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPIDs
            // 
            this.comboBoxPIDs.FormattingEnabled = true;
            this.comboBoxPIDs.Location = new System.Drawing.Point(621, 72);
            this.comboBoxPIDs.Name = "comboBoxPIDs";
            this.comboBoxPIDs.Size = new System.Drawing.Size(164, 24);
            this.comboBoxPIDs.TabIndex = 66;
            this.comboBoxPIDs.SelectedIndexChanged += new System.EventHandler(this.comboBoxPIDs_SelectedIndexChanged);
            // 
            // FolderPath
            // 
            this.FolderPath.Location = new System.Drawing.Point(1032, 325);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(290, 22);
            this.FolderPath.TabIndex = 70;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(930, 329);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(96, 17);
            this.label29.TabIndex = 71;
            this.label29.Text = "Log Folder :";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Plot Options:";
            // 
            // PlotPIDlist
            // 
            this.PlotPIDlist.FormattingEnabled = true;
            this.PlotPIDlist.Location = new System.Drawing.Point(1165, 429);
            this.PlotPIDlist.Name = "PlotPIDlist";
            this.PlotPIDlist.Size = new System.Drawing.Size(157, 24);
            this.PlotPIDlist.TabIndex = 73;
            this.PlotPIDlist.SelectedIndexChanged += new System.EventHandler(this.PlotPIDlist_SelectedIndexChanged);
            // 
            // SPcheckbox
            // 
            this.SPcheckbox.AutoSize = true;
            this.SPcheckbox.Checked = true;
            this.SPcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SPcheckbox.Location = new System.Drawing.Point(1077, 459);
            this.SPcheckbox.Name = "SPcheckbox";
            this.SPcheckbox.Size = new System.Drawing.Size(48, 21);
            this.SPcheckbox.TabIndex = 74;
            this.SPcheckbox.Text = "SP";
            this.SPcheckbox.UseVisualStyleBackColor = true;
            // 
            // PVcheck
            // 
            this.PVcheck.AutoSize = true;
            this.PVcheck.Checked = true;
            this.PVcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PVcheck.Location = new System.Drawing.Point(1131, 459);
            this.PVcheck.Name = "PVcheck";
            this.PVcheck.Size = new System.Drawing.Size(48, 21);
            this.PVcheck.TabIndex = 75;
            this.PVcheck.Text = "PV";
            this.PVcheck.UseVisualStyleBackColor = true;
            // 
            // CScheck
            // 
            this.CScheck.AutoSize = true;
            this.CScheck.Location = new System.Drawing.Point(1185, 459);
            this.CScheck.Name = "CScheck";
            this.CScheck.Size = new System.Drawing.Size(48, 21);
            this.CScheck.TabIndex = 76;
            this.CScheck.Text = "CS";
            this.CScheck.UseVisualStyleBackColor = true;
            // 
            // HIcheck
            // 
            this.HIcheck.AutoSize = true;
            this.HIcheck.Location = new System.Drawing.Point(1239, 459);
            this.HIcheck.Name = "HIcheck";
            this.HIcheck.Size = new System.Drawing.Size(43, 21);
            this.HIcheck.TabIndex = 77;
            this.HIcheck.Text = "HI";
            this.HIcheck.UseVisualStyleBackColor = true;
            // 
            // LOcheck
            // 
            this.LOcheck.AutoSize = true;
            this.LOcheck.Location = new System.Drawing.Point(1283, 459);
            this.LOcheck.Name = "LOcheck";
            this.LOcheck.Size = new System.Drawing.Size(49, 21);
            this.LOcheck.TabIndex = 78;
            this.LOcheck.Text = "LO";
            this.LOcheck.UseVisualStyleBackColor = true;
            // 
            // MeasFilePathBox
            // 
            this.MeasFilePathBox.Location = new System.Drawing.Point(160, 429);
            this.MeasFilePathBox.Name = "MeasFilePathBox";
            this.MeasFilePathBox.Size = new System.Drawing.Size(351, 22);
            this.MeasFilePathBox.TabIndex = 79;
            this.MeasFilePathBox.Text = "Type Measurement File Adress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Measurement File:";
            // 
            // PlotButton
            // 
            this.PlotButton.Location = new System.Drawing.Point(517, 429);
            this.PlotButton.Name = "PlotButton";
            this.PlotButton.Size = new System.Drawing.Size(75, 23);
            this.PlotButton.TabIndex = 81;
            this.PlotButton.Text = "Plot";
            this.PlotButton.UseVisualStyleBackColor = true;
            this.PlotButton.Click += new System.EventHandler(this.PlotButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 82;
            this.label9.Text = "Horizon(sec) :";
            // 
            // HorizonInBox
            // 
            this.HorizonInBox.Location = new System.Drawing.Point(160, 458);
            this.HorizonInBox.Name = "HorizonInBox";
            this.HorizonInBox.Size = new System.Drawing.Size(100, 22);
            this.HorizonInBox.TabIndex = 83;
            this.HorizonInBox.Text = "20.0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(469, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 17);
            this.label22.TabIndex = 84;
            this.label22.Text = "Manage Controller:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1118, 432);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 17);
            this.label23.TabIndex = 85;
            this.label23.Text = "Plot:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 837);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.HorizonInBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PlotButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MeasFilePathBox);
            this.Controls.Add(this.LOcheck);
            this.Controls.Add(this.HIcheck);
            this.Controls.Add(this.CScheck);
            this.Controls.Add(this.PVcheck);
            this.Controls.Add(this.SPcheckbox);
            this.Controls.Add(this.PlotPIDlist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.comboBoxPIDs);
            this.Controls.Add(this.ButtonUpdateInputs);
            this.Controls.Add(this.buttonUpdateParams);
            this.Controls.Add(this.labelLO);
            this.Controls.Add(this.labelHI);
            this.Controls.Add(this.labelCS);
            this.Controls.Add(this.labelPV);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelTd);
            this.Controls.Add(this.labelTi);
            this.Controls.Add(this.labelSamplingTime);
            this.Controls.Add(this.textBoxSamplingTime);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxTd);
            this.Controls.Add(this.textBoxTi);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxCSmin);
            this.Controls.Add(this.textBoxCSmax);
            this.Controls.Add(this.textBoxFm);
            this.Controls.Add(this.textBoxFp);
            this.Controls.Add(this.textBoxTS);
            this.Controls.Add(this.textBoxTR);
            this.Controls.Add(this.labelSetPoint);
            this.Controls.Add(this.labelTR);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelCSmin);
            this.Controls.Add(this.labelCSmax);
            this.Controls.Add(this.labelFm);
            this.Controls.Add(this.labelFp);
            this.Controls.Add(this.labelTS);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelT_S);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelT_R);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SetPointInBox);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SerialPeriodInBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectionStatus);
            this.Controls.Add(this.BaudRateBox);
            this.Controls.Add(this.SerialPortBox);
            this.Controls.Add(this.buttonStrtStp);
            this.Name = "Form1";
            this.Text = "Controller Vision";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStrtStp;
        private System.Windows.Forms.ComboBox SerialPortBox;
        private System.Windows.Forms.ComboBox BaudRateBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label ConnectionStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SerialPeriodInBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SetPointInBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelTS;
        private System.Windows.Forms.Label labelFp;
        private System.Windows.Forms.Label labelFm;
        private System.Windows.Forms.Label labelCSmax;
        private System.Windows.Forms.Label labelCSmin;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelTR;
        private System.Windows.Forms.Label labelSetPoint;
        private System.Windows.Forms.TextBox textBoxTR;
        private System.Windows.Forms.TextBox textBoxTS;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBoxFp;
        private System.Windows.Forms.TextBox textBoxFm;
        private System.Windows.Forms.TextBox textBoxCSmax;
        private System.Windows.Forms.TextBox textBoxCSmin;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.TextBox textBoxTi;
        private System.Windows.Forms.TextBox textBoxTd;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label labelT_R;
        private System.Windows.Forms.Label labelT_S;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBoxSamplingTime;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label labelSamplingTime;
        private System.Windows.Forms.Label labelTi;
        private System.Windows.Forms.Label labelTd;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelPV;
        private System.Windows.Forms.Label labelCS;
        private System.Windows.Forms.Label labelHI;
        private System.Windows.Forms.Label labelLO;
        private System.Windows.Forms.Button buttonUpdateParams;
        private System.Windows.Forms.Button ButtonUpdateInputs;
        private System.Windows.Forms.ComboBox comboBoxPIDs;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PlotPIDlist;
        private System.Windows.Forms.CheckBox SPcheckbox;
        private System.Windows.Forms.CheckBox PVcheck;
        private System.Windows.Forms.CheckBox CScheck;
        private System.Windows.Forms.CheckBox HIcheck;
        private System.Windows.Forms.CheckBox LOcheck;
        private System.Windows.Forms.TextBox MeasFilePathBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PlotButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox HorizonInBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

