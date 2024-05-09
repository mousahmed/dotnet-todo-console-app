Console.WriteLine("Hello!");
var todos = new List<string>();

void PrintOptions()
{
  Console.WriteLine("What do you want to do?");
  Console.WriteLine("[S]ee all TODOs");
  Console.WriteLine("[A]dd a new TODO");
  Console.WriteLine("[R]emove a TODO");
  Console.WriteLine("[E]xit");
}

void PrintEmpty()
{
  Console.WriteLine("You have no TODOs!");

}

void PrintTodos()
{

  if (todos.Count == 0)
  {
    PrintEmpty();
    return;
  }

  for (var i = 0; i < todos.Count; i++)
  {
    Console.WriteLine($"{i + 1}. {todos[i]}");
  }
}

bool IsTodoNotUnique(string newTodo)
{
  return todos.Contains(newTodo);
}
bool IsInputEmpty(string input)
{
  return string.IsNullOrEmpty(input);
}

void PrintAddTodo()
{
  Console.WriteLine("Enter the TODO description.");
}
void AddTodo()
{
  do
  {
    PrintAddTodo();
    var newTodo = Console.ReadLine();
    if (IsInputEmpty(newTodo))
    {
      Console.WriteLine("The description cannot be empty.");
    }
    else if (IsTodoNotUnique(newTodo))
    {
      Console.WriteLine("The description must be unique.");
    }
    else
    {
      todos.Add(newTodo);
      Console.WriteLine($"TODO successfully added: {newTodo}");
      break;
    }
  } while (true);
}

void RemoveTodo()
{
  if (todos.Count == 0)
  {
    PrintEmpty();
    return;
  }

  do
  {
    Console.WriteLine("Select the index of the TODO you want to remove:");
    PrintTodos();
    var index = Console.ReadLine();
    if (int.TryParse(index, out int i) && i > 0 && i <= todos.Count)
    {
      Console.WriteLine($"TODO removed: {todos[i - 1]}");
      todos.RemoveAt(i - 1);
      break;
    }
    else if (IsInputEmpty(index))
    {
      Console.WriteLine("Selected index cannot be empty.");
    }
    else
    {
      Console.WriteLine("Invalid TODO number. Please try again.");
    }
  } while (true);

}

string option;
do
{

  Console.WriteLine();
  PrintOptions();
  option = Console.ReadLine().ToUpper();

  switch (option)
  {
    case "S":
      PrintTodos();
      break;
    case "A":
      AddTodo();
      break;
    case "R":
      RemoveTodo();
      break;
    case "E":
      Console.WriteLine("Goodbye!");
      break;
    default:
      Console.WriteLine("Invalid option");
      break;
  }

} while (option != "E");
