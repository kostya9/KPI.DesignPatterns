using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.RegistryOffice
{
    public class RegistryCreator
    {
        private static RegistryCreator _instance;
        public static RegistryCreator Instance => _instance ?? (_instance = new RegistryCreator());

        private RegistryCreator()
        {
            
        }

        private RegistryProcess ProcessFromType(RegistryType type)
        {
            switch (type)
            {
                case RegistryType.Baby:
                    return new BabyRegistryProcess();
                case RegistryType.Marry:
                    return new MarryRegistryProcess();
                case RegistryType.Unmarry:
                    return new UnmarryRegistryProcess();
                default:
                    throw new ArgumentException();
            }
        }
        public Registry RegistryFromType(RegistryType type)
        {
            return new Registry(ProcessFromType(type));
        }
    }
}
