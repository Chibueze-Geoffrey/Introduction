using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class MyQueue<T>
    {
        public Queue<T> Queues = new Queue<T>();


        public T Enqueue(T item)
        {
            Queues.Enqueue(item);
            return item;
        }

        public void AddItems(T item)
        {
            Queues.Enqueue(item);
            Console.WriteLine("Added");
        }


        public void Remove(T item)
        {
            Queues.Dequeue();
            Console.WriteLine("Removed");
        }

        public void Clear()
        {
            Queues.Clear();
        }
    }
}
