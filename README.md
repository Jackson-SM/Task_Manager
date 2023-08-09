# Gerenciador de Tarefas em CSharp

## Introdução

Este é um projeto de um gerenciador de tarefas desenvolvido em C# para fins de prática e estudos. O programa permite a criação, listagem, atualização e exclusão de tarefas, sem a necessidade de um banco de dados. As informações são armazenadas temporariamente na memória durante a execução do programa. Continue lendo para aprender como usar e entender o funcionamento do projeto.

## Funcionalidades

O gerenciador de tarefas possui as seguintes funcionalidades:

1. **Criar uma Task:** Permite criar uma nova tarefa, informando título e descrição.

2. **Listar todas as tasks:** Exibe todas as tarefas criadas, mostrando seus títulos.

3. **Listar uma Task:** Mostra os detalhes de uma tarefa específica, incluindo título e descrição.

4. **Fazer update de uma Task:** Atualiza o título e/ou a descrição de uma tarefa existente.

5. **Deletar uma Task:** Remove uma tarefa da lista.

6. **Sair:** Encerra a execução do programa.

## Como Utilizar

1. Execute o programa.

2. Um menu será exibido com as opções listadas acima.

3. Escolha a opção desejada digitando o número correspondente e pressionando Enter.

4. Siga as instruções fornecidas pelo programa para realizar a ação escolhida.

## Entidade (Entity) - Task

A entidade `Task` representa uma tarefa e possui as seguintes propriedades:

- **Id:** Identificador único da tarefa.
- **Title:** Título da tarefa.
- **Description:** Descrição da tarefa.

## Repositório (Repositories) - TaskRepository

O repositório `TaskRepository` define um contrato para as funções que manipulam as tarefas:

- `Task GetTaskById(int id)`: Retorna a tarefa correspondente ao ID informado.
- `void CreateTask(Task task)`: Cria uma nova tarefa.
- `void UpdateTask(Task task)`: Atualiza os dados de uma tarefa existente.
- `void DeleteTask(int id)`: Remove uma tarefa.

## Serviço (Services) - TaskService

O serviço `TaskService` implementa as operações definidas pelo contrato do `TaskRepository`:

- `void Create(string title, string description)`: Cria uma nova tarefa com o título e descrição informados.
- `Tasks GetById(int id)`: Retorna a tarefa correspondente ao ID informado.
- `void Update(int id, string newTitle, string newDescription)`: Atualiza os dados da tarefa com o novo título e/ou descrição.
- `void Delete(int id)`: Remove a tarefa correspondente ao ID informado.
- `void ToListTasks()`: Remove a tarefa correspondente ao ID informado.

## Considerações Finais

Este projeto de gerenciador de tarefas em C# oferece uma maneira prática de praticar e estudar os conceitos da linguagem, bem como a estruturação de entidades, repositórios e serviços. Lembre-se de que as tarefas criadas são armazenadas apenas na memória e serão perdidas ao fechar o programa.

Sinta-se à vontade para explorar e modificar o projeto conforme necessário para aprimorar suas habilidades em C#. Se tiver dúvidas ou precisar de assistência adicional, consulte a documentação do C# e recursos online relacionados ao desenvolvimento de aplicativos.