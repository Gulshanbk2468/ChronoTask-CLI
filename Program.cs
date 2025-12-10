using System;
using System.Collections.Generic;
using SmartAlarmSystem.Models;

class Program
{
    static void Main()
    {
        List<TaskItem> tasks = new List<TaskItem>();

        Console.Write("How many tasks do you want to add? ");
        int taskCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine($"\nTask {i + 1}:");
            TaskItem task = new TaskItem();

            // Call the function from TaskItem.cs
            task.InputTaskData(i + 1);

            tasks.Add(task);
        }

        Console.WriteLine("\nAll Tasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }

        Console.WriteLine("\nEnter task number to mark as completed: ");
        int doneTaskId = int.Parse(Console.ReadLine());

        TaskItem completedTask = tasks.Find(t => t.Id == doneTaskId);
        if (completedTask != null)
        {
            completedTask.IsCompleted = true;
            Console.WriteLine("Task updated:");
            Console.WriteLine(completedTask);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
