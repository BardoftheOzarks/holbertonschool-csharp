using System;
using System.IO;
using System.Text.Json;

///<summary>JSON storage engine</summary>
class JSONStorage
{
    public Dictionary<string, dynamic> objects;

    ///<summary>Returns all objects</summary>
    public Dictionary<string, dynamic> All()
    {
        return objects;
    }

    ///<summary>Adds an object to dictionary</summary>
    public void New(BaseClass obj)
    {
        string key;
        if (obj == null)
            return;
        key = String.Format($"{obj.GetType()}.{obj.id}");
        this.objects.Add(key, obj);
    }

    ///<summary>Saves objects dict to json file</summary>
    public void Save()
    {
        string zombie = JsonSerializer.Serialize(this.objects);
        File.WriteAllText("storage/inventory_manager.json", zombie);
    }

    ///<summary>Loads objects from a json file</summary>
    public void Load()
    {
        Dictionary<string, dynamic> BookOfTheDead = new Dictionary<string, dynamic>();
        if (Directory.Exists("storage") && File.Exists("storage/inventory_manager.json"))
        {
            BookOfTheDead = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(File.ReadAllText("storage/inventory_manager.json"));
            this.objects = BookOfTheDead;
        }
    }
}