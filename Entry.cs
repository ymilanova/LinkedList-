using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList_with_Indexers
{
    internal class Entry<T> where T : IComparable
    {
        private T _data;
        private Entry<T> _next;


        public void SetNext(Entry<T> next)
        {
            _next = next;
        }
        public Entry<T> GetNext()
        {
            return _next;
        }
        public Entry (T data)
        {
            _data = data;
        }

}
}
