using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager.Entity;

namespace task_manager.Repositories
{
    internal interface TaskRepository
    {
        public void Create(string title, string description);
        public void ToListTasks();
        public void Update(Tasks task);
        public void Delete(int id);
        public void GetById(int id);
    }
}
