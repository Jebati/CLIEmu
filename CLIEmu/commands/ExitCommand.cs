using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CLIEmu.commands
{
    public class ExitCommand : ICommand
    {
        public string Name { get; } = "exit";

        public string Execute(string[] args)
        {
            Process.GetCurrentProcess().Kill();
            return null;
        }
    }
}
