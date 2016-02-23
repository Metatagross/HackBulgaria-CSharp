using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Mammal : Animal
    {
        public Mammal ( )
        {
            type = "mammal";
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats!" , type);
        }

        public override void GiveBirth ( )
        {
            Console.WriteLine("The {0} gives birth!" , type);
        }

        public override void Greet ( )
        {
            Console.WriteLine("The {0} makes a sound!" , type);
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} moves!" , type);
        }
    }
    class Reptile : Animal
    {
        public Reptile ()
        {
            type = "reptile";
        }
        public float Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats!" , type);
        }

        public override void GiveBirth ( )
        {
            Console.WriteLine("The {0} gives birth!" , type);
        }

        public override void Greet ( )
        {
            Console.WriteLine("The {0} makes a sound!" , type);
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} moves!" , type);
        }
    }
    class Fish : Animal
    {
        public Fish ( )
        {
            isOnLand = false;
            type = "fish";
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats!" , type);
        }

        public override void GiveBirth ( )
        {
            Console.WriteLine("The {0} gives birth!" , type);
        }

        public override void Greet ( )
        {
            Console.WriteLine("The {0} doesn't make a sound!" , type);
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} moves!" , type);
        }
    }
    class Bird : Animal
    {
        public Bird ( )
        {
            isOnLand = true;
            type = "bird";
        }
        public void Nest ( )
        {
            Console.WriteLine("The bird makes a nest!");
            Console.WriteLine("Time goes by!");
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats!" , type);
        }

        public override void GiveBirth ( )
        {
            Console.WriteLine("The eggs hatch!");
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} moves!" , type);
        }

        public override void Greet ( )
        {
            Console.WriteLine("The {0} makes a sound!" , type);
        }
    }
}
