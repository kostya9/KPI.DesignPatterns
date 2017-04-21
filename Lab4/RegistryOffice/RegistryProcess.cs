using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.RegistryOffice
{
    public abstract class RegistryProcess
    {
        protected Claim _claim;

        public void SendClaim(string name, string text)
        {
            _claim = new Claim();
            _claim.Text = text;
            _claim.IssuerName = name;
            Console.WriteLine(string.Format("Received claim from {0}: \n\n{1}\n\n", _claim.IssuerName, _claim.Text));
        }

        public void Pay(int price)
        {
            _claim.Payed = true;
            Console.WriteLine(string.Format("Payed the price of {0} $\n", price));
        }

        public virtual RegistryReport DoRegistryOperation()
        {
            if(!_claim.Payed)
                throw new ArgumentException("Did not pay");

            return null;
        }
    }
}
