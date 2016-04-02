using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class PandaSocialNetwork
    {
        private readonly List<Panda> users;

        public PandaSocialNetwork ( )
        {
            users = new List<Panda>();
        }
        public List<Panda> Users
        {
            get
            {
                return users;
            }
        }

        public Panda this[int index]
        {
            get { return users[index]; }
        }

        public void AddPanda ( Panda p )
        {
            users.Add(p);
        }
        public bool HasPanda ( Panda p )
        {
            return users.Contains(p);
        }
        public void MakeFriends ( Panda p1 , Panda p2 )
        {
            p1.Friends.Add(p2);
            p2.Friends.Add(p1);
        }
        public bool AreFriends ( Panda p1 , Panda p2 )
        {
            return p1.Friends.Contains(p2) && p2.Friends.Contains(p1);
        }
        public List<Panda> FriendsOf ( Panda p )
        {
            return p.Friends;
        }
        public int ConnectionLevel ( Panda p1 , Panda p2 )
        {
            Queue<Panda> qP = new Queue<Panda>();
            Queue<int> qL = new Queue<int>();
            HashSet<Panda> S = new HashSet<Panda>();
            qP.Enqueue(p1);
            qL.Enqueue(0);
            S.Add(p1);

            while(qP.Count > 0)
            {
                Panda p = qP.Dequeue();
                int level = qL.Dequeue();
                if(p.Equals(p2))
                    return level;
                foreach(Panda friend in p.Friends)
                {
                    if(!S.Contains(friend))
                    {
                        qP.Enqueue(friend);
                        qL.Enqueue(level + 1);
                        S.Add(friend);
                    }
                }
            }
            return -1;
        }
        public bool AreConnected ( Panda p1 , Panda p2 )
        {
            return ConnectionLevel(p1 , p2) != 0;
        }
    }

}

