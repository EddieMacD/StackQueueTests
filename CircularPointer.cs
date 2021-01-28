using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTests
{
    class CircularPointer: IPointer
    {
        private int Value;
        private int Limit;

        public CircularPointer(int value, int limit)
        {
            Value = value;
            Limit = limit;
        }

        public int GetValue()
        {
            return Value;
        }

        public void Increment()
        {
            Value++;

            if (Value == Limit)
            {
                Value = 0;
            }
        }
    }
}
