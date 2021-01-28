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
            StackTest();
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
    }
}
