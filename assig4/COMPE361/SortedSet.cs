using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace assig4.COMPE361
{
    class SortedSet<T> : Set<T>
        where T : IComparable<T>
    {
        public SortedSet(IEnumerable<T> e)
                : base(e)
        {
            Container.Sort();
        }
        public override bool Add(T datum)
        {

            //extending function;
            if (Container.Contains(datum))
            {
                return false;
            }
            else
            {    
                Container.Add(datum);
                Container.Sort();
                return true;
            }
        }
        public override bool Remove(T datum)
        {
            return base.Remove(datum);
        }
        //union method needs modification for sorted
        public static SortedSet<T> operator +(SortedSet<T> lhs, SortedSet<T> rhs)
        {
            SortedSet<T> unionSet = new SortedSet<T>(lhs);
            foreach (var item in rhs)
            {
                if (!unionSet.Contains(item))
                {
                    unionSet.Container.Add(item);
                }
            }
            unionSet.Container.Sort();
            return unionSet;
        }
       
    }
}
