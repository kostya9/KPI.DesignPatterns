using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Clinic
{
    public abstract class Doctor
    {
        protected Doctor(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void CheckPatient(Patient p);
        public abstract void Add(Doctor committee);
        public abstract void Remove(Doctor committee);

        public void Say(string message)
        {
            Console.WriteLine($"{Name} : {message}");
        }
    }
}
