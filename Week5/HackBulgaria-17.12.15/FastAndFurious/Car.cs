using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    public abstract class Car
    {
        public abstract bool IsEcoFriendly ( bool testing );
        public virtual void Brum ( )
        {
            Console.WriteLine("Brum!");
        }
    }

    public class GermanCar : Car
    {
        private int mileage;

        protected int Mileage
        {
            get
            {
                return mileage;
            }

            set
            {
                mileage = value;
            }
        }

        public override bool IsEcoFriendly ( bool testing )
        {
            return true;
        }
    }
    public class Audi : GermanCar
    {

        public override void Brum ( )
        {
            Console.Write("Audi said: ");
            base.Brum();
        }
        public override bool IsEcoFriendly ( bool testing )
        {
            return base.IsEcoFriendly(testing);
        }
    }

    public class BMW : GermanCar
    {
        public override void Brum ( )
        {
            Console.Write("BMW said: ");
            base.Brum();
        }

        public override bool IsEcoFriendly ( bool testing )
        {
            return base.IsEcoFriendly(testing);
        }
    }

    public class Volkswagen : GermanCar
    {
        public override void Brum ( )
        {
            Console.Write("Volkswagen said: ");
            base.Brum();
        }
        public override bool IsEcoFriendly ( bool testing )
        {
            return testing;
        }
    }

    public class Honda : Car
    {
        public override void Brum ( )
        {
            Console.Write("Honda said: ");
            base.Brum();
        }

        public override bool IsEcoFriendly ( bool testing )
        {
            return true;
        }
    }

    public class Skoda : Car
    {
        public override void Brum ( )
        {
            Console.Write("Skoda said: ");
            base.Brum();
        }

        public override bool IsEcoFriendly ( bool testing )
        {
            return true;
        }
    }

}
