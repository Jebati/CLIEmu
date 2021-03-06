﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CLIEmu.commands
{
    public class PrintWorkingDirectoryCommand : ICommand
    {
        public string Name { get; } = "pwd";
        public string Execute(string[] args)
        {
            return CommandHandler.Path;
        }
    }
}
