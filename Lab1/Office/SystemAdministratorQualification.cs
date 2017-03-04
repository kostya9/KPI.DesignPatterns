using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Office
{
    public class SystemAdministratorQualification : IWorkQualification
    {
        public SystemAdministratorQualification(int yearsExperience)
        {
            YearsExperience = yearsExperience;
        }

        public int YearsExperience { get; }

        public void Work()
        {
            Console.WriteLine($"I'm a system administrator with {YearsExperience} years of experience. " +
                              $"Everything is set up perfectly and I don't need to do a thing!");
        }
    }
}
