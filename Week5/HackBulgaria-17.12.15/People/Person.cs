using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public enum Gender{Male , Female}

    public abstract class Person
    {
        protected Gender sex;
        protected string name;
        public abstract void DoDailyStuff ( );
    }

}
