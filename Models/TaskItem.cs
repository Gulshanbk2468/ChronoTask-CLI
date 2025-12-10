using System;

namespace SmartAlarmSystem.Models
{
    public class TaskItem
    {
        public int Id { get; set; }                // Task number
        public string Title { get; set; }          // Task name
        public string Category { get; set; }       // Study/Work/Personal
        public string Priority { get; set; }       // High/Medium/Low
        public DateTime Time { get; set; }         // Alarm time
        public bool IsCompleted { get; set; }      // Completed status
        public bool IsRecurring { get; set; }      // True = daily/weekly, False = one-time

        // Function to input task data from user
        public void InputTaskData(int id)
        {
            Id = id;                                // Assign task number

            Console.Write("Enter Title: ");
            Title = Console.ReadLine();

            Console.Write("Enter Category (Study/Work/Personal): ");
            Category = Console.ReadLine();

            Console.Write("Enter Priority (High/Medium/Low): ");
            Priority = Console.ReadLine();

            Console.Write("Enter Time (HH:mm): ");
            string timeInput = Console.ReadLine();
            Time = DateTime.Today.Add(TimeSpan.Parse(timeInput)); // Convert input to DateTime

            Console.Write("Is this task recurring? (yes/no): ");
            IsRecurring = Console.ReadLine().Trim().ToLower() == "yes";

            IsCompleted = false; // default value
        }

        // Display task in a single line
        public override string ToString()
        {
            return $"{Id}. {Title} | {Category} | {Priority} | {Time:HH:mm} | Done: {IsCompleted} | Recurring: {IsRecurring}";
        }
    }
}
