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
                    break;
                case 4:
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}