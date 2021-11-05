using System;
using InventoryLibrary;

class InventoryManager
{
    public Dictionary<string, BaseClass> objects;
    public Dictionary<string, Type> classes = new Dictionary<string, Type>{
        {"baseclass", typeof(BaseClass)},
        {"user", typeof(User)},
        {"item", typeof(Item)},
        {"inventory", typeof(Inventory)}
    };
    string prompt = "Inventory Manager\n-------------------------\n<ClassNames> show all ClassNames of objects\n<All> show all objects\n<All [ClassName]> show all objects of a ClassName\n<Create [ClassName]> a new object\n<Show [ClassName object_id]> an object\n<Update [ClassName object_id]> an object\n<Delete [ClassName object_id]> an object\n<Exit>\n";

    public JSONStorage storage;

    public InventoryManager()
    {
        this.storage = new JSONStorage();
        try
        {
            storage.Load();
            this.objects = storage.objects;
        }
        catch
        {
            this.objects = null;
        }
    }

    static void Main(string[] args)
    {
        JSONStorage storage = new JSONStorage();
        
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().ToLower();
            string[] args = input.Split(' ');
            switch (args[0])
            {
                case "classnames":
                    foreach (KeyValuePair<string, Type> pair in classes)
                    {
                        Console.WriteLine(pair.Key);
                    }
                    return;
                case "all":
                    if (args.Length > 1)
                        All(args[1]);
                    else
                        All();
                    return;
                case "create":
                    if (args.Length == 3)
                        Create(args[1], args[2]);
                    else
                        Console.WriteLine("Usage: Create <ClassName> <id>");
                    return;
                case "show":
                    Show(args, storage);
                    return;
                case "update":
                    Update(args, storage);
                    return;
                case "delete":
                    Delete(args, storage);
                    return;
                case "exit":
                    Exit();
            }
        }
    }
    public void All(string name = null)
    {
        if (name == null)
        {
            foreach (string key in objects.Keys)
            {
                Console.WriteLine($"{key.Split('.')[1]}: {key.Split('.')[2]}");
            }
        } else if (classes.ContainsKey(name)) {
            foreach (string key in objects.Keys)
            {
                if (key.Split('.')[1].ToLower() == name)
                    Console.WriteLine($"{key.Split('.')[1]}: {key.Split('.')[2]}");
            }
        } else {
            Console.WriteLine($"{name} is not a valid object type");
        }
    }

    public void Create(string name)
    {
        if (classes.ContainsKey(name))
        {
            switch (name)
            {
                case "item":

            }
        } else {
            Console.WriteLine($"{name} is not a valid object");
        }
    }
}
