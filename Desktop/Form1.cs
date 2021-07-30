using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form1 : Form
    {
        List<string> lines = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"" + textBox1.Text;
            lines = File.ReadAllLines(filePath).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int value = random.Next(0, lines.Count);
            label3.Text = lines[value];
        }
    }
}
