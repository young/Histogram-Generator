using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace HistogramGenerator
{
    
    /// <summary>
    /// GUI
    /// </summary>
    public partial class Gui : Form
    {
        DataReader d;
        Histogram h;
        HistogramOptions ho = new HistogramOptions();
        DisplayOptions opt=new DisplayOptions();
        public static bool histogamOptions_isChanged = false;
        public static bool displayOptions_isChanged = false;
        public string report;
        public static Form f;
        public static int theme;

        /// <summary>
        /// Pulic GUI
        /// </summary>
        /// 
        public Gui()
        {
            InitializeComponent();
            theme = 2;

            // = "1 2 3 4 5 6 7 8 9 10";
         }


#region The Buttons

        /// <summary>
        /// Calls the Input_Data Method when button is pressed, and creates the Histogram.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_Data_Button_Click(object sender, EventArgs e)
        {
            if (txtInput_Window.Text != "")
            {
                ho = new HistogramOptions();
                opt = new DisplayOptions();

                if (Input_Data())
                {
                    Historgram(d);
                    DrawHistoGram(h);
                }
            }
            else if (txtInput_Window.Text == "")
            {
                
                MessageBox.Show("You must add some data first", "Ok");
            }

        }


        /// <summary>
        /// Runs the Data_Loader Method when button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Data_Click(object sender, EventArgs e)
        {
            Data_Loader();
        }
        /// <summary>
        /// This button calls the Histogram constructor, and the drawing method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Histogram_Click(object sender, EventArgs e)
        {
            if (txtInput_Window.Text != "")
            {
                if (Label_Start_textBox.Text != "")
                {
                    opt.label_startB = true;
                    opt.label_start = Convert.ToDouble(Label_Start_textBox.Text);
                }
                if (Label_Stop_textBox.Text != "")
                {
                    opt.label_stopB = true;
                    opt.label_stop = Convert.ToDouble(Label_Stop_textBox.Text);
                }


                if (Tick_Interval_TextBox.Text != "")
                {

                    opt.tick_interval = Convert.ToDouble(Tick_Interval_TextBox.Text);
                    opt.number_of_ticksB = true;
                    opt.number_of_ticks = Convert.ToInt32(Convert.ToDouble(getMax(h.frequency)) / opt.tick_interval);
                }


                if (ho.LCLB == true)
                {
                    int cheese = Convert.ToInt32(LcL_textBox.Text);
                    ho.LCL = (float)cheese;
                }
                if (ho.UCLB == true)
                {
                    int cheese = Convert.ToInt32(UcL_textBox.Text);
                    ho.UCL = (float)cheese;
                }
                if (Input_Data())
                {
                    Historgram(d);
                    DrawHistoGram(h);
                }
               opt.tick_intervalB = false;
            }
            else if (txtInput_Window.Text == "")
            {

                MessageBox.Show("You must add some data first", "Ok");
            }


        }

#endregion

#region Methods

        /// <summary>
        /// This methods creates the data object and uses the 
        /// data class to verify the data. It also tells the user
        /// if the Data is Valid or not.
        /// </summary>
        private Boolean Input_Data()
        {
            d = new DataReader(txtInput_Window.Text);
            if (d.is_valid == false)
            {
                MessageBox.Show("Invalid data. " +d.message);
                return false;
            }

            if (d.is_valid == true)
            {
                txtInput_Window.Text = "";
                foreach(float a in d.inputData)
                {
                    txtInput_Window.Text = txtInput_Window.Text + a.ToString() +" ";
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// When the load data button is pressed a text file can be loaded into
        /// the input text box, allowing the user to make any needed changes. 
        /// </summary>
        private void Data_Loader()
        {

            OpenFileDialog oFD = new OpenFileDialog();

            txtInput_Window.Text = " ";
            //Read txt File
            oFD.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            oFD.FilterIndex = 1;
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(oFD.FileName);
                string temp;
                temp = reader.ReadLine();
                txtInput_Window.Text = temp;

            }
        }


        /// <summary>
        /// This method Creates a histogram with a data object as a parameter
        /// It then displays some information so the user can check to make sure
        /// everything is kosher. Whether or not user parameters have been set 
        /// determines which method from the Histogram class
        /// it calls.
        /// </summary>
        /// <param name="d"></param>
        private void Historgram(DataReader d)
        {


            h = new Histogram(d, ho);


            report = "Historgram Report";
            report = report + "\r\nFrequencyValues";
            foreach (int a in h.frequency)
            {
                report = report + a.ToString() + " ";
            }
            report = report + "\r\nXAxis";
            foreach (float a in h.X_Axis)
            {
                report = report + a.ToString() + " ";
            }
            report = report + "\r\n Width " + (h.width).ToString();

            report = report + "\r\n Max " + (h.max).ToString();
            report = report + "\r\n Min " + (h.min).ToString();
            report = report + "\r\n Number of Bars " + (h.numBars).ToString();
            report = report + "\r\n Number of decimals " + (h.decimalPlaces).ToString();
        }

        /// <summary>
        /// This method takes a histogram and sets the image box to 
        /// the histogram image, drawn using the image class. Whether or not user
        /// parameters have been set determines which method from the image class
        /// it calls. 
        /// </summary>
        /// <param name="a"></param>
        private void DrawHistoGram(Histogram a)
        {

            
                HistoGram_pictureBox.BackgroundImage = Image.draw(a, HistoGram_pictureBox.Width, HistoGram_pictureBox.Height, opt);
            


           
        }

 

        /// <summary>
        /// The Save method
        /// </summary>
        /// <param name="text"></param>
        public static void SaveText(TextBox text)
        {
            


        }

        private static float getMax(ArrayList a)
        {
            float max = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int f = Convert.ToInt32(a[i]);
                if (max < f)
                {
                    max = f;
                }
            }
            return (float)max;
        }

# endregion

#region Parameter Modifiers

        /// <summary>
        /// This method sets the number of bins based on a slider value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// This method Sets the interval based on text imput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tick_Interval_TextBox_TextChanged(object sender, EventArgs e)
        {
            displayOptions_isChanged = true;
            opt.tick_intervalB = true;
            opt.tick_interval = (float)(Convert.ToDouble(Tick_Interval_TextBox.Text));
        }
        /// <summary>
        /// This method sets the label increment to the tick interval.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Increment_textBox_TextChanged(object sender, EventArgs e)
        {
            Tick_Interval_TextBox_TextChanged(sender, e);
        }

        /// <summary>
        /// This methodsets the Start of the labels to inputed text value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Start_textBox_TextChanged(object sender, EventArgs e)
        {
            displayOptions_isChanged = true;
            opt.label_startB = true;
            opt.label_start = (float)(Convert.ToDouble(Label_Start_textBox.Text));
        }
        /// <summary>
        /// This method sets the label stop value to a text input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Stop_textBox_TextChanged(object sender, EventArgs e)
        {
            displayOptions_isChanged = true;
            opt.label_stopB = true;
            opt.label_stop = (float)(Convert.ToDouble(Label_Stop_textBox.Text));
        }


        /// <summary>
        /// This method sets the lower class limt of the firt bar based on Text input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LcL_textBox_TextChanged(object sender, EventArgs e)
        {
            histogamOptions_isChanged = true;
            ho.LCLB = true;
            ho.LCL = (float)(Convert.ToDouble(LcL_textBox.Text));
        }
        /// <summary>
        /// This method sets the upper class limt of the firt bar based on Text input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcL_textBox_TextChanged(object sender, EventArgs e)
        {
            histogamOptions_isChanged = true;
            ho.UCLB = true;
            ho.UCL = (float)(Convert.ToDouble(UcL_textBox.Text));

        }

        #endregion

# region stuff

        private void Number_of_Ticks_Scroll(object sender, ScrollEventArgs e)
        {
            displayOptions_isChanged = true;
            opt.number_of_ticksB = true;
          //  opt.vert_Label_DecimalsB = false;
            opt.number_of_ticks = Number_of_Ticks.Value;
            ticklabe.Text = Number_of_Ticks.Value.ToString();

            if (d != null)
            {
                h = new Histogram(d, ho);
                DrawHistoGram(h);
            }
            else if (d == null)
            {

                MessageBox.Show("You must Press Input Data first", "Ok", MessageBoxButtons.OKCancel);
            }
            
        }

        private void Gui_Load(object sender, EventArgs e)
        {

        }

        private void Number_of_Bins_Scroll(object sender, ScrollEventArgs e)
        {

            histogamOptions_isChanged = true;
            ho.num_binsB = true;
            ho.num_bins = Number_of_Bins.Value;
            barlabel.Text = ho.num_bins.ToString();

            if (d != null)
            {
                h = new Histogram(d, ho);
                DrawHistoGram(h);
            }
            else if(d==null)
            {
                
                MessageBox.Show("You must Press Input Data first", "Ok", MessageBoxButtons.OKCancel);   
            }

        }



        private void LcL_textBox_TextChanged_1(object sender, EventArgs e)
        {
            if (LcL_textBox.Text != "")
            {
                ho.LCLB = true;

            }
            if (LcL_textBox.Text == "")
                ho.LCLB = false;
        }

        private void UcL_textBox_TextChanged_1(object sender, EventArgs e)
        {
            if (UcL_textBox.Text != "")
            {
                ho.UCLB = true;

            }
            if (UcL_textBox.Text == "")
                ho.UCLB = false;
        }

        private void H_NoDecimals_Click(object sender, EventArgs e)
        {
            opt.hor_Label_DecimalsB = true;
            opt.hor_Label_Decimals = 0;
            DrawHistoGram(h);
        }

        private void H_1Decimal_Click(object sender, EventArgs e)
        {
            opt.hor_Label_DecimalsB = true;
            opt.hor_Label_Decimals = 1;
            DrawHistoGram(h);
        }

        private void H_2Decimals_Click(object sender, EventArgs e)
        {
            opt.hor_Label_DecimalsB = true;
            opt.hor_Label_Decimals = 2;
            DrawHistoGram(h);
        }

        private void H_3Decimals_Click(object sender, EventArgs e)
        {
            opt.hor_Label_DecimalsB = true;
            opt.hor_Label_Decimals = 3;
            DrawHistoGram(h);
        }

        private void V_0Decimals_Click(object sender, EventArgs e)
        {
            opt.vert_Label_DecimalsB = true;
            opt.vert_Label_Decimals = 0;
            DrawHistoGram(h);
        }

        private void V_1Decimals_Click(object sender, EventArgs e)
        {
            opt.vert_Label_DecimalsB = true;
            opt.vert_Label_Decimals = 1;
            DrawHistoGram(h);
        }

        private void V_2Decimals_Click(object sender, EventArgs e)
        {
            opt.vert_Label_DecimalsB = true;
            opt.vert_Label_Decimals = 2;
            DrawHistoGram(h);
        }

        private void V_3Decimals_Click(object sender, EventArgs e)
        {
            opt.vert_Label_DecimalsB = true;
            opt.vert_Label_Decimals = 3;
            DrawHistoGram(h);
        }

        private void Tick_Interval_TextBox_TextChanged_1(object sender, EventArgs e)
        {
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        # endregion

# region FullScreen
       
        private void ViewFullscreen_Click(object sender, EventArgs e)
        {

            f = new Form();
            f.FormBorderStyle = FormBorderStyle.None;
            f.StartPosition = FormStartPosition.Manual;
            f.BackColor = System.Drawing.Color.Black;
            f.WindowState = FormWindowState.Maximized;
            f.Top = 0;
            f.Left = 0;
            f.Width = Screen.PrimaryScreen.WorkingArea.Width;
            f.Height = Screen.PrimaryScreen.WorkingArea.Height;

            PictureBox pb = new PictureBox();
            f.Controls.Add(pb);
            pb.Location = new System.Drawing.Point(0, 0);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb.Width = Screen.PrimaryScreen.WorkingArea.Width;
            pb.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pb.Image = HistoGram_pictureBox.BackgroundImage;
            pb.Click += new EventHandler(pb_Click);
           f.KeyDown +=new KeyEventHandler(f_KeyDown);

           
            f.Show();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            f.Hide();
        }
        private void f_KeyDown(object sender, EventArgs e)
        {   
            f.Hide();
        }

        #endregion

#region Toolstrip
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

            txtInput_Window.Text = " ";
            //Read txt File
            oFD.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            oFD.FilterIndex = 1;
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(oFD.FileName);
                string temp;
                temp = reader.ReadLine();
                txtInput_Window.Text = temp;

            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Image file = HistoGram_pictureBox.BackgroundImage;
            SaveFileDialog s = new SaveFileDialog();

            // Default file name is Histogram
            s.FileName = "Histogram";

            // Show save file dialog box
            // Process save file dialog box results
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string filename = s.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                file.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);

                fstream.Close();
            }
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string defaultFileName = "Data.txt";

            SaveFileDialog sFD = new SaveFileDialog();

            SaveFileDialog s = new SaveFileDialog();

            if (s.ShowDialog() == DialogResult.OK)
            {
                defaultFileName = s.FileName;

                try
                {
                    File.WriteAllText(defaultFileName, txtInput_Window.Text);
                }
                catch
                {
                    MessageBox.Show("File write error");
                }

            }
            else
            {
                MessageBox.Show("Save operation cancelled");
            }
        }

        private void DataTest_Click(object sender, EventArgs e)
        {
            DataTester Dtest = new DataTester();
            Dtest.Visible = true;
        }

        private void imageTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageTester iTest = new ImageTester();
            iTest.Visible = true;
        }

        private void clearTextFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtInput_Window.Text = "";
            HistoGram_pictureBox.BackgroundImage = Properties.Resources.common_wombat_head;
        }

        private void randomDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtInput_Window.Text = "";
            Random random = new Random();
            for (int a = 0; a < 50; a++)
            {
                int z = random.Next(1, 100);
                txtInput_Window.Text = txtInput_Window.Text + z.ToString() + ",";
            }
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(report);
        }

        private void gibsonBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme = 0;
            if (h != null)
                DrawHistoGram(h);

        }

        private void helloKittyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme = 1;
            if(h!=null)
                DrawHistoGram(h);
        }

        private void vSUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme = 2;
            if(h!=null)
                DrawHistoGram(h);
        }

        // set visibilty of advanced options
        private void advancedOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((panelOptions1.Visible == true) && (panelOptions2.Visible == true))
            {
                panelOptions1.Visible = false;
                panelOptions2.Visible = false;
            }
            else if ((panelOptions1.Visible == false) && (panelOptions2.Visible == false))
            {
                panelOptions1.Visible = true;
                panelOptions2.Visible = true;
            }

        }
        #endregion
















    }
}
