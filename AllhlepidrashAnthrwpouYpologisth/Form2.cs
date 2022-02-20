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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void πανεπιστήμιοToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.AppendText("-" + πανεπιστήμιοToolStripMenuItem.Text + " στις " + e.ClickedItem.Text + "." + Environment.NewLine);
        }

        private void δουλειάToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.AppendText("-" + δουλειάToolStripMenuItem.Text + " στις " + e.ClickedItem.Text + "." + Environment.NewLine);
        }

        private void φαγητόToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.AppendText("-" + φαγητόToolStripMenuItem.Text + " στις " + e.ClickedItem.Text + "." + Environment.NewLine);
        }

        private void προπόνησηToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.AppendText("-" + προπόνησηToolStripMenuItem.Text + " στις " + e.ClickedItem.Text + "." + Environment.NewLine);
        }

        private void καφετέριαToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.AppendText("-" + καφετέριαToolStripMenuItem.Text + " στις " + e.ClickedItem.Text + "." + Environment.NewLine);
        }

        private void τάισμαΣκύλουToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.AppendText("-" + τάισμαΣκύλουToolStripMenuItem.Text + " στις " + e.ClickedItem.Text + "." + Environment.NewLine);
        }

        private void βόλταΣκύλουToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.AppendText("-" + βόλταΣκύλουToolStripMenuItem.Text + " στις " + e.ClickedItem.Text + "." + Environment.NewLine);
        }

        private void βραδινήΈξοδοςToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBox1.AppendText("-" + βραδινήΈξοδοςToolStripMenuItem.Text + " στις " + e.ClickedItem.Text + "." + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int found = richTextBox1.Find("Πανεπιστήμιο");
            MessageBox.Show(found.ToString());
        }
    }
}