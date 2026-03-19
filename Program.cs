// See https://aka.ms/new-console-template for more information
//welcome
//1.add task 
//2.view all tasks
//3.mark task compelete
//4.remove task
//5.exite
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Java;

Console.WriteLine("hello, we hope you are fine");
Console.WriteLine("WELCOME TO OUR TASK TRACKER");
Console.WriteLine("1.ADD");
Console.WriteLine("2.VIEW");
Console.WriteLine("3.MARK");
Console.WriteLine("4.REMOVE");
Console.WriteLine("5.EXITE");
String[] tasks = new string[100];
int taskNum = 0;
while (true)
{
    String task = Console.ReadLine();
    switch (task.ToLower())
    {
        case "add":
            AddTask();
            break;
        case "view":
            ViewTasks();
            break;
        case "mark":
            markTasks();
            break;
        case "remove":
            RemoveTask();
            Console.WriteLine($"the number of tasks become {taskNum} ");
            break;
        case "exite":
            Environment.Exit(0);
            break;

    }
}
void AddTask()
{
    Console.WriteLine("PLEASE ENTER THE TASK THAT YOU WANT");
    String t = Console.ReadLine();
    tasks[taskNum] = t;
    taskNum++;
    Console.WriteLine("TASK IS ADDED");
}
void ViewTasks()
{
    for(int i = 0; i < taskNum; i++)
    {
        Console.WriteLine($"the task num{i + 1}.{tasks[i]}");
    }
}
void markTasks()
{
    Console.WriteLine("please enter the name of the task that you are completed:");
    String compTask = Console.ReadLine();
    for(int i = 0; i < taskNum; i++)
    {
        if (tasks[i] == compTask)
        {
            Console.WriteLine($"{compTask}is compeleted");
            break;
        }
    }
}

//1 2 3 4 5   2
void RemoveTask()
{
    Console.WriteLine("please enter the task that you want to remove:");
    String RemovedTask = Console.ReadLine();
    for (int i = 0; i < taskNum; i++)
    {
        if (tasks[i] == RemovedTask)
        {

            for (int j = i; j < taskNum-1; j++)
            {
                tasks[j] = tasks[j + 1];
            }
        }
    }
    taskNum--;
    Console.WriteLine("TASK IS REMOVED");
}
