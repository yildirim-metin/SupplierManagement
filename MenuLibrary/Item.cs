namespace MenuLibrary;

public class Item : IItem
{
    public string Label { get; }

    public Item(string label)
    {
        Label = label;
    }
}
