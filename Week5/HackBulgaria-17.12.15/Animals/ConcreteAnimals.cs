using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Mammal
    {
        public Cat()
        {
            isOnLand = true;
            name = "Cat";
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats!" , name);
        }

        public override void GiveBirth ( )
        {
            Console.WriteLine("The {0} gives birth!" , name);
        }

        public override void Greet ( )
        {
            Console.WriteLine("The {0} says : Meow!" , name);
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} moves!" , name);
        }
    }
    class Dog : Mammal
    {
        public Dog ( )
        {
            isOnLand = true;
            name = "Dog";
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats!" , name);
        }

        public override void GiveBirth ( )
        {
            Console.WriteLine("The {0} gives birth!" , name);
        }

        public override void Greet ( )
        {
            Console.WriteLine("The {0} says : Bark!" , name);
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} moves!" , name);
        }
    }
    class Crocodile : Reptile
    {
        public Crocodile ( )
        {
            isOnLand = false;
            name = "Crocodile";
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats!" , name);
        }

        public override void GiveBirth ( )
        {
            Console.WriteLine("The {0} spawns!" , name);
            Console.WriteLine("The eggs hatch!");
        }

        public override void Greet ( )
        {
            Console.WriteLine("The {0} says : Crook!" , name);
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} moves!" , name);
        }
    }
    class Owl : Bird
    {
        public Owl ( )
        {
            isOnLand = true;
            name = "Owl";
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats!" , name);
        }

        public override void GiveBirth ( )
        {
            base.Nest();
            base.GiveBirth();
        }

        public override void Greet ( )
        {
            Console.WriteLine("The {0} says : Hoot-hoot!" , name);
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} flies!" , name);
        }
    }
    class Shark : Fish
    {
        public Shark ( )
        {
            isOnLand = false;
            name = "Shark";
        }
        public override void Eat ( )
        {
            Console.WriteLine("The {0} eats! #Jaws" , name);
        }

        public override void GiveBirth ( )
        {
            Console.WriteLine("The {0} gives birth!" , name);
        }

        public override void Greet ( )
        {
            base.Greet();
        }

        public override void Move ( )
        {
            Console.WriteLine("The {0} swims!" , name);
        }
    }
}
