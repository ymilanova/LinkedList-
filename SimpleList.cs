using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList_with_Indexers
{
    internal class SimpleList<T> where T:IComparable
    {
        private Entry<T> _head;
        private Entry<T> _tail;

        public void Add(T value) 
        {
            if (_head == null && _tail == null)
            {
                _head = new Entry<T>(value);
                _tail = new Entry<T>(value);
            }
            else 
            {
                Entry<T> temp = new Entry<T>(value);
                _head.SetNext(temp);
                _tail = _head;



            }
        }


    }
}
