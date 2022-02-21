using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllhlepidrashAnthrwpouYpologisth
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        bool isClicked = false;

        private void button3_Click(object sender, EventArgs e)
        {
            if (isClicked == false)
            {
                button3.BackgroundImage = Properties.Resources.light_bulb_off;
                this.BackgroundImage = Properties.Resources.homelightsoff;
                isClicked = true;
            }
            else
            {
                button3.BackgroundImage = Properties.Resources.light_bulb_on;
                this.BackgroundImage = Properties.Resources.home;
                isClicked = false;
            }
        }

        int thermostatInitialValue = 20;

        private void button1_Click(object sender, EventArgs e)
        {
            thermostatInitialValue++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thermostatInitialValue--;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int thermostatValue;
        private void timer1_Tick(object sender, EventArgs e)
        {
            thermostatValue = thermostatInitialValue;
            label1.Text = thermostatValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }
    }
}