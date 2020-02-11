using SOLID___Dependency_Inversion_Principle;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IDataInput terminal = new Terminal();
        while (!terminal.Exited)
        {
            Command command = terminal.PromptCommand();
            terminal.ExecuteCommand(command);
        }
    }
}

