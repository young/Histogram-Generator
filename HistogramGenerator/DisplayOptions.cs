using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistogramGenerator
{
    /// <summary>
    /// This class controls the Options set by the
    /// user for the dispaly of the histogram image.
    /// It contains both the actual oparemters
    /// and whether or not they have been changed 
    /// and should be used. 
    /// </summary>
    class DisplayOptions
    {   
            //Values for the options
            public int number_of_ticks;
            public double tick_interval;
            public double label_start;
            public double label_stop;
            public int vert_Label_Decimals;
            public int hor_Label_Decimals;
            //Whether or not they have changed
            public bool number_of_ticksB;
            public bool tick_intervalB;
            public bool label_startB;
            public bool label_stopB;
            public bool vert_Label_DecimalsB;
            public bool hor_Label_DecimalsB;
        /// <summary>
        /// This is the constructor called at Start-up.
        /// Sets the parameters to some defualt values and 
        /// startes each ones change value at false. 
        /// </summary> 
        public DisplayOptions()
        {
            this.number_of_ticks=3;
            this.tick_interval=1;
            this.label_start=0;
            this.label_stop=1000;
            this.vert_Label_Decimals=0;
            this.hor_Label_Decimals=0;
            this.number_of_ticksB = false;
            this.tick_intervalB = false;
            this.label_startB = false;
            this.label_stopB = false;
            this.vert_Label_DecimalsB = false;
            this.hor_Label_DecimalsB = false;
        }
    }
}
