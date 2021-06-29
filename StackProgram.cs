using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Stack.Interfaces;


namespace Stack
{
    class StackProgram
    {
        static void Main(string[] args)
        {
            LinkedListStack<int> s = new LinkedListStack<int>();
            s.Push(5);
            s.Push(6);
            s.Push(7);
            s.Push(8);
            int sum = 0;
            s.PrintStack(new Action<object>(PrintStack));
            while (!s.IsEmpty())
            {
                int temp = s.Pop();
                sum += temp;
            }
            Console.WriteLine("The sum is {0}", sum);
        }

        public static void PrintStack<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
