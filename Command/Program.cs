using System.Reflection;
using System.Configuration;
using System;

namespace Command
{
    class Program
    {
        //命令模式 一个对象维护一个命令，一个命令维护一个具体功能，对象可触发命令来执行具体功能
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
