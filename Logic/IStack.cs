using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.Logic
{
        delegate void PrintStack();
        public interface IStack<T> : IEnumerable<T>
        {
            public void Push(T value);
            public T Pop();
            public bool IsEmpty();
            public T Peek();
            public IEnumerator<T> GetEnumerator();
            public void PrintStack(Action<object> methodToExecute);



        }
    
}
