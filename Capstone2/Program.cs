using System;

namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                PrintOptions();
                string userInput = GetUserInput("Please choose one of the 5 options: ");
                SelectMenuOption(userInput);
            }
        }
        public static void CreateTask()
        {
            Task task = new Task();
            task.Name = GetUserInput("Enter Name:");
            task.Description = GetUserInput("Enter Decription: ");
            task.DueDate = ValiDate("Enter Due Date: ");

            Task.AddTask(task);
      
            Task.DisplayTask();
        }
        public static DateTime ValiDate(string message)
        {
            try
            {
                return DateTime.Parse(GetUserInput(message));
            }
            catch
            {
                Console.WriteLine("That isn't a valid input.");
                return ValiDate(message);
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void PrintOptions()
        {
            Console.WriteLine("1. List Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Mark task complete");
            Console.WriteLine("5. Quit");
        }

        public static void SelectMenuOption(string userInput)
        {
            switch (userInput)
            {
                case "1":
                case "list":
                    Task.DisplayTask();
                    break;

                case "add task":
                case "2":
                case "add":
                    CreateTask();
                    break;

                case "3":
                case "delete task":
                    RemoveTask();
                    break;

                case "4":
                case "mark task complete":
                    MarkComplete();
                    break;

                case "5":
                case "quit":
                    Console.WriteLine("\n\n\t\tLater, N E R D !!!!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\n\tGet Good, and try again when amateur hour is over.\n");

                    break;
            }
        }
        public static void RemoveTask()
        {
            string userInput = GetUserInput("Enter A Task Number to Remove.");
            int input = int.Parse(userInput);

            Task.DeleteTask(input);
            Console.Clear();

        }
        public static void MarkComplete()
        {
            int userInput = 0;
            Task.DisplayTask();
            try
            {
                userInput = int.Parse(GetUserInput("Select Task Number to Complete: "));
            }
            catch (FormatException)
            {
                MarkComplete();
            }

            Task.CompleteTask(userInput);
            Task.DisplayTask();
        }
    }
}
