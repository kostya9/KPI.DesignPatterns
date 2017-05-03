using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Lab5.Script;

namespace KPI.DesignPatterns
{
    class ScriptWorld : World
    {
        private readonly string _fileName = Path.Combine(Directory.GetCurrentDirectory(),  "script.txt");
        protected override async void RunIteration()
        {
            var script = new Script();
            var archiver = new Archiver();
            var checker = new OrphoChecker();
            script.AddCommand(new ArchiverCommand(archiver, "extract"));
            script.AddCommand(new OrphoCheckerCommand(checker, "check"));
            script.AddCommand(new OrphoCheckerCommand(checker, "fix"));
            script.AddCommand(new ArchiverCommand(archiver, "archive"));
            script.Execute();

            Console.WriteLine("Writing to file...");
            using (var writer = new StreamWriter(File.Open(_fileName, FileMode.Create, FileAccess.Write)))
            {
                await script.Serialize(writer);
            }
            Console.WriteLine("The file was filled in successfully");

            Process.Start("notepad.exe", _fileName);
        }
    }
}
