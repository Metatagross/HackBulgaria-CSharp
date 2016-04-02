using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Program
    {
        static void Main ( string[] args )
        {
            Panda p = new Panda("Ivan" , "ivan@amn.bogn" , Gender.male);
            Panda p2 = new Panda("Gosho" , "gosho@amn.bogean" , Gender.male);
            Panda p3 = new Panda("Maria" , "mara@mon.net" , Gender.female);
            Panda p1 = new Panda("Lorna" , "lorna@mail.net" , Gender.female);
            PandaSocialNetwork net = new PandaSocialNetwork();
            net.Users.AddRange(new Panda[] { p , p2 , p3, p1 });
            net.MakeFriends(p , p2);
            net.MakeFriends(p2 , p3);
            net.MakeFriends(p2 , p1);
            net.MakeFriends(p3 , p1);
            Console.WriteLine( net.ConnectionLevel(p , p3));
            Console.WriteLine(net.ConnectionLevel(p , p));
            Console.WriteLine(net.ConnectionLevel(p , p2));
            Console.WriteLine(net.ConnectionLevel(p , p1));
        }
    }
}
