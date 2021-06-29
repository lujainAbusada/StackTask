using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Stack.Logic;

namespace Stack.Interfaces
{
    class LinkedListStack<T> : IStack<T>
    {
        private readonly LinkedList<T> _stack;

        public LinkedListStack()
        {
            _stack = new LinkedList<T>();
        }
        
        public void Push(T value)
        {
            _stack.AddFirst(value);
        }
        
        public T Pop()
        {
            T value = _stack.First.Value;
            _stack.RemoveFirst();
            return value;
        }
        
        public T Peek()
        {
            return _stack.First.Value;
        }
        
        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item2 in _stack)
            {
                yield return item2;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
 
        public void PrintStack(Action<object> methodToExecute)
        {
            foreach (var item in _stack)
            {
                methodToExecute(item);
            }
        }
    }
}


