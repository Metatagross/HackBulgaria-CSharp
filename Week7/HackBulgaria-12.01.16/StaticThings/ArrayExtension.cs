using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticThings
{
    public static class ArrayExtension
    {
        public static List<T> Intersect<T> ( this List<T> fisrtList , List<T> secondList )
        {
            List<T> result = new List<T>();
            foreach(var item in fisrtList)
            {
                if(secondList.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<T> Union<T> ( List<T> fisrtList , List<T> secondList )
        {
            List<T> result = new List<T>();
            result.AddRange(fisrtList);
            foreach(var item in secondList)
            {
                if(!result.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<T> UnionAll<T> ( List<T> fisrtList , List<T> secondList )
        {
            List<T> result = new List<T>();
            result.AddRange(fisrtList);
            result.AddRange(secondList);
            return result;
        }
        public static string Join ( List<String> list )
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in list)
            {
                sb.Append(item + Configuration.GetReplacingValue());
            }
            sb.Remove(sb.Length - 1 , 1);
            return sb.ToString();
        }
    }
}
