using CommandMapper.Core.Services;
using ConsoleApp6.Commands;
using System;

namespace ConsoleApp6;
public static class Program 
{
    public static void Main(params string[] args) 
    {
        CommandManager manager = new CommandManager();
        manager.Register(new ConvertImageCommand());

        manager.Execute(args);

        Console.WriteLine("Fin de la ejecución");
        Console.ReadKey();
    }
}