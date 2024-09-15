using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            ShowProcesses();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. End Task");
            Console.WriteLine("2. New Task");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                EndTask();
            }
            else if (choice == "2")
            {
                StartNewTask();
            }
            else if (choice == "3")
            {
                break;
            }
        }
    }

    static void ShowProcesses()
    {
        Process[] processes = Process.GetProcesses();
        Console.WriteLine("ID  Process Name");
        Console.WriteLine("----------------");
        foreach (Process process in processes)
        {
            Console.WriteLine(process.Id + " " + process.ProcessName);
        }
    }

    static void EndTask()
    {
        Console.Write("Enter the ID of the process to kill: ");
        int processId = int.Parse(Console.ReadLine());
        Process process = Process.GetProcessById(processId);
        process.Kill();
        Console.WriteLine("Process " + processId + " has been killed.");
    }

    static void StartNewTask()
    {
        Console.Write("Enter the name of the process to start : ");
        string processName = Console.ReadLine();
        Process.Start(processName);
        Console.WriteLine(processName + " has been started.");
    }
}
