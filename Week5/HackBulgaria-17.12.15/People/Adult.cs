using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Adult : Person
    {
        private List<Child> children;
        private bool isBoring;
        public Adult ( string name , Gender g, bool b )
        {
            sex = g;
            this.name = name;
            children = new List<Child>();
            IsBoring = b;
        }
        public bool IsBoring
        {
            get
            {
                return isBoring;
            }
            set
            {
                isBoring = value;
            }
        }
        public override void DoDailyStuff ( )
        {
            Console.WriteLine("The adult works!");
        }
        public override string ToString ( )
        {
            return string.Format("Hello! My name is {0}! I am an adult and have {1} children!" , name , children.Count);
        }
    }
}
