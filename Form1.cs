using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace PK_PPU
{
    
    public partial class Form1 : Form
    {
        public const byte STARTBYTE = 170;
        List<string> list = new List<string>();
        List<Collimator> collimators = new List<Collimator>();
        public byte[] bufTx = new byte[14];
        public byte[] bufRx = new byte[14];      
        int count_bytes = 0;
        public static bool endRX = false;
        string[] ports;
        Collimator selectedCollimator;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ports = SerialPort.GetPortNames();

        }

        public void sendData(string serialPort, byte[] pack)
        {
            serialPort1.PortName = serialPort;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(pack, 0, 14);
                Thread.Sleep(150);
                serialPort1.Close();
            }
        }
        public string initCollimators(byte x)
        {
            
            for (int i = 0; i < ports.Length; i++)
            {
                serialPort1.PortName = ports[i];
                serialPort1.Open();

                if(serialPort1.IsOpen)
                {
                    bufTx[0] = STARTBYTE;
                    bufTx[1] = x;
                    bufTx[13] = calcSumXOR(bufTx, 13);
                    serialPort1.Write(bufTx, 0, 14);

                    Thread.Sleep(150);
                    if (endRX)
                    {
                        endRX = false;
                        //Console.WriteLine("Collimator is found: " + ports[i]);
                        serialPort1.Close();
                        return "collimator " + x + " " + ports[i];
                    }
                   // else Console.WriteLine("COM is invalid: " + ports[i]);
                    serialPort1.Close();

                }
            }
            return "none";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            endRX = false;
            for(int i = 0; i < 14; i++)
            {
                bufRx[i] = 0;
            }
            while (serialPort1.BytesToRead > 0)
            {
                try
                {
                    bufRx[count_bytes] = (byte)serialPort1.ReadByte();
                    count_bytes++;
                    switch (count_bytes)
                    {
                        case 1: if (bufRx[0] != 170) count_bytes = 0; break;
                        case 14: count_bytes = 0;
                            if (calcSumXOR(bufRx, 14) == 0)
                            {
                                endRX = true;
                                string result = "";
                                if (bufRx[1] % 2 == 0)
                                {
                                    result = "ТВ" + bufRx[1] / 2;
                                    TV_Collimator tvCollimator = new TV_Collimator(result, serialPort1.PortName, bufRx[1]);
                                    Console.WriteLine(tvCollimator);
                                    collimators.Add(tvCollimator);
                                }
                                else
                                {
                                    result = result = "ТПВ" + bufRx[1] / 2;
                                    TPV_Collimator tpvCollimator = new TPV_Collimator(result, serialPort1.PortName, bufRx[1]);
                                    Console.WriteLine(tpvCollimator);
                                    collimators.Add(tpvCollimator);
                                }

                                
                                list.Add(result);
                                //Console.WriteLine("END RX: " + result);                               
                                //Collimator col = new Collimator(list[list.Count - 1], serialPort1.PortName, (byte) (bufRx[1] / 2));                                
                            }
                            break;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                if (endRX == true) break;               
         
            }
            count_bytes = 0;
            
            //this.Invoke(new EventHandler(ShowData));
        }

       /* private void ShowData(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(countRx);
            if (bufRx[1] % 2 == 0) list.Add("ТВ" + bufRx[1] / 2);
            else list.Add("ТПВ" + bufRx[1] / 2);

        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBoxCollimators.SelectedItem.ToString();
            for(int i = 0; i < collimators.Count; i++)
            {
                if(selectedState.Equals(collimators[i].getName()))
                {
                    selectedCollimator = collimators[i];
                    Console.WriteLine(selectedCollimator);
                    break;
                }
            }

            initButtons();
        }

        public static byte calcSumXOR(byte[] bytes, byte length)
        {
            byte sum = 0;
            for (int i = 0; i < length; i++)
                sum ^= bytes[i];
            return sum;
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            comboBoxCollimators.Items.Clear();
            collimators.Clear();

            string[] array;
            for (byte i = 0; i < 8; i++)
            {
                string temp = initCollimators(i);
            }

            array = new string[collimators.Count];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(collimators[i].getName());
                array[i] = collimators[i].getName();
                
            }

            comboBoxCollimators.Enabled = true;
            comboBoxCollimators.Items.AddRange(array);
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            sendData(selectedCollimator.getPort(), selectedCollimator.createPacketToSend());
        }

        private void buttonStop_Click(object sender, EventArgs e)
        { //label1.Text = Convert.ToString("ffff" + bt);       
            Console.WriteLine(selectedCollimator.GetType());
            Console.WriteLine(selectedCollimator.GetType().ToString().Equals("PK_PPU.TV_Collimator"));

            
        }
// ----------------------------------------  Скорость (Сетка 1)
        private void buttonMinusSpeed1_Click(object sender, EventArgs e)
        {
            if(selectedCollimator.getGrid1().getSpeed() > -10)
            {
                selectedCollimator.getGrid1().setSpeed((sbyte)(selectedCollimator.getGrid1().getSpeed() - 1));
                labelSpeed1.Text = Convert.ToString("" + selectedCollimator.getGrid1().getSpeed());
            }            
        }

        private void buttonPlusSpeed1_Click(object sender, EventArgs e)
        {
            if(selectedCollimator.getGrid1().getSpeed() < 10)
            {
                selectedCollimator.getGrid1().setSpeed((sbyte)(selectedCollimator.getGrid1().getSpeed() + 1));
                labelSpeed1.Text = Convert.ToString("" + selectedCollimator.getGrid1().getSpeed());
            }           
        }
// ----------------------------------------  Скорость (Сетка 2)
        private void buttonMinusSpeed2_Click(object sender, EventArgs e)
        {
            if (selectedCollimator.getGrid2().getSpeed() > -10)
            {
                selectedCollimator.getGrid2().setSpeed((sbyte)(selectedCollimator.getGrid2().getSpeed() - 1));
                labelSpeed2.Text = Convert.ToString("" + selectedCollimator.getGrid2().getSpeed());
            }
        }

        private void buttonPlusSpeed2_Click(object sender, EventArgs e)
        {
            if (selectedCollimator.getGrid2().getSpeed() < 10)
            {
                selectedCollimator.getGrid2().setSpeed((sbyte)(selectedCollimator.getGrid2().getSpeed() + 1));
                labelSpeed2.Text = Convert.ToString("" + selectedCollimator.getGrid2().getSpeed());
            }
        }
// ----------------------------------------  Яркость (Сетка 1)
        private void buttonMinusBright1_Click(object sender, EventArgs e)
        {
            if (selectedCollimator.getGrid1().getBright() > 1)
            {
                selectedCollimator.getGrid1().setBright((byte)(selectedCollimator.getGrid1().getBright() - 1));
                labelBr1.Text = Convert.ToString("" + selectedCollimator.getGrid1().getBright());
            }
        }

        private void buttonPlusBright1_Click(object sender, EventArgs e)
        {
           if (selectedCollimator.getGrid1().getBright() < 10)
            {
                selectedCollimator.getGrid1().setBright((byte)(selectedCollimator.getGrid1().getBright() + 1));
                labelBr1.Text = Convert.ToString("" + selectedCollimator.getGrid1().getBright());
            }
        }
// ----------------------------------------  Яркость (Сетка 2)
        private void buttonMinusBright2_Click(object sender, EventArgs e)
        {
            if (selectedCollimator.getGrid2().getBright() > 1)
            {
                selectedCollimator.getGrid2().setBright((byte)(selectedCollimator.getGrid2().getBright() - 1));
                labelBr2.Text = Convert.ToString("" + selectedCollimator.getGrid2().getBright());
            }
        }

        private void buttonPlusBright2_Click(object sender, EventArgs e)
        {
            if (selectedCollimator.getGrid2().getBright() < 10)
            {
                selectedCollimator.getGrid2().setBright((byte)(selectedCollimator.getGrid2().getBright() + 1));
                labelBr2.Text = Convert.ToString("" + selectedCollimator.getGrid2().getBright());
            }
        }

        public void initButtons ()
        {
            buttonMinusSpeed1.Enabled = true;
            buttonPlusSpeed1.Enabled = true;
            buttonMinusBright1.Enabled = true;
            buttonPlusBright1.Enabled = true;

            buttonMinusSpeed2.Enabled = false;
            buttonPlusSpeed2.Enabled = false;
            buttonMinusBright2.Enabled = false;
            buttonPlusBright2.Enabled = false;

            buttonStart.Enabled = true;
            buttonStop.Enabled = true;

            if(selectedCollimator.GetType().ToString().Equals("PK_PPU.TV_Collimator"))
            {
                buttonMinusSpeed2.Enabled = true;
                buttonPlusSpeed2.Enabled = true;
                buttonMinusBright2.Enabled = true;
                buttonPlusBright2.Enabled = true;
            }
        }

        public void deInitButtons()
        {
            buttonMinusSpeed1.Enabled = false;
            buttonPlusSpeed1.Enabled = false;
            buttonMinusBright1.Enabled = false;
            buttonPlusBright1.Enabled = false;

            buttonMinusSpeed2.Enabled = false;
            buttonPlusSpeed2.Enabled = false;
            buttonMinusBright2.Enabled = false;
            buttonPlusBright2.Enabled = false;

            buttonStart.Enabled = false;
           
            buttonMinusSpeed2.Enabled = false;
            buttonPlusSpeed2.Enabled = false;
            buttonMinusBright2.Enabled = false;
            buttonPlusBright2.Enabled = false;            
        }
    }

    abstract class Collimator
     {
        private byte type;
        private string name;
        private string port;
        public Collimator(string name, string port, byte type)
        {
            this.name = name;
            this.port = port;
            this.type = type;
        }

        public abstract Grid getGrid1();


        public abstract Grid getGrid2();

     
        public abstract void printInfo();
        
        public abstract byte[] createPacketToSend();

        public abstract byte getFlags();

        public byte getType()
        {
            return type;
        }

        public string getName()
        {
            return name;
        }

        public string getPort()
        {
            return port;
        }

        public override string ToString()
        {
            return "COLLIMATOR name: " + name + " type: " + type +  " port: " + port;
        }

    }

    class TPV_Collimator : Collimator
    {
        public Grid grid1;
        public TPV_Collimator (string name, string port, byte type) 
            : base(name, port, type)
        {
            grid1 = new Grid();
        }

        public override void printInfo()
        {
            Console.WriteLine("TPV_Collimator");
        }
        public override byte[] createPacketToSend()
        {
            byte[] packToSend = new byte[14];

            packToSend[0] = Form1.STARTBYTE;
            packToSend[1] = getType();
            packToSend[2] = getFlags();
            for (byte i = 3; i < 9; i++)
                packToSend[i] = 0;
            packToSend[9] = grid1.getBright();
            packToSend[10] = 0;
            int speedByte = (grid1.getSpeed() & 0x0F);
            packToSend[11] = (byte)speedByte;
            packToSend[12] = 0;
            packToSend[13] = Form1.calcSumXOR(packToSend, 13);

            return packToSend;
        }

        public override Grid getGrid1 ()
        {
            return grid1;
        }

        public override Grid getGrid2()
        {
            return null;
        }
        public override byte getFlags()
        {
            int bt = 0;

            if (grid1.getStart()) bt |= 0x01;
            else bt &= ~(1 << 0);

            if (grid1.getDirect()) bt |= 0x02;
            else bt &= ~(1 << 1);

            if (grid1.getHeatOn()) bt |= 0x40;
            else bt &= ~(1 << 6);

            return (byte)bt;
        }
    }

    class TV_Collimator : Collimator
    {
        public Grid grid1;
        public Grid grid2;
        public TV_Collimator(string name, string port, byte type)
            : base(name, port, type)
        {
            grid1 = new Grid();
            grid2 = new Grid();
        }

        
        public override void printInfo()
        {
            Console.WriteLine("TV_Collimator");
        }
        public override Grid getGrid1()
        {
            return grid1;
        }

        public override Grid getGrid2()
        {
            return grid2;
        }
        public override byte[] createPacketToSend()
        {
            byte[] packToSend = new byte[14];

            packToSend[0] = Form1.STARTBYTE;
            packToSend[1] = getType();
            packToSend[2] = getFlags();
            for (byte i = 3; i < 9; i++)
                packToSend[i] = 0;
            packToSend[9] = grid1.getBright();
            packToSend[10] = grid2.getBright();
            int speedByte = (grid1.getSpeed() & 0x0F) | (grid2.getSpeed() & 0xF0);
            packToSend[11] = (byte)speedByte;
            packToSend[12] = 0;
            packToSend[13] = Form1.calcSumXOR(packToSend, 13);

            return packToSend;
        }

        public override byte getFlags()
        {
            int bt = 0;

            if (grid1.getStart()) bt |= 0x01;
            else bt &= ~(1 << 0);

            if (grid1.getDirect()) bt |= 0x02;
            else bt &= ~(1 << 1);

            if (grid1.getHeatOn()) bt |= 0x40;
            else bt &= ~(1 << 6);

            if (grid2.getStart()) bt |= 0x04;
            else bt &= ~(1 << 2);

            if (grid2.getDirect()) bt |= 0x08;
            else bt &= ~(1 << 3);

            if (grid1.getHeatOn()) bt |= 0x80;
            else bt &= ~(1 << 7);

            return (byte)bt;
        }
    }

    public class Grid
    {
        private sbyte speed;
        private byte bright;

        private bool direct;
        private bool start;

        private bool heatOn;
        public Grid()
        {
            speed = 0;
            bright = 0;
            direct = false;
            start = false;
            heatOn = false;
        }

        public void setHeatOn(bool heatOn)
        {
            this.heatOn = heatOn;
        }

        public bool getHeatOn()
        {
            return heatOn;
        }
        public void setDirect(bool direct)
        {
            this.direct = direct;
        }

        public bool getDirect()
        {
            return direct;
        }

        public void setStart(bool start)
        {
            this.start = start;
        }

        public bool getStart()
        {
            return start;
        }
        public void setSpeed(sbyte speed)
        {
            this.speed = speed;
        }

        public sbyte getSpeed()
        {
            return speed;
        }

        public void setBright(byte bright)
        {
            this.bright = bright;
        }

        public byte getBright()
        {
            return bright;
        }

    }
}
