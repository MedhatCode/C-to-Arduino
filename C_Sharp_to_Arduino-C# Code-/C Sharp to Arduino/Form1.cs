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
namespace C_Sharp_to_Arduino
{
    public partial class Form1 : Form
    {
        bool state = true;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pwm_Scroll(object sender, EventArgs e)
        {
            value.Text = pwm.Value.ToString();
            int v = pwm.Value;
            byte[] b = BitConverter.GetBytes(v);

            try {
               serialPort1.Open();
               serialPort1.Write(b,0,4);
               serialPort1.Close();
            }
            catch {
                MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void led_Click(object sender, EventArgs e)
        {
            char[] b=new char[4];
            if (state == true) { b[1] = 't'; }
            else {b[1]='f';}
            try
            {
                serialPort1.Open();
                serialPort1.Write(b,0,2);
                serialPort1.Close();
            }
            catch
            {
                 MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
            }
            state = !state;
        }

       
    }
}
