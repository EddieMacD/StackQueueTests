using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTests
{
    class Stack : IStack, IPrintPresence
    {
        private int Size;
        private int[] Contents;
        private int Top;

        public Stack(int size)
        {
            Size = size;
            Contents = new int[size];
            Top = -1;
        }

        public bool IsEmpty()
        {
            bool output = false;

            if (Top == -1)
            {
                output = true;
            }

            return output;
        }

        public bool IsFull()
        {
            bool output = false;

            if (Top == Size)
            {
                output = true;
            }

            return output;
        }

        public int Peek()
        {
            return Contents[Top];
        }

        public int Pop()
        {
            Top--;
            return Contents[Top + 1];
        }

        public void Print()
        {
            for (int i = 0; i <= Top; i++)
            {
                Console.Write(Contents[i] + "     ");
            }

            Console.WriteLine();
        }

        public void Push(int input)
        {
            Top++;
            Contents[Top] = input;
        }
    }
}
