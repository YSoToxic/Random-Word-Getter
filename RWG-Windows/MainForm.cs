using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Desktop
{
    public partial class MainForm : Form
    {
        List<string> lines = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        /* Window Movement*/
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - startPoint.X, point.Y - startPoint.Y);
            }
        }

        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        /* End Of Window Movement*/

        private void btnGetWord_Click(object sender, EventArgs e)
        {
            if (tbFilePath.TextLength > 0 && !tbFilePath.Text.StartsWith(" "))
            {
                Random random = new Random();
                int value = random.Next(0, lines.Count);
                lblWordOutput.Text = lines[value];
            }
            else
            {
                if (tbFilePath.Text.StartsWith(" "))
                {
                    MessageBox.Show("The file path can not start with a space!");
                }
                else if (tbFilePath.TextLength <= 0)
                {
                    MessageBox.Show("Please import a text file before getting a random word!");
                }
                else
                {
                    MessageBox.Show("An unknown error occurred please import the text file again and retry!");
                }
            }
        }

        private void btnImportWords_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = @"" + openFileDialog.FileName;
                tbFilePath.Text = filePath;
                lines = File.ReadAllLines(filePath).ToList();
                lblCurrentFileName.Text = Path.GetFileName(filePath);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
