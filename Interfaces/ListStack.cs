using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stack.Logic;

namespace Stack.Interfaces
{
    class ListStack<T> : IStack<T>
    {
        private List<T> _data;

        public ListStack()
        {
            _data = new List<T>();
        }

        public void Push(T value)
        {
            _data.Insert(0, value);
        }

        public T Pop()
        {
            try
            {
                T last = _data.ElementAt(0);
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
                return _data.ElementAt(0);
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
            for (int i = _data.Count - 1; i >= 0; i--)
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
