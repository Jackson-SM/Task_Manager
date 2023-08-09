using task_manager.Entity;
using System.Collections.Generic;
using task_manager.Services;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {

            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("(1) -> Criar uma Task:");
            Console.WriteLine("(2) -> Listar todas as tasks:");
            Console.WriteLine("(3) -> Listar uma Task:");
            Console.WriteLine("(4) -> Fazer update de uma Task:");
            Console.WriteLine("(5) -> Deletar uma Task:");
            Console.WriteLine("(6) -> Sair");

            int optionSelected = int.Parse(Console.ReadLine());

            TaskService taskService = new TaskService();

            switch (optionSelected)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Digite o título da task: ");

                    String title = Console.ReadLine();

                    Console.Write("Digite a descrição: ");

                    String description = Console.ReadLine();
                    taskService.Create(title, description);
                    break;
                case 2:
                    Console.Clear();

                    taskService.ToListTasks();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Id da Task: ");
                    int _ = int.Parse(Console.ReadLine());
                    Tasks task = taskService.GetById(_);
                    Console.WriteLine(task);
                    break;
                case 4:
                    Console.Clear();

                    Console.Write("Digite o ID da Task: ");
                    _ = int.Parse(Console.ReadLine());
                    Console.Write("Digite o novo Título: ");
                    String titleUpdate = Console.ReadLine();
                    Console.Write("Digite a nova descrição: ");
                    String descriptionUpdate = Console.ReadLine();


                    taskService.Update(_, titleUpdate, descriptionUpdate);
                    break;
                case 5:
                    Console.Clear();

                    Console.Write("Digite o ID da Task: ");
                    int idDelete = int.Parse(Console.ReadLine());

                    taskService.Delete(idDelete);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}