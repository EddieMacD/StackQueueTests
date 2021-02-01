using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTests
{
    class PriorityQueue : IPriorityQueue, IPrintPresence
    {
        private int Size;
        private int PointerB;
        private int[] Contents;
        private int[] Priority;

        public PriorityQueue(int size)
        {
            Size = size;
            Contents = new int[Size];
            Priority = new int[Size];
        }

        public void Dequeue()
        {
            if (PointerB > 0)
            {
                PointerB--;

                for (int i = 1; i <= PointerB; i++)
                {
                    Contents[i - 1] = Contents[i];
                }
            }
        }

        public void Enqueue(int input, int priority)
        {
            if (PointerB < Size)
            {
                Contents[PointerB] = input;
                Priority[PointerB] = priority;

                for (int i = PointerB; i > 0; i--)
                {
                    if (Priority[i] < Priority[i - 1])
                    {
                        Swap(ref Contents[i], ref Contents[i - 1]);
                        Swap(ref Priority[i], ref Priority[i - 1]);
                    }
                }

                PointerB++;
            }
        }

        private void Swap (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public bool IsEmpty()
        {
            bool output = false;

            if (PointerB == 0)
            {
                output = true;
            }

            return output;
        }

        public bool IsFull()
        {
            bool output = false;

            if (PointerB == Size)
            {
                output = true;
            }

            return output;
        }

        public void Print()
        {
            for(int i = 0; i < PointerB; i++)
            {
                Console.Write(Contents[i] + " (" + Priority[i] + ")    ");
            }

            Console.WriteLine();
        }
    }
}
