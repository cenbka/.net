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

namespace Task3
{
    public partial class Form1 : Form
    {
        private string name;
        private string a = "вfbfssgааа1234";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                Input1.Clear();
                Input1.Text = File.ReadAllText(name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;

            a = Input1.Text;

            OutBox.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input1.Clear();
            OutBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\Арсений\source\repos\Task3\Task3\Файлы\text.txt";
             File.Create(path).Close();            
             File.WriteAllText(path,a);
             name = openFileDialog1.FileName;
             Input1.Clear();
             Input1.Text = a;

            MyFile file = new MyFile("text.txt", a);
            //file.name = "bgntnb";


            MyDirectory myDirectory = new MyDirectory(path, "Файлы", new List<MyFile>());

            myDirectory.listD.Add(file);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, OutBox.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\Арсений\source\repos\Task3\Task3\Файлы\text.txt";
            File.Delete(path);

            MyFile file = new MyFile("text.txt", a);
            MyDirectory myDirectory = new MyDirectory(path, "Файлы", new List<MyFile>());
            myDirectory.listD.Remove(file);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\Арсений\source\repos\Task3\Task3\Файлы\text2.txt";
            File.Create(path).Close();
            String path1 = @"C:\Users\Арсений\source\repos\Task3\Task3\Файлы\text.txt";
            File.Copy(path1, path,true);
            File.Delete(path1);

            MyFile file = new MyFile("text.txt",a);
            file.name = "text2.txt";
        }
    }
}
