using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTests
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueueTest();
        }

        static void StackTest()
        {
            Stack stack = new Stack(5);

            stack.Push(5);
            Console.WriteLine(stack.Peek());

            stack.Push(9);
            stack.Push(6);
            Console.WriteLine(stack.Peek());
            stack.Print();

            stack.Pop();
            stack.Print();

            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.IsFull());

            Console.ReadLine();
        }

        static void CircularQueueTest()
        {
            CircularQueue queue = new CircularQueue(5);

            queue.Enqueue(5);
            queue.Print();

            queue.Enqueue(9);
            queue.Enqueue(6);
            queue.Print();

            queue.Dequeue();
            queue.Print();

            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.IsFull());

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.IsFull());

            queue.Enqueue(123);
            queue.Enqueue(456);
            queue.Enqueue(789);
            queue.Enqueue(159);
            queue.Print();

            queue.Enqueue(357);
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.IsFull());


            Console.ReadLine();
        }

        static void PriorityQueueTest()
        {
            PriorityQueue queue = new PriorityQueue(5);

            queue.Enqueue(5, 2);
            queue.Print();

            queue.Enqueue(9, 1);
            queue.Enqueue(6, 3);
            queue.Print();

            queue.Dequeue();
            queue.Print();

            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.IsFull());

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.IsFull());

            queue.Enqueue(123, 5);
            queue.Enqueue(456, 4);
            queue.Enqueue(789, 3);
            queue.Enqueue(159, 2);
            queue.Print();

            queue.Enqueue(357, 1);
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.IsFull());


            Console.ReadLine();
        }
    }
}
