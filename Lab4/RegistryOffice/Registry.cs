using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.RegistryOffice
{
    public class Registry
    {
        private readonly RegistryProcess _process;
        public Registry(RegistryProcess process)
        {
            _process = process;
        }

        public RegistryReport Register(string name, string claimText, int pay)
        {
            _process.SendClaim(name, claimText);
            _process.Pay(pay);
            return _process.DoRegistryOperation();
        }
    }
}
