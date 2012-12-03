using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HistogramGenerator
{
    public partial class ImageTester : Form
    {
        public string data;
        public ImageTester()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {
            go();
        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            go();
        }

        private void go()
        {

            ImageTesterSub testSub = new ImageTesterSub();


            data = "";
            Random random = new Random();
            for (int a = 0; a < 50; a++)
            {
                int z = random.Next(1, 100);
                data = data + z.ToString() + " ";
            }

            DataReader d = new DataReader(data);
            HistogramOptions ho = new HistogramOptions();
            DisplayOptions opt = new DisplayOptions();
            Histogram h = new Histogram(d,ho);

            pic.BackgroundImage = Image.draw(h, pic.Width, pic.Height,opt);


            string alpha = "";
            for (int i = 0; i < d.inputData.Count; i++)
            {
                alpha = alpha + d.inputData[i].ToString()+"\r\n";
            }

            testSub.value(alpha);

            testSub.Visible = true;
        }
    }
}
