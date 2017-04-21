using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.RegistryOffice
{
    class MarryRegistryProcess : RegistryProcess
    {
        public override RegistryReport DoRegistryOperation()
        {
            base.DoRegistryOperation();
            Console.WriteLine("Registrying a marriage...");
            return new RegistryReport(_claim.IssuerName, "Married");
        }
    }
}
