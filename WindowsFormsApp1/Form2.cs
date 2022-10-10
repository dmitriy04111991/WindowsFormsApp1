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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string line;
            try
            {
                var file1 = new System.IO.StreamReader("di1.dat");
                while ((line = file1.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                file1.Close();
                var file2 = new System.IO.StreamReader("di2.dat");
                while ((line = file2.ReadLine()) != null)
                {
                    listBox2.Items.Add(line);
                }
                file2.Close();
            }
            catch(Exception e)
            {
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                listBox2.Items.Add(textBox2.Text);
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
                System.IO.StreamWriter SaveFile1 = new System.IO.StreamWriter("di1.dat");
                foreach (var item in listBox1.Items)
                {
                    SaveFile1.WriteLine(item.ToString());
                }
                SaveFile1.Close();
                System.IO.StreamWriter SaveFile2 = new System.IO.StreamWriter("di2.dat");
                foreach (var item in listBox2.Items)
                {
                    SaveFile2.WriteLine(item.ToString());
                }
                SaveFile2.Close();

            }
        }
    }
}
