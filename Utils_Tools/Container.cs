using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils_Tools
{
    public class Container<T>:ICollection
    {
        private List<T> _collection = new List<T>();
        public int Count
        {
            get
            {
                return _collection.Count;
            }
        }
        public bool IsReadOnly
        {
            get
            {
               return true;
            }
        }
        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Container(List<T> col)
        {
            _collection = col;
        }
        public Container() { }
        public T GetElement(int id)
        {
            return _collection[id];
        }
        public bool Remove(int id)
        {
            try
            {
                _collection.Remove(_collection[id]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Add(T item)
        {
            _collection.Add(item);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public bool Contains(T item)
        {
            return _collection.IndexOf(item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int c = 0;
            foreach (T t in _collection)
            {
                array[c] = t;
                c++;

            }
        }
        public void CopyAllTo(T[] array)
        {
            for(int i=0;i<array.Length;i++)
                array[i] = _collection[i];   
        }
        public bool Remove(T item)
        {
            try
            {
                _collection.Remove(item);
                return true;
            }
            catch 
            {
                return false;
            }
        
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
