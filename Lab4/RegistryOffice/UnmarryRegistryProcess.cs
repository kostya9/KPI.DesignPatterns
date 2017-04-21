using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.RegistryOffice
{
    class UnmarryRegistryProcess : RegistryProcess
    {
        public override RegistryReport DoRegistryOperation()
        {
            base.DoRegistryOperation();
            Console.WriteLine("Unmarrying...");
            return new RegistryReport(_claim.IssuerName, "Unmarried");
        }
    }
}
