using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Clinic
{
    public abstract class SimpleDoctor : Doctor
    {
        public SimpleDoctor(string name) : base(name)
        {
        }

        public override void Add(Doctor committee)
        {
            throw new InvalidOperationException("Cannot add to a simple doctor");
        }

        public override void Remove(Doctor committee)
        {
            throw new InvalidOperationException("Cannot add to a simple doctor");
        }
    }
}
