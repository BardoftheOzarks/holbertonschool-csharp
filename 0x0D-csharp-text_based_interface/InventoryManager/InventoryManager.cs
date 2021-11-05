using System;
using InventoryLibrary;

class InventoryManager
{
    public Dictionary<string, BaseClass> objects;
    public Dictionary<string, Type> classes = new Dictionary<string, Type>{
        {"baseclass", typeof(BaseClass)},
        {"user", typeof(User)},
        {"item", typeof(Item)},
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
                    if (args.Length == 3)
                        Show(args[1], args[2]);
                    else
                        Console.WriteLine("Usage: Show <ClassName> <id>");
                    return;
                case "update":
                    if (args.Length == 4)
                        Update(args[1], args[2], args[3]);
                    else
                        Console.WriteLine("Usage: Update <ClassName> <id> <update>");
                    return;
                case "delete":
                    Delete(args[1], args[2]);
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

    public void Create(string ClassName, string name)
    {
        if (classes.ContainsKey(ClassName))
        {
            switch (ClassName)
            {
                case "item":
                    storage.New(new Item(name));
                case "user":
                    storage.New(new User(name));
                case "baseclass":
                    storage.New(new BaseClass(name));
            }
        } else {
            Console.WriteLine($"{ClassName} is not a valid object");
        }
    }

    public void Show(string ClassName, string id)
    {
        if (classes.ContainsKey(ClassName))
        {
            foreach (string key in objects.Keys)
            {
                if (key.Split('.')[1].ToLower() == ClassName && key.Split('.')[2] == id)
                    Console.WriteLine(objects[key].ToString());
            }
        } else {
            Console.WriteLine($"{ClassName} is not a valid object class");
        }
    }

    public void Update(string ClassName, string id, string update)
    {
        if (classes.ContainsKey(ClassName))
        {
            foreach (string key in objects.Keys)
            {
                if (key.Split('.')[1].ToLower() == ClassName && key.Split('.')[2] == id)
                {
                    objects[key].name = update;
                }
            }
        } else {
            Console.WriteLine($"{ClassName} is not a valid object class");
        }
    }
    public Delete(string ClassName, string id)
    {
        if (classes.ContainsKey(ClassName))
        {
            foreach (string key in objects.Keys)
            {
                if (key.Split('.')[1].ToLower() == ClassName && key.Split('.')[2] == id)
                {
                    objects.Remove(key);
                    objects.Save();
                }
            }
        } else {
            Console.WriteLine($"{ClassName} is not a valid object class");
        }
    }
    
    public void Exit()
    {
        System.Environment.Exit(1);
    }
}
