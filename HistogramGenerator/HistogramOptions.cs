using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistogramGenerator
{
    /// <summary>
    /// This class controls the options set by 
    /// the user that control how the histogram is 
    /// generated. It stores falses and booleans that 
    /// tell if the value has been changed or not. 
    /// </summary>
    class HistogramOptions
    {
        public int num_bins;
        public float LCL;
        public float UCL;
        public bool num_binsB;
        public bool LCLB;
        public bool UCLB;
        public double LabelStart;
        public bool LabelStartB;
        public double LabelStop;
        public bool LabelStopB;

        /// <summary>
        /// The Default constructor that sets everything to some dummy values. 
        /// </summary>
        public HistogramOptions()
        {
            this.num_bins = 3;
            this.num_binsB = false;
            this.LCL = 0;
            this.LCLB = false;
            this.UCL = 10000;
            this.UCLB = false;
            this.LabelStopB=false;
            this.LabelStartB = false;
        }
      
    }
}
