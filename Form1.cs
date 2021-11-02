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
using System.Threading;

namespace PK_PPU
{
    
    public partial class Form1 : Form
    {
        const byte STARTBYTE = 170;
        List<string> list = new List<string>();
        byte[] bufTx = new byte[14];
        byte[] bufRx = new byte[14];        
        int countRx = 0;
        int count_bytes = 0;
        byte bt = 0;
        public static bool endRX = false;
        string[] ports;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
           
        }

        public string send(byte x)
        {
            for(int i = 0; i < ports.Length; i++)
            {
                serialPort1.PortName = ports[i];
                serialPort1.Open();

                if(serialPort1.IsOpen)
                {
                    bufTx[0] = STARTBYTE;
                    bufTx[1] = x;
                    bufTx[13] = calcSumXOR(bufTx, 13);
                    serialPort1.Write(bufTx, 0, 14);

                    Thread.Sleep(100);
                    if (endRX)
                    {
                        endRX = false;
                        Console.WriteLine("Collimator is found: " + ports[i]);
                        serialPort1.Close();
                        return "collimator " + x + " " + ports[i];
                    }
                    else Console.WriteLine("COM is invalid: " + ports[i]);
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
                                if (bufRx[1] % 2 == 0) result = "ТВ" + bufRx[1] / 2;
                                else result = result = "ТПВ" + bufRx[1] / 2;
                                list.Add(result);
                                Console.WriteLine("END RX: " + result); 
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

        }

        private byte calcSumXOR(byte[] bytes, byte length)
        {
            byte sum = 0;
            for (int i = 0; i < length; i++)
                sum ^= bytes[i];
            return sum;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //label1.Text = Convert.ToString("ffff" + bt);          
            
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            string[] array;
            for(byte i = 0; i < 8; i++)
            {
                string temp = send(i);
                //if(!temp.Equals("none"))
                //{
                    //list.Add(temp);
               // }
            }

            array = new string[list.Count];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(list[i]);
                array[i] = list[i];
            }

            comboBoxCollimators.Items.AddRange(array);
            list.Clear();
        }
    }
}
