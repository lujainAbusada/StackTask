using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using Stack.Logic;

namespace Stack.Interfaces
{
    class ArrayStack<T> : IStack<T>
    {

        private T[] _data = new T[1000];
        private int _index = 0;

        public ArrayStack()
        {

        }
        public void Push(T value)
        {
            _data[_index] = value;
            _index++;

        }

        public T Pop()
        {
            try
            {
                _index--;
                T last = _data[_index];
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
                return _data[_index];
            }
            catch
            {
                throw new NullReferenceException("Stack is Empty");
            }
        }

        public bool IsEmpty()
        {
            return _index == 0;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _index - 1; i >= 0; i--)
            {
                yield return _data[i];
            }


        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void PrintStack(Action<object> methodToExecute)
        {
            int temp = _index-1;
            while(temp>=0)
            {
                methodToExecute(_data[temp]);
                temp--;
                
            }
        }
    }
}
