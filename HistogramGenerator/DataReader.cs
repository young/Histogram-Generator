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
    /// This class Handles the Validation of Data. 
    /// </summary>
    class DataReader
    {
        public ArrayList inputData;
        public bool is_valid=true;
        public string message;

        /// <summary>
        /// This is the public method the user calls. It in turn calls a 
        /// private method that does the work. 
        /// </summary>
        /// <param name="temp"></param>
        public DataReader(string temp)
        {
            message = " ";
            inputData = Parse_Data(temp);
        }        
    
        /// <summary>
        /// This method takes a string of numbers and splits it up 
        /// into an array list of floats. It alerts the user if the Data is
        /// not in the write format, or is not big enough for the program to run. 
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        private ArrayList Parse_Data(string Input)
        {
            

            ArrayList numbers;
            numbers = new ArrayList();

            char[] delimiters = { ' ', ':', ',', ';', '\t' };
            string[] words = Input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                
                foreach (string s in words)
                {
                    float f = float.Parse(s);
                    numbers.Add(f);
                }
     
            }
                
            catch (FormatException)
            {
                is_valid = false;
                message = "Wrong Format, or has letters in data";
            }
            catch (NullReferenceException)
            {
                is_valid = false;
            }
            if (numbers.Count < 10)
            {
                is_valid = false;
                message = "Not enough numbers, try again.";
            }

            return numbers;
        }




    }
}
