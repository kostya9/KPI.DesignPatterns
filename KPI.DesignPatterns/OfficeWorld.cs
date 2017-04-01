using System;
using System.Collections.Generic;
using System.Text;
using Lab1.Office;

namespace KPI.DesignPatterns
{
    public class OfficeWorld : World
    {
        private List<OfficeWorker> _workers;
        public OfficeWorld()
        {
            _workers = new List<OfficeWorker>
            {
                new OfficeWorker("John", 1000, new SystemAdministratorQualification(10))
            };
            _workers.Add(new OfficeWorker("Michmond", 99999, new ManagerQualification(_workers)));
            _workers.Add(new OfficeWorker("Christian", 99999999, new DirectorQualification()));
        }

        protected override void RunIteration()
        {
            var random = new Random();
            foreach (var officeWorker in _workers)
            {
                officeWorker.Work();
                officeWorker.ReceiveSalary(officeWorker.Salary + (random.Next(3) - 1) * 1000);
                Console.WriteLine("");
            }
        }
    }
}
