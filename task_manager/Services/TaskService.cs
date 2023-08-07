using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task_manager.Entity;
using task_manager.Repositories;

namespace task_manager.Services
{
    internal class TaskService : TaskRepository
    {
        public static List<Tasks> TaskList { get; set; } = new List<Tasks>();

        public TaskService() { }

        public void Create(string title, string description)
        {
            int idGenerated = TaskList[TaskList.Count - 1].Id;
            Tasks task = new Tasks(idGenerated, title, description);
            TaskList.Add(task);
        }

        public void Update(Tasks task)
        {
            Tasks taskSearching = TaskList.Find(tasks => tasks.Id.Equals(task.Id));
            if (taskSearching == null) {
                Console.WriteLine($"Erro: o Id {task.Id} não existe na lista!");
            }
            Console.WriteLine(taskSearching);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void ToListTasks()
        {
            TaskList.ForEach(task => {
                Console.WriteLine(task);
            });
        }
    }
}
