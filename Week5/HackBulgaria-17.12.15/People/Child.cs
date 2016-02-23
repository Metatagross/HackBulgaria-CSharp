using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Child : Person
    {
        private List<String> toys;

        public Child(string name, Gender g)
        {
            sex = g;
            this.name = name;
            toys = new List<string>();
        }

        public object Name
        { get
            {
                return name;
            }
        }

        public override void DoDailyStuff ( )
        {
            Console.WriteLine("The child plays!");
        }
        public override string ToString ( )
        {
            return string.Format("Hello! My name is {0}! I am a kid and have {1} toys!" , name , toys.Count);
        }
    }
}
