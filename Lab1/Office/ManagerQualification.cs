using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Office
{
    public class ManagerQualification : IWorkQualification
    {
        private readonly IList<OfficeWorker> _workers;

        public ManagerQualification(IList<OfficeWorker> workers)
        {
            _workers = workers;
        }

        public void Work()
        {
            Console.WriteLine($"Okay, we've got {_workers.Count} workers, but we do actually need {_workers.Count - 1}! Who wants to be fired?");
        }
    }
}
