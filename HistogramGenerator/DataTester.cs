using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HistogramGenerator
{
    public partial class DataTester : Form
    {
        
        public DataTester()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
             OpenFileDialog oFD = new OpenFileDialog();

            textwindow.Text = " ";
            //Read txt File
            oFD.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            oFD.FilterIndex = 1;
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(oFD.FileName);
                string temp;
                temp = reader.ReadLine();
                textwindow.Text = temp;
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
           DataReader d = new DataReader(textwindow.Text);
            if (d.is_valid == false)
            {
                result.Text = "Data is not Valid.";
                reason.Text = d.message;
            }

            if (d.is_valid == true)
            {
                result.Text = "Data is Valid.";

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textwindow.Text = "";
        }
    }
}
