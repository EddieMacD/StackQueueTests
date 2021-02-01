using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTests
{
    interface IPriorityQueue
    {
        void Enqueue(int input, int priority);
        void Dequeue();
    }
}
