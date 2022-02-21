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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Ανιχνεύτηκε σοβαρή ζημιά. Παρακαλώ δείτε τις κάμερες παρακολούθησης");
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private int clickCounter1 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (clickCounter1 == 0)
            {
                MessageBox.Show("Το μπολ του φαγητού γέμισε");
                clickCounter1++;
            }
            else
            {
                MessageBox.Show("Το μπολ του φαγητού είναι ήδη γεμάτο");
            }
        }

        private int clickCounter2 = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (clickCounter2 == 0)
            {
                MessageBox.Show("Το μπολ του νερού γέμισε");
                clickCounter2++;
            }
            else
            {
                MessageBox.Show("Το μπολ του νερού είναι ήδη γεμάτο");
            }
        }
    }
}