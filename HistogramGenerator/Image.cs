using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace HistogramGenerator
{
    /// <summary>
    /// This class contains the methods that draw the image based on a given histogram.
    /// </summary>
    class Image
    {
        /// <summary>
        /// Create the brushes at start up. 
        /// </summary>
        public static Brush blackBrush;
        public static Brush tanBrush;
        public static Brush whiteBrush;
        public static Brush blueBrush;

        public static int pushover = 0;
        public static int pushoverY = 0;

        /// <summary>
        /// This is the basic constructor that makes a image at defualt settings.
        /// It calls several Private methods for the actual drawing.
        /// </summary>
        /// <param name="h"></param>
        /// <param name="w"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public static Bitmap draw(Histogram h, int w, int l, DisplayOptions opt)
        {
            
            //Create a bitmap and make it editable
            Bitmap bitmap = new Bitmap(w,l);
            Graphics g = Graphics.FromImage(bitmap);

            setTheme(Gui.theme);

            double ticknum;
            pushover = 0;
            pushoverY = 0;
        
            //set  the margin for the left side
            checkDecimals(h, opt);
            //set the bottom margin. 
            if (opt.hor_Label_Decimals > 1 && h.numBars > 14)
                pushoverY=8;



            //draw the background
            drawBackgrounds(g, w, l,opt);

            //Draw the Horizontal Axis
            drawXAxis(g, l, w, h, opt);

            //Draw the bars
            drawBars(g, l, w, h, opt);
            //Draw the Vertical Axis

            //drawYAxis( g,l,Convert.ToInt32(getMax(h.frequency)),h);

            if (opt.number_of_ticksB == true)
            {
                 drawYAxis(g, l, opt.number_of_ticks, h, opt);
            }
           
            if (opt.number_of_ticksB == false)
            {
           
                 drawYAxis(g, l, 6, h, opt);
            }
              


            //Return the image
            return bitmap;
        }

        /// <summary>
        /// The method that draws the background images.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="w"></param>
        /// <param name="l"></param>
        private static void drawBackgrounds(Graphics g, int w, int l,DisplayOptions opt)
        {
            
            g.FillRectangle(blackBrush, 0, 0, w, l);
            g.FillRectangle(tanBrush, 2, 2, w-4, l-4);

            //the ones that change
            g.FillRectangle(blackBrush, 27 + pushover, 12, w - 30 - 10 - pushover, l - 30 - 10-pushoverY);
            g.FillRectangle(whiteBrush, 29 + pushover, 14, w - 34 - 10 - pushover, l - 34 - 10-pushoverY);

        }
        /// <summary>
        /// This method draws the Y axis, with a given number of ticks
        /// </summary>
        /// <param name="g"></param>
        /// <param name="l"></param>
        /// <param name="ticknum"></param>
        private static void drawYAxis(Graphics g,int l,int ticknum, Histogram h, DisplayOptions opt)
        {
            
            int u = l - 34-10;

            int spacing = u / ticknum;

            int margin = 0;

            for (int i = 0; i < ticknum; i++)
            {
                g.FillRectangle(blackBrush, 12+12+margin+pushover,(22+(i*spacing)) , 4,2 );

            }
            drawYAxisLabels(g, l, ticknum, h, opt);
        }
        /// <summary>
        /// This method draws X axis, based on nmumber of bars
        /// </summary>
        /// <param name="g"></param>
        /// <param name="l"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        private static void drawXAxis(Graphics g,int l, int w, Histogram h, DisplayOptions opt)
        {
            int xl = w - 42-10-5 - pushover;
            int spacing = xl / (h.X_Axis.Count-1);
            string label = "";
            string dec = "";
            int margin=0;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            for (int i = 0; i < h.X_Axis.Count; i++)
            {
                label = Convert.ToString(h.X_Axis[i]);
                string[] words = label.Split('.');
                if (opt.hor_Label_DecimalsB == true)
                {
                    
                    if (opt.hor_Label_Decimals == 0)
                        label = words[0];
                    else
                    {
                        if (words.Length == 2)
                        {
                            dec = "";
          
                            for (int j = 0; j < opt.hor_Label_Decimals; j++)
                            {
                                if(j<words[1].Length)
                                    dec = dec + words[1][j].ToString();
                            }
                            label = words[0] + "." + dec;
                            dec = "";
                        }
                    }
                }
                if (opt.hor_Label_DecimalsB == false)
                {
                    dec = "";
                    if (words.Length == 2)
                    {
                        for (int j = 0; j < h.decimalPlaces; j++)
                        {
                            dec = ".";
                            if (j < words[1].Length)
                                dec = dec + words[1][j].ToString();
                        }
                        label = words[0] + dec;
                        dec = "";
                    }
                }

                //Draw the ticks
                g.FillRectangle(blackBrush, 22+10 + 5 + pushover + (i * spacing), l - 20-10-pushoverY, 2, 6);
                //Draw the label
                int hgt = 0;
                if (opt.hor_Label_Decimals > 1 && i % 2 == 0 && h.numBars>14)
                    hgt = 8;
                margin = label.Length*3;
                g.DrawString(label, new Font("Arial", 7), Brushes.Black, new Point(22 +10-margin+5 +pushover+ (i * spacing), l - 15-10+hgt-pushoverY));
                label = "";


            }
        }
        /// <summary>
        /// This method contains the loop that draws the bars and their outlines.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="l"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        private static void drawBars(Graphics g, int l, int w, Histogram h, DisplayOptions opt)
        {
            int xl = w - 42-10-5-pushover;
            int spacing = xl / (h.X_Axis.Count-1);


            //Create new bar hieghts based on Label Start and stop
            
            if (opt.label_startB == true)
            {
                for (int i = 0; i < h.frequency.Count; i++)
                {
                    if (Convert.ToDouble(h.frequency[i]) <= opt.label_start)
                        h.frequency[i] = 0;
                }
            }
            if (opt.label_stopB == true)
            {
                for (int i = 0; i < h.frequency.Count; i++)
                {
                    if (Convert.ToDouble(h.frequency[i]) >= opt.label_stop)
                        h.frequency[i] = opt.label_stop;
                }
            }

            


            //Set the ceiling and floor for drawing the historgram
            float floor = l - 21 - 10;
            float max_freq = getMax(h.frequency);
            float max_ceiling = 22;
            //A loop to draw the bars
            for (int i = 0; i < h.numBars ; i++)
            {
                int hght = Convert.ToInt32(h.frequency[i]); //Get the hieght of the bar.

                float freq_percent = 1 - (float)hght / max_freq;//Cacluate the percent the frequency repesents.
                float pixel_percent = (floor - max_ceiling) * freq_percent; //Calcualte how many pixels that is.
                float ceiling = max_ceiling + pixel_percent;//Find the hieght to drawthetop of the bar at.
               
     
                //Draw the black rectangle for the outline.
                g.FillRectangle(blackBrush, 22+10+5+pushover + (i * spacing), Convert.ToInt32(ceiling), spacing, Convert.ToInt32(floor) - Convert.ToInt32(ceiling) + 1-pushoverY);
                //Draw a smaller blue rectangle
                g.FillRectangle(blueBrush, (24+10+5+pushover + (i * spacing)), Convert.ToInt32(ceiling) + 2, spacing - 5, (Convert.ToInt32(floor) - Convert.ToInt32(ceiling) + 1) - 4-pushoverY);
            }
            
          
        }

        private static void drawYAxisLabels(Graphics g, int l, int ticknum, Histogram h, DisplayOptions opt)
        {

            double labelMin = 0;

            if (opt.label_startB == true)
            {
                labelMin = Convert.ToDouble(opt.label_start);
            }
            int u = l - 34-10;
            int spacing = u / ticknum;
            int margin = 0;
            float yLabel = getMax(h.frequency);
            float yIncrementer=(yLabel-(float)labelMin)/ticknum;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            //draw the labels, starting from higest to lowest
            for (int i = 0; i < ticknum; i++)
            {
                double y=0;
                string label="";
                string[] words;
                string dec;
                if(opt.vert_Label_DecimalsB==false)
                {
                    y = Math.Round(yLabel);
                    label = y.ToString();
                }
                if (opt.vert_Label_DecimalsB == true)
                {
                    label = yLabel.ToString();
                    words = label.Split('.');

                    if (opt.vert_Label_Decimals == 0)
                        label = words[0];
                    else
                    {
                        if (words.Length == 2)
                        {
                            dec = "";

                            for (int j = 0; j < opt.vert_Label_Decimals; j++)
                            {
                                if (j < words[1].Length)
                                {
                                    dec = dec + words[1][j].ToString();
                                    margin += 4;
                                }
                            }
                            label = words[0] + "." + dec;
                            dec = "";
                        }
                    }
                }



                g.DrawString(label, new Font("Arial", 7), Brushes.Black, new Point(0+10-margin+pushover, 17 + (i * spacing)));
                yLabel-=yIncrementer;
                margin = 0;
            }

            //Draw Zero
            g.DrawString(Convert.ToString(labelMin), new Font("Arial", 7), Brushes.Black, new Point(0+10-margin+pushover, 8 + (u)-pushoverY));
        }

        private static void checkDecimals(Histogram h, DisplayOptions opt)
        {
            float tickNumber = 6;
            float labelMin = 0;
            int x = 0;
            string[] words;
            float yCurrent = (float)getMax(h.frequency);

            if (opt.label_startB == true)
            {
                labelMin = (float)opt.label_start;
            }
            if (opt.label_stopB == true)
            {
                labelMin = (float)opt.label_stop;
            }
            if (opt.number_of_ticksB == true)
            {
                tickNumber = (float)opt.number_of_ticks;
            }

            float yIncrementer = (yCurrent - (float)labelMin) / tickNumber;

            for (int i = 0; i < tickNumber; i++)
            {

                
                words = yCurrent.ToString().Split('.');

                if (words.Length == 2)
                {
                    if (words[1].Length > x)
                        x = words[1].Length;
                }

                yCurrent -= yIncrementer;
            }
            if (x < opt.vert_Label_Decimals)
            {
                pushover = x * 5;
            }
            else
                pushover = opt.vert_Label_Decimals * 5;
            
                
            





        }

        private static float getMax(ArrayList a)
        {
            float max = 0;
            for(int i = 0;i<a.Count;i++)
            {
                int f = Convert.ToInt32(a[i]); 
                if (max < f)
                {
                    max = f;
                }
            }
            return (float)max;
        }

        private static void setTheme(int theme)
        {
            if (theme == 0)
            {
                blackBrush = new SolidBrush(Color.Black);
                tanBrush = new SolidBrush(Color.Tan);
                whiteBrush = new SolidBrush(Color.White);
                blueBrush = new SolidBrush(Color.CornflowerBlue);
            }
            if (theme == 1)
            {
                blackBrush = new SolidBrush(Color.Black);
                tanBrush = new SolidBrush(Color.Pink);
                whiteBrush = new SolidBrush(Color.White);
                blueBrush = new SolidBrush(Color.Red);
            }
            if (theme == 2)
            {
                blackBrush = new SolidBrush(Color.Black);
                tanBrush = new SolidBrush(Color.White);
                whiteBrush = new SolidBrush(Color.Gray);
                blueBrush = new SolidBrush(Color.Red);
            }
        }
    }
}
