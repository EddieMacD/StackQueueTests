using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTests
{
    public interface IPointer
    {
        int GetValue();
        void Increment();
    }
}
