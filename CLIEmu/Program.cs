﻿using CLIEmu.commands;
using System;
using System.IO;

namespace CLIEmu
{
    public class Program
    {
        static void Main()
        {
            /* Указываем начальную директорию */
            CommandHandler.ToDirectory(Environment.CurrentDirectory);

            /* Регистрируем комманды */
            CommandHandler.Register(new ExitCommand()); // exit
            CommandHandler.Register(new PrintWorkingDirectoryCommand()); // pwd
            CommandHandler.Register(new ChangeDirectoryCommand()); // cd <PATH>
            CommandHandler.Register(new ListCommand()); // ls

            while (true)
            {
                Console.Write($"{CommandHandler.Path}> ");
                string command = Console.ReadLine();
                Console.WriteLine(CommandHandler.Execute(command));
            }
        }
    }
}
