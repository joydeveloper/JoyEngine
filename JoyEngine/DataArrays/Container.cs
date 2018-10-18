using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace JoyEngine
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
        public T GetLast()
        {

            return _collection.Last();
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
            return _collection.GetEnumerator();
        }
   
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
   public class Switcher2way<T>
    {
        public List<T> ObjectArray = new List<T>();
        internal int _id = 0;
        public Switcher2way(List<T> list)
        {
            ObjectArray = list;
        }
        public Switcher2way()
        {
            SetActive(0);
        }
        public void SetActive(int id) { _id = id; }
        public int AtiveID { get { return _id; } private set { } }
        public T GetActiveObject() { return ObjectArray[_id]; }
        public T SwitchLeft()
        {
            _id--;
            _id = (_id < 0) ? ObjectArray.Count - 1 : _id;
            return ObjectArray[_id];
        }
        public T SwitchRight()
        {
            _id++;
            _id = (_id == ObjectArray.Count) ? 0 : _id;
            return ObjectArray[_id];
        }

    }
}
