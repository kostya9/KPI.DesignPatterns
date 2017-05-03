using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Script
{
    public class ArchiverCommand : Command
    {
        private readonly Archiver _executor;
        private readonly string _command;
        public ArchiverCommand(Archiver executor, string command)
        {
            _command = command.ToLower();
            if(_command != "archive" && _command != "extract")
                throw new NotSupportedException("This command is not supported");
            _executor = executor;
        }

        public override string Operation => $"Archiver : does : {_command}";

        public override void Execute()
        {
            if(_command == "archive")
                _executor.Archive();
            else if(_command == "extract")
                _executor.Extract();
            else
                throw new NotSupportedException("This command is not supported");
        }
    }
}
