using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
 
namespace SocialNetwork
{
    public enum Gender { male, female};
    public class Panda
    {
        private readonly string name;
        private readonly List<Panda> friends;

        public Panda(string n, string m, Gender g)
        {
            Regex r = new Regex(@"\w@\w.\w");
            if(r.IsMatch(m))
            {
                name = n;
                Mail = m;
                Gender = g;
                friends = new List<Panda>();
            }
            else
            {
                throw new InvalidOperationException("Invalid mail");
            }
        }
        public Panda(Panda p): this(p.Name, p.Mail, p.Gender)
        {
            friends = new List<Panda>(p.friends);
        }
        public string Name => name;

        public string Mail { get; }

        public Gender Gender { get; }

        public List<Panda> Friends => friends;

        public override string ToString ( )
        {
            return String.Format($"Pandaname: {Name}\nE-mail: {Mail}\nGender: {Gender}");
        }
        public override bool Equals ( object obj )
        {
            if(obj!=null)
            {
                Panda newP = (Panda)obj;
                return newP.Name == Name && newP.Mail == Mail && newP.Gender == Gender;
            }
            return false;
        }
    }
}
