using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic08
{
    internal class newList<T> 
    {
        private List<T> list;

        public newList()
        {
            list = new List<T>();
        }
        public bool Exist(Predicate<T> match)
        {
            if(match != null)
            {
                foreach(T item in list)
                {
                    if (match(item)) return true;
                }
            }
            return false;
        }
        public T Find (Predicate<T> match)
        {
            if (match != null)
            {
                foreach (T item in list)
                { if (match(item)) return item;}
            }
            return default;
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> newlist = new List<T>();
            if (match != null)
            {
                foreach (T item in list)
                { if (match(item)) newlist.Add( item); }
            }
            return newlist;
        }
        public int FindIndex(Predicate<T> match)
        {
            if (match != null)
            {
                int counter = 0;
                foreach (T item in list)
                {
                    if (match(item)) return counter  ; 
                    counter++;
                }
            }
            return 0;
        }
        public T FindLast(Predicate<T> match)
        {
            int index = -1;
            if (match != null)
            {
                int counter = 0;
                foreach (T item in list)
                {
                    if (match(item))
                    {
                        index = counter;
                    }
                        counter++;
                }
            }
            if (index != -1)
                return list[index];
            else
                return default;
        }
        public int FindLastIndex(Predicate<T> match)
        {
            int index = -1;
            if (match != null)
            {
                int counter = 0;
                foreach (T item in list)
                {
                    if (match(item))
                    {
                        index = counter;
                    }
                    counter++;
                }
            }
            if (index != -1)
                return index;
            else
                return default;
        }

        public T Forech(Predicate<T> match)
        {
            if (match != null)
            {
                foreach (T item in list)
                {
                    return item; 
                }
            }
            return default;
        }

        public bool TrueForAll(Predicate<T> match)
        {
            int counter = 0;
            if (match != null)
            {
                foreach (T item in list)
                {
                    if (match(item))
                    {
                        counter++;
                    }
                }
            }
            if (counter == list.Count)
                return true;
            else
                return false;
        }

    }
}
