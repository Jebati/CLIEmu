using System;
using System.Collections.Generic;
using System.Text;

namespace CLIEmu.commands
{
    class ChangeDirectoryCommand : ICommand
    {
        public string Name { get; } = "cd";

        public string Execute(string[] args)
        {
            if (args.Length == 2)
            {
                if(System.IO.Directory.Exists(args[1]))
                {
                    CommandHandler.ToDirectory(args[1]);
                } else
                {
                    return "Directory does not exist";
                }
            }
            else
            {
                return "Command arguments were passed incorrectly.\ncd <PATH>";
            }

            return null;
        }
    }
}
