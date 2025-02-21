using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class MyStack<T>
    {
        public Stack<T> stack = new Stack<T>();

        public void AddItem(T item)
        {
            try
            {
                stack.Push(item);
                Console.WriteLine(item);
            }
            catch(Exception ex) { }
        }

        public T Remove()
        {
            return stack.Pop();
        }

        public void Check(T item)
        {
            stack.Peek();
            Console.WriteLine(item);
        }
        public void Length()
        {
            stack.Count();
        }

    }


}
