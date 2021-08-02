using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>Host class to test objects</summary>
class Obj
{
    /// <summary>Method to print names of properties and methods of an object</summary>
    public static void Print(object myObj)
    {
        var type = myObj.GetType();
        Console.WriteLine($"{type.GetTypeInfo().Name} Properties:");
        foreach (var obj in type.GetProperties())
        {
            Console.WriteLine(obj.Name);
        }
        Console.WriteLine($"{type.GetTypeInfo().Name} Methods:");
        foreach (var obj in type.GetMethods())
        {
            Console.WriteLine(obj.Name);
        }
    }
}