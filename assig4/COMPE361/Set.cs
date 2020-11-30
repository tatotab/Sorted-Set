using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assig4.COMPE361
{
    ///declare delegate
   
    class Set<T> :IEnumerable<T>
    {
        protected List<T> Container;
        public Set()
        {
            Container = new List<T>();
        }

        public Set(IEnumerable<T> e)
        {
            Container = new List<T>();
            foreach(var item in e)
            {
                if (Container.Contains(item) == false)
                    Container.Add(item);
            }
         
        }
        public static Set<T> operator +(Set<T> lhs, Set<T> rhs)
        {
            //put all elements from lhs into new set
            Set<T> unionSet = new Set<T>(lhs);
            //try putting rhs elements into unionset firstly by checking if there is not already the element
            foreach(var item in rhs)
            {
                if (!unionSet.Contains(item))
                {
                    unionSet.Container.Add(item);
                }
            }
            return unionSet;
            
        } 
        public virtual bool Add(T datum)
        {
            //check if it is not already in the set and if there is return false
            if (Container.Contains(datum))
            {
                return false;
            }
            else
            {   //if it is not in the set add and return true 
                Container.Add(datum);
                return true;
            }
        }
        public virtual bool Remove(T datum)
        {
            //check that datum is in the container, if it contains remove and return true
            if (Container.Contains(datum))
            {
                Container.Remove(datum);
                return true;
            }
            return false;
        }
        public bool Contains(T datum) => Container.Contains(datum);
        public delegate bool F<T>(T elt);
        public Set<T> Filter(F<T> filterFunction)
        {
            Set<T> filteredSet = new Set<T>();
            foreach(var item in Container)
            {
                if(filterFunction(item))
                filteredSet.Container.Add(item);
            }
            return filteredSet;
        }
        //creating functions count and isEmpty which are only readable
        public int Count
        {
            get => Container.Count();
            
        }
        public bool isEmpty
        {
            get => !this.Container.Any();
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var elt in Container)
            {
                yield return elt;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
