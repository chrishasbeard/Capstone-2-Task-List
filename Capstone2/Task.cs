using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone2
{
    class Task
    {
        private static List<Task> _tasks = new List<Task>
        {
            new Task ("Jack", "Does the work", DateTime.Parse("10/25/2019")),
            new Task ("Tristan", "Stares Blankly", DateTime.Parse("10/24/2019")),
            new Task ("Steve", "Does nothing", DateTime.Parse("10/25/2019"))
        };
        #region fields
        //fields
        private string _name;
        private string _description;
        private DateTime _dueDate;
        private bool _complete;
        #endregion

        #region properties
        //properties per andy's say so
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }
        public bool Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }

        #endregion
      

        public Task() { }

        public Task(string name, string description, DateTime dueDate, bool complete = false)
        {
            Name = name;
            Description = description;
            DueDate = dueDate;
            Complete = complete;
        }
        public static void DisplayTask()
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
               
                Console.WriteLine($"\t{i + 1}: {_tasks[i].Name}");
                Console.WriteLine($"\tWhich does: {_tasks[i].Description}");
                Console.WriteLine($"\tWhich is due: {_tasks[i].DueDate}");
                Console.WriteLine($"\tCompleted?: {_tasks[i].Complete}\n");

            }
        }

        public static void CompleteTask(int userInput)
        {
            _tasks[userInput - 1].Complete = true;
        }

        public static void DeleteTask(int userInput)
        {
            _tasks.RemoveAt(userInput-1);
        }


        public static void AddTask(Task task)
        {
            _tasks.Add(task);
        }

    }
}
