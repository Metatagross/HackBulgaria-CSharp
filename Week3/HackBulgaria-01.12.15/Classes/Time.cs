using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Time
    {
        DateTime date;
        public Time()
        {
            date = DateTime.Now;
        }
        public Time ( DateTime date )
        {
            this.date = date;
        }
        public override string ToString ( )
        {
            return string.Format("{0:hh:mm:ss dd.MM.yy}", date);
        }
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
