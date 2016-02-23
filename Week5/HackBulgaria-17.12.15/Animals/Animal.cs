using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        protected string type;
        protected float temperature;
        protected string name;
        protected bool isOnLand;

        public abstract void Move ( );
        public abstract void Eat ( );
        public abstract void GiveBirth ( );
        public abstract void Greet ( );
    }
}
