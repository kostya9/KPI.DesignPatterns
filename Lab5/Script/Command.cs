using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Script
{
    public abstract class Command
    {
        public abstract string Operation { get; }

        public abstract void Execute();
    }
}
