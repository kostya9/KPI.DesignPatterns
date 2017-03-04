using System;

namespace KPI.DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var world = World.ByName();
            world?.Run();
        }
    }
}
