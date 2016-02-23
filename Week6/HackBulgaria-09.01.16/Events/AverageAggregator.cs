using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void AverageChangedHandler ( object sender );
    public class AverageAggregator
    {
        public event AverageChangedHandler AverageChanged;
        private decimal average;
        private int counter;
        public AverageAggregator ( )
        {
            Average = 0;
            counter = 0;
        }
        public decimal Average
        {
            get
            {
                return average;
            }

            set
            {
                average = value;
            }
        }

        public void AddNumber ( decimal number )
        {
            decimal newAverage = (Average * counter + number) / (++counter);
            
            if(newAverage != Average && AverageChanged != null)
            {
                Average = newAverage;
                AverageChanged(this);
            }
            else
            {
                counter--;
            }
        }

    }
}
