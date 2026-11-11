var tasks = new List<string>();

while (true)
{
    Console.WriteLine("\n1. List tasks\n2. Add task\n3. Remove task\n4. Quit");
    Console.Write("Choose: ");
    string? choice = Console.ReadLine()?.Trim();

    if (choice == "1")
    {
        if (tasks.Count == 0) Console.WriteLine("No tasks yet.");
        for (int i = 0; i < tasks.Count; i++) Console.WriteLine($"{i + 1}. {tasks[i]}");
    }
    else if (choice == "2")
    {
        Console.Write("Task: ");
        string? task = Console.ReadLine()?.Trim();
        if (!string.IsNullOrEmpty(task)) tasks.Add(task);
    }
    else if (choice == "3")
    {
        Console.Write("Task number: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= tasks.Count)
            tasks.RemoveAt(number - 1);
        else
            Console.WriteLine("Invalid task number.");
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Choose 1, 2, 3, or 4.");
    }
}
