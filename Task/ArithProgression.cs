using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class ArithProgression : ISeries
    {
        int start;
        int next;
        public int Start { get => start; }
        public int GetNext()
        {
            next += start;
            return next;
        }
        public void Reset()
        {
            next = start;
        }
        public void SetStart(int x)
        {
            start = x;
            next = start;
        }
    }


}

