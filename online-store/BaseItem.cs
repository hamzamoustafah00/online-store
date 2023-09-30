namespace online_store;
public class BaseItem
{
    public string Title { get; set; }
    public double Price { get; set; }
}

public class Book : BaseItem
{
    public string Author { get; set; }
}

public class Shirt : BaseItem
{
    public string Size { get; set; }
}

public class Computer : BaseItem
{
    public string Type { get; set; }
}