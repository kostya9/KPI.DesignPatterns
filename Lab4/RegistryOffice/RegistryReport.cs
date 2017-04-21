using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.RegistryOffice
{
    public class RegistryReport
    {
        public string Name { get; set; }
        public string Operation { get; set; }

        public RegistryReport(string name, string operation)
        {
            Name = name;
            Operation = operation;
        }
    }
}
