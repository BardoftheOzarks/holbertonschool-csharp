using System;

///<summary>A type of BaseClass</summary>
class Item : BaseClass
{
    public string name { get; set; }
    public string description;
    public float price;
    public List<string> tags;

    public Item(string name, string description = null, float price = 0, List<string> tags = null)
    {
        this.name = name;
        this.description = description;
        if (price != 0)
            this.price = (float)Math.Round(price, 2);
        this.tags = tags;
    }
}