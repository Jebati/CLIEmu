using System;
using System.Collections.Generic;
using System.Text;

namespace CLIEmu.commands
{
    public interface ICommand
    {
        string Name { get; }
        string Execute(string[] args);
    }
}
