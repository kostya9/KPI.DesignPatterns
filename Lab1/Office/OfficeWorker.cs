using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Office
{
    public class OfficeWorker
    {
        public OfficeWorker(string name, int salary, IWorkQualification qualification)
        {
            Name = name;
            Salary = salary;
            Qualification = qualification;
            IsActive = true;
        }

        public bool IsActive { get; private set; }
        public string Name { get; }
        public int Salary { get; }

        private IWorkQualification Qualification { get; set; }

        public virtual void Work()
        {
            Qualification.Work();
        }

        public void ReceiveSalary(int dollars)
        {
            Console.WriteLine(dollars < Salary
                ? "I'm sad, the payment is less than my salar."
                : "I'm ok, received my salary.");
        }

        public void Resign()
        {
            IsActive = false;
        }
    }
}
