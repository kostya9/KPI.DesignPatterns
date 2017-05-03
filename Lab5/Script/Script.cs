using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Script
{
    public class Script
    {
        private readonly List<Command> _operations;

        public Script()
        {
            _operations = new List<Command>();
        }

        public void AddCommand(Command c)
        {
            _operations.Add(c);
        }

        public void Execute()
        {
            foreach (var operation in _operations)
            {
                operation.Execute();
            }
        }

        public async Task Serialize(StreamWriter stream)
        {
            foreach (var operation in _operations)
            {
                await stream.WriteLineAsync(operation.Operation);
            }
        }
    }
}
