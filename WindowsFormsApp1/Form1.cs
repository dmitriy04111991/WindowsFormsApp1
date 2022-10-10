using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
        
        void translate(string fromto, Label l)
        {
            ListBox from, to;
            if (fromto == "рус_eng")
            {
                from = f2.listBox1;
                to = f2.listBox2;
            }
            else
            {
                from = f2.listBox2;
                to = f2.listBox1;
            }
            for (int i=0;i<from.Items.Count;i++)
            {
                if (l.Text == from.Items[i].ToString())
                    l.Text = to.Items[i].ToString();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            translate("eng_рус", label1);
            translate("eng_рус", label2);
            translate("eng_рус", label3);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            translate("рус_eng", label1);
            translate("рус_eng", label2);
            translate("рус_eng", label3);
        }
    }
}
