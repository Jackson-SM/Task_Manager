using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int idGenerated = TaskList.Count < 1 ? TaskList.Count : TaskList[TaskList.Count - 1].Id + 1;
            Tasks task = new Tasks(idGenerated, title, description);
            TaskList.Add(task);
        }

        public void Update(int id,string title, string description)
        {
            Tasks taskSearchingIndexOf = this.GetById(id);

            int indexOfTask = TaskList.FindIndex(task => task.Id.Equals(taskSearchingIndexOf.Id));

            TaskList[indexOfTask].Title = title.Trim().Length <= 0 ? TaskList[indexOfTask].Title : title;
            TaskList[indexOfTask].Description = description.Trim().Length <= 0 ? TaskList[indexOfTask].Description : description;
        }

        public void Delete(int id)
        {
            Tasks taskForId = this.GetById(id);
            bool taskIndexOf = TaskList.Remove(taskForId);

            if(!taskIndexOf)
            {
                throw new Exception("Não foi possível remover a task selecionada.");
            }

        }

        public Tasks GetById(int id)
        {
            Tasks taskSearching = TaskList.Find(tasks => tasks.Id.Equals(id));
            if (taskSearching == null)
            {
                throw new Exception("Não foi possível encontrar a task selecionada.");
            }

            return taskSearching;
        }

        public void ToListTasks()
        {
            if(TaskList.Count < 1)
            {
                Console.WriteLine("<============================= Não possui Tasks =============================>");
                return;
            }

            TaskList.ForEach(task => {
                Console.WriteLine(task);
            });
        }
    }
}
