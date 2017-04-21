using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.RegistryOffice
{
    class BabyRegistryProcess : RegistryProcess
    {
        public override RegistryReport DoRegistryOperation()
        {
            base.DoRegistryOperation();
            Console.WriteLine("Registering baby...");
            return new RegistryReport(_claim.IssuerName, "Registered baby.");
        }
    }
}
