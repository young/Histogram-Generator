using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;


namespace HistogramGenerator
{
    /// <summary>
    /// This class handes the construction of a Hostogram based on a given set of 
    /// numbers. It stores this histogram as a set of numbers that can be used to 
    /// create an image.
    /// </summary>
    class Histogram
    {
        public ArrayList frequency;
        public int numBars;
        public int decimalPlaces;
        public ArrayList X_Axis;
        //public ArrayList Y_Axis;
        public float width;
        public float max;
        public float min;
        public int total;
        
    

        /// <summary>
        /// The Historgram Constructor
        /// </summary>
        /// <param name="d"></param>
        /// <param name="o"></param>
        public Histogram(DataReader d, HistogramOptions o)
        {
            ArrayList qwert = new ArrayList();
                  qwert = d.inputData;
           
         
            if (o.LCLB == true)
            {
               qwert = setLCL(d.inputData, o.LCL);
            }
            if (o.UCLB == true)
            {
                qwert = setUCL(qwert, o.UCL);
            }


            max = getMax(qwert);
            min = getMin(qwert);
            total = qwert.Count;

            if (o.num_binsB == true)
                numBars = o.num_bins;
            else
                numBars = getNumBars(qwert);
            decimalPlaces = getDecimals(qwert);
            width = getClassWidth(min, max, (float)numBars);
            X_Axis = setBins(qwert, numBars, width);
            frequency = getFreq(qwert, numBars, width, X_Axis);


      
            
         
            


        }


        //The Private Methods that do all the work




        private ArrayList setLCL(ArrayList input, float LCL)
        {
            ArrayList answer = new ArrayList();
            for (int i = 0; i < input.Count; i++)
            {
                if ((float)input[i] > LCL)
                    answer.Add(input[i]);
            }

            return answer;
        }

        private ArrayList setUCL(ArrayList input, float UCL)
        {
            ArrayList answer = new ArrayList();
            for (int i = 0; i < input.Count; i++)
            {
                if ((float)input[i] < UCL)
                    answer.Add(input[i]);
            }

            return answer;
        }


        /// <summary>
        /// Takes the arrray list an returns the size squared as the 
        /// number of bars
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int getNumBars(ArrayList a)
        {
            return Convert.ToInt32(Math.Sqrt(a.Count));
        }

        /// <summary>
        /// This finds the number of decimal places in the given data. 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int getDecimals(ArrayList a)
        {
            
            int dec = 0;
            string input;
            string[] words;    

           for (int i = 0; i < a.Count; i++)
            {
               input = a[i].ToString();
               words = input.Split('.');

               if (words.Length > 1)
               {
                   if (words[1].Length > dec)
                   {
                       dec = words[1].Length;
                   }
               }

            }

            return dec;
       

        }

        /// <summary>
        /// Finds the maximum value
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private float getMax(ArrayList a)
        {
            float max = 0; 
            foreach (float f in a)
            {
                if (max < f)
                { 
                    max = f; 
                }
            }
            return max;
        }
        /// <summary>
        /// Finds the min value
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private float getMin(ArrayList a)
        {
            float min = (float)a[0];
            foreach (float f in a)
            {
                if (min > f)
                {
                    min = f;
                }
            }
            return min;

        
        }

        /// <summary>
        /// Determines the class width
        /// </summary>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private float getClassWidth(float b,float c,float d)
        {
            float max = c;
            float min = b;

            return (max - min)/(d);
        }
        /// <summary>
        /// Sets the bins based on the width
        /// </summary>
        /// <param name="a"></param>
        /// <param name="bars"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        private ArrayList setBins(ArrayList a,int bars,float w)
        {
            ArrayList bins = new ArrayList();
            bins.Add(getMin(a));
            float start = getMin(a);

            for (float i = 1; i < bars; i++)
            {
                start = start + w; 
                bins.Add(start);
            }
            bins.Add(getMax(a));


            return bins;
        }
        /// <summary>
        /// Gets the frequency of numbers in each bin.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="bars"></param>
        /// <param name="w"></param>
        /// <param name="bins"></param>
        /// <returns></returns>
        private ArrayList getFreq(ArrayList a,int bars,float w,ArrayList bins)
        {
            ArrayList freq = new ArrayList();

            for (int i = 0; i < bars; i++)
            {
                int amount = 0;
                float bottom = (float)bins[i];
                float top = (float)bins[i + 1];
                for (int j = 0; j < a.Count; j++)
                {
                    float x = (float)a[j];
                    if (x >= bottom && x < top)
                    {
                        amount++;
                    }
                    if (x == top && x == getMax(a))
                    {
                        amount++;
                    }
                }
                freq.Add(amount);

            }

            return freq;

        }
    }

}
