using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager.Repositories;

namespace task_manager.Entity
{
    internal class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Tasks(int id, string title, string description) 
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public override string? ToString() => $"\n\n\n\n\n=================================\nId: {Id}\nName: {Title}\nDescription: {Description}\n=================================\n\n\n\n\n";
    }
}
