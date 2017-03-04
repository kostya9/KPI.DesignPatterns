using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using Lab1.Clinic;
namespace KPI.DesignPatterns
{
    public abstract class World
    {
        public string Name { get; protected set; }

        protected abstract void RunIteration();

        public virtual void Run()
        {
            while (NextIteration())
                RunIteration();

            Console.WriteLine($"{Name} world is collapsing!");
        }

        public static World ByName()
        {
            bool next = true;
            while (next)
            {
                Console.WriteLine("Type in the number of the lab you want to start");
                var numebrText = Console.ReadLine();
                Assembly assembly;
                try
                {
                    var number = int.Parse(numebrText);
                    assembly = Assembly.Load(new AssemblyName($"Lab{number}"));
                }
                catch
                {
                    Console.WriteLine("Could not find the lab. Try again.");
                    continue;
                }
                
                Console.WriteLine("Type in the name of the task you want to start");
                var name = Console.ReadLine();
                Type world = Type.GetType($"KPI.DesignPatterns.{name}World", false, true);
                if (world == null)
                {
                    Console.WriteLine("Could not find the task. Try again.");
                    continue;
                }

                return (World)Activator.CreateInstance(world);
            }
            return null;
        }


        protected bool NextIteration()
        {
            Console.WriteLine("Type 'go' if you want to continue the simulation...");
            if(Console.ReadLine().ToLower() == "go")
                return true;
            return false;
        }
    }
}
