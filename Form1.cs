using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* StreamReader streamReader = new StreamReader(@"C:\Users\Арсений\source\repos\WinFormsApp3\WinFormsApp3\Файлы\text.txt");
             string str = "";

             while (!streamReader.EndOfStream)
             {
                 str += streamReader.ReadLine();
             }

             Input1.Text = str;*/

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                Input1.Clear();
                Input1.Text = File.ReadAllText(name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;

            a = Input1.Text;

            OutBox.Text =  a.Replace("  ", " |").Replace("| ", "").Replace("|", "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input1.Clear();
            OutBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, OutBox.Text);
            }
           
        }

    }
}

