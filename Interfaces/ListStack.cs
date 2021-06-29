using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stack.Logic;

namespace Stack.Interfaces
{
    class ListStack<T> : IStack <T>
    {

        private  List<T> _data;
        private int _index = 0;

        public ListStack()
        {
            _data = new List<T>();
        }

        public void Push(T value)
        {
            _data.Add(value);
            _index = _data.Count - 1;

        }

        public T Pop()
        {
            try
            {
                T last = _data.ElementAt(_index);
                _index--;
                _data.Remove(last);
                return last;
            }
            catch
            {
                throw new NullReferenceException("Stack is Empty");
            }

        }

        public T Peek()
        {
            try
            {
                return _data.ElementAt(_index);
            }
            catch
            {
                throw new NullReferenceException("Stack is Empty");
            }
        }

        public bool IsEmpty()
        {
            return _data.Count == 0;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _index; i >= 0; i--)
            {
                yield return _data.ElementAt(i);
            }
        }
        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
     
        public void PrintStack(Action<object> methodToExecute)
        {

            foreach (var item in _data)
            {
                methodToExecute(item);
            }
        }

    }

}
