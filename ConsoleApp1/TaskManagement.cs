using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Exercise
{
    public class TaskManagement
    {
        private List<(int id, string title, DateTime dueDate, TaskStatus status)> _tasks;

        public TaskManagement()
        {
            _tasks = new List<(int, string, DateTime, TaskStatus)>();
        }

        public void AddTask(int id, string title, DateTime dueDate, TaskStatus status)
        {
            _tasks.Add((id, title, dueDate, status));
        }

        public int TaskCount()
        {
            return _tasks.Count();
        }

        public bool ChangeTaskStatus(int id, TaskStatus status)
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].id == id)
                {
                    var task = _tasks[i];
                    _tasks[i] = (task.id, task.title, task.dueDate, status);
                    return true;
                }
            }

            return false;
        }

        // Returning back a tuple. (Lesson: Tuples)
        public (int id, string title, DateTime dueDate, TaskStatus status)? FindTaskById(int id)
        {
            return _tasks.Any(task => task.id == id) ? _tasks.First(task => task.id == id) : null;
        }

        // Using LINQ to get tasks due today or find them by their ID. (Lesson: LINQ Introduction)
        public List<(int id, string title, DateTime dueDate, TaskStatus status)> GetTasksDueToday()
        {
            return _tasks.Where(task => task.dueDate.Date == DateTime.Now.Date).OrderBy(task => task.dueDate).ToList();
        }
    }
}
