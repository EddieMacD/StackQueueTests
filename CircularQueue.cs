using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTests
{
    class CircularQueue: IQueue, IPrintPresence
    {
        private CircularPointer PointerF;
        private CircularPointer PointerB;
        private int Size;
        private int[] Contents;
        private int Used;

        public CircularQueue(int size)
        {
            Size = size;
            PointerF = new CircularPointer(Size - 1, Size);
            PointerB = new CircularPointer(0, Size);
            Used = 0;
            Contents = new int[size];
        }

        public void Dequeue()
        {
            if (!IsEmpty())
            {
                Used--;
                PointerB.Increment();
            }
        }

        public void Enqueue(int input)
        {
            if (!IsFull())
            {
                Used++;
                PointerF.Increment();
                Contents[PointerF.GetValue()] = input;
            }
        }

        public bool IsEmpty()
        {
            bool output = false;

            if (Used == 0)
            {
                output = true;
            }

            return output;
        }

        public bool IsFull()
        {
            bool output = false;

            if(Used == Size)
            {
                output = true;
            }

            return output;
        }

        public void Print()
        {
            if (!IsEmpty())
            {
                CircularPointer PointerPrint = new CircularPointer(PointerB.GetValue(), Size);

                while (PointerPrint.GetValue() != PointerF.GetValue())
                {
                    Console.Write(Contents[PointerPrint.GetValue()] + "    ");
                    PointerPrint.Increment();
                }

                Console.WriteLine(Contents[PointerPrint.GetValue()] + "    ");
            }
        }
    }
}
