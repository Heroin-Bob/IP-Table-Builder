using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTableBuilder
{
    public partial class formIPTableBuilder : Form
    {
        public formIPTableBuilder()
        {
            InitializeComponent();
        }
        
        //Function to quickly convert numbers to binary strings
        private string toBinary(int intValue)
        {
            return Convert.ToString(intValue,2);
        }


        //Function to return the type of network class the IP address is
        private string IPClass(int firstOctet)
        {
            if (firstOctet <= 126)
            {
                return "A";
            }
            else if (firstOctet >= 127 && firstOctet <= 191)
            {
                return "B";
            }
            else if (firstOctet >= 192 && firstOctet <= 223)
            {
                return "C";
            }
            else
            {
                return "D";
            }
        }

        //Yeah, I could have done this another way, but I didn't.
        string[] HostBits = new string [4];
        int[] HostInt = new int[4];
        string[] NetworkBits = new string[4];
        int[] NetworkInt = new int[4];

        //Define the host bits and pass them in the array HostBits[]
        private void getHostBits(string classType)
        {
            switch (classType) {
                case "A":
                    HostBits[0] = "11111111";
                    HostBits[1] = "00000000";
                    HostBits[2] = "00000000";
                    HostBits[3] = "00000000";
                    NetworkBits[0] = "00000000";
                    NetworkBits[1] = "11111111";
                    NetworkBits[2] = "11111111";
                    NetworkBits[3] = "11111111";
                    break;
                case "B":
                    HostBits[0] = "11111111";
                    HostBits[1] = "11111111";
                    HostBits[2] = "00000000";
                    HostBits[3] = "00000000";
                    NetworkBits[0] = "00000000";
                    NetworkBits[1] = "00000000";
                    NetworkBits[2] = "11111111";
                    NetworkBits[3] = "11111111";
                    break;
                case "C":
                    HostBits[0] = "11111111";
                    HostBits[1] = "11111111";
                    HostBits[2] = "11111111";
                    HostBits[3] = "00000000";
                    NetworkBits[0] = "00000000";
                    NetworkBits[1] = "00000000";
                    NetworkBits[2] = "00000000";
                    NetworkBits[3] = "11111111";
                    break;
                case "D":
                    HostBits[0] = "11111111";
                    HostBits[1] = "11111111";
                    HostBits[2] = "11111111";
                    HostBits[3] = "11111111";
                    NetworkBits[0] = "00000000";
                    NetworkBits[1] = "00000000";
                    NetworkBits[2] = "00000000";
                    NetworkBits[3] = "00000000";
                    break;
            }
            HostInt[0] = Convert.ToInt32(HostBits[0]);
            HostInt[1] = Convert.ToInt32(HostBits[1]);
            HostInt[2] = Convert.ToInt32(HostBits[2]);
            HostInt[3] = Convert.ToInt32(HostBits[3]);
            NetworkInt[0] = Convert.ToInt32(NetworkBits[0]);
            NetworkInt[1] = Convert.ToInt32(NetworkBits[1]);
            NetworkInt[2] = Convert.ToInt32(NetworkBits[2]);
            NetworkInt[3] = Convert.ToInt32(NetworkBits[3]);
        }

        private void btnFireLasers_Click(object sender, EventArgs e)
        {
            try
            {
                //Assign each octect
                int oct1 = Convert.ToInt16(boxIP1.Text);
                int oct2 = Convert.ToInt16(boxIP2.Text);
                int oct3 = Convert.ToInt16(boxIP3.Text);
                int oct4 = Convert.ToInt16(boxIP4.Text);

                //Error handling for if one of the octets is greater than 255
                if (oct1 > 255 || oct2 > 255 || oct3 > 255 || oct4 > 255)
                {
                    MessageBox.Show("One of your octets are too large.");
                    return;
                }

                //Convert each octet to binary
                string oct1bin = toBinary(oct1);
                string oct2bin = toBinary(oct2);
                string oct3bin = toBinary(oct3);
                string oct4bin = toBinary(oct4);

                //Build the full starting IP address
                string startingIP = oct1.ToString() + "." + oct2.ToString() + "." + oct3.ToString() + "." + oct4.ToString();

                //Get the IP class
                string IPClassType = IPClass(oct1);
                boxClassType.Text = IPClassType;

                //Define the host bits using the array HostBits[] for binary and HostInt[] for integers
                //Also defines network bits using NetworkBits[] for binary and NetworkInt[] for integers
                getHostBits(IPClassType);
                


            }
            catch
            {
                MessageBox.Show("Oof.");
                return;
            }

            
        }
    }
}
