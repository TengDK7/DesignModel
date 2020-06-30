using System.Reflection;
using System.Configuration;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalButton button = new NormalButton();
            OpenCommand openCommand = new OpenCommand();
            CloseCommand closeCommand = new CloseCommand();
            button.Command = openCommand;
            button.ButtonClick();
            Console.WriteLine();
            button.Command = closeCommand;
            button.ButtonClick();
            Console.WriteLine();

            string command = ConfigurationManager.AppSettings["Command"];
            Command realcommand = (Command)Assembly.Load("Command").CreateInstance(command);
            button.Command = realcommand;
            button.ButtonClick();

            Console.ReadKey();
        }
    }
}
