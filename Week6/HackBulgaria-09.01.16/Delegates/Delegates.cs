using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaters
{
    public delegate bool FilterDelegate ( int number );
    public delegate int AggregationDelegate ( List<int> original );
    public class Delegates
    {
        public List<int> FilterCollection ( List<int> original , FilterDelegate filter )
        {
            List<int> result = new List<int>();
            foreach(var item in original)
            {
                if(filter(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public int AggregateCollection ( List<int> original , AggregationDelegate aggregate )
        {
            return aggregate(original);
        }
        public List<int> BubbleSort ( List<int> original , Func<int , int , int> com )
        {
            bool finish = true;
            while(finish)
            {
                finish = false;
                for(int i = 0 ; i < original.Count - 1 ; i++)
                {

                    if(com(original[i] , original[i + 1]) > 0)
                    {
                        int temp = original[i];
                        original[i] = original[i + 1];
                        original[i + 1] = temp;
                        finish = true;
                    }
                }
            }
            return original;
        }
    }
}
