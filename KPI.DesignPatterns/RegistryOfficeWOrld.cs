using System;
using System.Collections.Generic;
using System.Text;
using Lab4.RegistryOffice;

namespace KPI.DesignPatterns
{
    class RegistryOfficeWorld : World
    {
        protected override void RunIteration()
        {
            string name = "Emily";
            string text = "I want! I said!";
            int pay = 10;

            var registries = new[]
            {
                RegistryCreator.Instance.RegistryFromType(RegistryType.Baby),
                RegistryCreator.Instance.RegistryFromType(RegistryType.Marry),
                RegistryCreator.Instance.RegistryFromType(RegistryType.Unmarry)
            };

            foreach (var registry in registries)
            {
                Console.WriteLine("----------");
                var report = registry.Register(name, text, pay);
                Console.WriteLine("\nYeah! I've got a report.\n");
                Console.WriteLine(string.Format("Issuer: {0}\nOperation: {1}", report.Name, report.Operation));
            }


        }
    }
}
