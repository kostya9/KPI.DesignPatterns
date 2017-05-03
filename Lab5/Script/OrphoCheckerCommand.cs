using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Script
{
    public class OrphoCheckerCommand : Command
    {
        private readonly OrphoChecker _executor;
        private readonly string _command;
        public OrphoCheckerCommand(OrphoChecker executor, string command)
        {
            _command = command.ToLower();
            if (_command != "check" && _command != "fix")
                throw new NotSupportedException("This command is not supported");
            _executor = executor;
        }

        public override string Operation => $"OrphoChecker : does : {_command}";

        public override void Execute()
        {
            if (_command == "check")
                _executor.Check();
            else if (_command == "fix")
                _executor.Fix();
            else
                throw new NotSupportedException("This command is not supported");
        }
    }
}
