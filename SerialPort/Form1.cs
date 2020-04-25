using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;

namespace SerialPort
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker;
        string receivedData = "";
        string[] sPorts;
        public Form1()
        {
            InitializeComponent();
            sPorts = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in sPorts)
            {
                cbPort.Items.Add(port);
            }
            if (cbPort.Items.Count!=0)
            {
                cbPort.SelectedIndex = 0;
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            worker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            worker.RunWorkerAsync();
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = serialPort1.ReadLine();
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
            }
            catch (Exception)
            {
                MessageBox.Show("COM port disconnected");
                this.BeginInvoke(new MethodInvoker(delegate 
                {
                    RefreshUI(); 
                }));
            }
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            receivedData += line;
            lResult.Text = receivedData;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbParity.SelectedIndex = 0;
            cbStopBit.SelectedIndex = 1;
            cbFlowControl.SelectedIndex = 0;
            cbCommands.SelectedIndex = 0;
            if (sPorts.Contains(serialPort1.PortName) && !serialPort1.IsOpen)
                serialPort1.Open();
            lStatus.Text = "No Serial Port is connected !";
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            nFreq.Value = 10000000;
            receivedData = "";
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            receivedData = "";
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("> 10 " + nFreq.Value.ToString()+"\r\n");
                lStatus.Text = "Success. Command send via "+serialPort1.PortName;
            }
            else
            {
                MessageBox.Show("Port is closed");
                lStatus.Text = "Error! No open serial port connection detected";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void bCommand_Click(object sender, EventArgs e)
        {
            receivedData = "";
            if (serialPort1.IsOpen)
            {
                if (cbCommands.SelectedIndex == 0 || cbCommands.Text == "11")
                {
                    string reg = tbCommand.Text;
                    serialPort1.WriteLine("> 11 "+reg+"\r\n");
                    lStatus.Text = "Success. Command send via " + serialPort1.PortName;
                }
                else if (cbCommands.SelectedIndex == 1 || cbCommands.Text == "13")
                {
                    string pll;
                    if (rbChoice1.Checked)
                    {
                        pll = rbChoice1.Text;
                    }
                    else
                    {
                        pll = rbChoice2.Text; 
                    }
                    serialPort1.WriteLine("> 13 "+pll+"\r\n");
                    lStatus.Text = "Success. Command send via " + serialPort1.PortName;
                }
                else if (cbCommands.SelectedIndex == 2 || cbCommands.Text == "14")
                {
                    string mss;
                    if (rbChoice1.Checked)
                    {
                        mss = rbChoice1.Text;
                    }
                    else
                    {
                        mss = "8";
                    }
                    serialPort1.WriteLine("> 14 "+mss+"\r\n");
                    lStatus.Text = "Success. Command send via " + serialPort1.PortName;
                }
                else if (cbCommands.SelectedIndex == 3 || cbCommands.Text == "15")
                {
                    serialPort1.WriteLine("> 15"+"\r\n");
                    lStatus.Text = "Success. Command send via " + serialPort1.PortName;
                }
                else if (cbCommands.SelectedIndex == 4 || cbCommands.Text == "17")
                {
                    string frq = tbCommand.Text;
                    serialPort1.WriteLine("> 17 "+frq+"\r\n");
                    lStatus.Text = "Success. Command send via " + serialPort1.PortName;
                }
                else if (cbCommands.SelectedIndex == 5 || cbCommands.Text == "18")
                {
                    string frq;
                    if (rbChoice1.Checked)
                    {
                        frq = "1";
                    }
                    else
                    {
                        frq = "0";
                    }
                    serialPort1.WriteLine("> 18 "+frq+"\r\n");
                    lStatus.Text = "Success. Command send via " + serialPort1.PortName;
                }
                else if (cbCommands.SelectedIndex == 6 || cbCommands.Text == "19")
                {
                    string frq;
                    if (rbChoice1.Checked)
                    {
                        frq = "1";
                    }
                    else
                    {
                        frq = "0";
                    }
                    serialPort1.WriteLine("> 19 "+frq+"\r\n");
                    lStatus.Text = "Success. Command send via " + serialPort1.PortName;
                }

            }
            else if(!serialPort1.IsOpen)
            {
                lResult.Text = "Could not retrieve data. No port connected!";
            }
            else
            {
                lResult.Text = "Could not retrieve data!";
            }
        }

        private void cbCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommandInit();
            if (cbCommands.SelectedIndex == 0)
            {
                lCommand.Text = "Read Registry:";
                tbCommand.Visible = true;
            }
            if (cbCommands.SelectedIndex == 1)
            {
                lCommand.Text = "PLL:";
                rbChoice1.Text = "A";
                rbChoice2.Text = "B";
                rbChoice1.Visible = true;
                rbChoice2.Visible = true;
            }
            if (cbCommands.SelectedIndex == 2)
            {
                lCommand.Text = "MS Synth:";
                rbChoice1.Text = "0";
                rbChoice2.Text = "1";
                rbChoice1.Visible = true;
                rbChoice2.Visible = true;
            }
            if (cbCommands.SelectedIndex == 3)
            {
                lCommand.Text = "Returns current Frequency";
            }
            if (cbCommands.SelectedIndex == 4)
            {
                lCommand.Text = "Frequency Step:";
                tbCommand.Visible = true;
            }
            if (cbCommands.SelectedIndex == 5)
            {
                lCommand.Text = "Change Freq.:";
                rbChoice1.Text = "Raise";
                rbChoice2.Text = "Lower";
                rbChoice1.Visible = true;
                rbChoice2.Visible = true;
            }
            if (cbCommands.SelectedIndex == 6)
            {
                lCommand.Text = "Eeprom:";
                rbChoice1.Text = "Save";
                rbChoice2.Text = "Dont save";
                rbChoice1.Visible = true;
                rbChoice2.Visible = true;
            }
        }

        private void CommandInit()
        {
            receivedData = "";
            lCommand.Text = "";
            tbCommand.Visible = false;
            rbChoice1.Visible = false;
            rbChoice2.Visible = false;
        }

        private void BConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            if (cbPort.Text != "") serialPort1.PortName = cbPort.Text;
            if (sPorts.Contains(serialPort1.PortName))
            {
                serialPort1.Open();
                lStatus.Text = serialPort1.PortName + " is connected !";
            }
        }

        private void RefreshUI()
        {
            sPorts = System.IO.Ports.SerialPort.GetPortNames();
            lStatus.Text = "No Serial Port is connected !";
            cbPort.Text = "";
            cbPort.Items.Clear();
            foreach (string port in sPorts)
            {
                cbPort.Items.Add(port);
                //if (!cbPort.Items.Cast<ComboBoxItem>().Any(cbi => cbi.Content.Equals(port)))
                //{
                //    cbPort.Items.Add(port);
                //}
            }
            if (cbPort.Items.Count != 0)
            {
                cbPort.SelectedIndex = 0;
            }
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = System.IO.Ports.SerialPort.GetPortNames();
                List<ManagementBaseObject> ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                            join p in ports on n equals p["DeviceID"].ToString()
                            select n + " - " + p["Caption"]).ToList();
                tList.ForEach(Console.WriteLine);
            }
        }

        private void TermsAndConditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            licenseForm license = new licenseForm();
            license.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commands commands = new Commands();
            commands.ShowDialog();
        }

        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate 
                {
                    RefreshUI(); 
                }));
        }

        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate 
                {
                    RefreshUI(); 
                }));
        }            

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WqlEventQuery insertQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            ManagementEventWatcher insertWatcher = new ManagementEventWatcher(insertQuery);
            insertWatcher.EventArrived += DeviceInsertedEvent;
            insertWatcher.Start();

            WqlEventQuery removeQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            ManagementEventWatcher removeWatcher = new ManagementEventWatcher(removeQuery);
            removeWatcher.EventArrived += DeviceRemovedEvent;
            removeWatcher.Start();
        }
    }
}
