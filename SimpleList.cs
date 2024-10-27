using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleList_with_Indexers
{
    internal class SimpleList<T> where T : IComparable
    {
        private Entry<T> _head;
        private Entry<T> _tail;

        public void Add(T value, T index)
        {
            Entry<T> temp = new Entry<T>(value, index);
            if (_head == null && _tail == null)
            {
                _head = temp;
                _tail = temp;
            }
            else
            {

                _tail.SetNext(temp, index);
                _tail = temp;



            }
        }
        public void RemoveFirst()
        {
            _head = _head.GetNext();
            if (_head == null) _tail = null;
        }
        public void Remove(T value)
        {
            Entry<T> previous = null;
            Entry<T> node = _head;


            while (node != null && node.GetData().CompareTo(value) != 0)
            {
                previous = node;
                node = node.GetNext();

            }

            if (node == null)
            {
                return;
            }
            previous.SetNext(node.GetNext(),node.GetNext().GetIndex());


        }
        public bool Contains(T value)
        {
            Entry<T> temp = _head;
            while (temp != null)
            {
                if (temp.GetData().CompareTo(value) == 0) return true;
                temp = temp.GetNext();
            }
            return false;
        }
        public int Count()
        {
            Entry<T> temp = _head;
            int i = 0;
            while (temp != null)
            {
                i++;
                temp = temp.GetNext();

            }
            return i;
        }
        public T[] ToArray()
        {
            Entry<T> temp = _head;
            T[] arr = new T[this.Count()];

            for (int i = 0; i < this.Count(); i++)
            {
                arr[i] = temp.GetData();
                temp = temp.GetNext();
            }
            return arr;
        }
        public T this[T index]
        {
            get
            {
                Entry<T> temp = _head;
                while (temp != null)
                {
                    if (temp.GetIndex().Equals(index))
                    {
                        return temp.GetData();
                    }
                    temp = temp.GetNext();
                }
                 throw new Exception("cant get");
            }
            set
            {
                Entry<T> temp = _head;
                while (temp != null)
                {
                    if (temp.GetIndex().Equals(index))
                    {
                        temp.SetData(value);
                        return;
                    }
                    temp = temp.GetNext();
                }
                throw new Exception("cant set");


            }
        }

}   }

   
