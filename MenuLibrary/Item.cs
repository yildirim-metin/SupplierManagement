namespace MenuLibrary;

public class Item : IItem
{
    public string Label { get; }

    public IAction? Action { private get; set; }

    public Item(string label)
    {
        Label = label;
    }

    public Item(string label, IAction action)
    {
        Label = label;
        Action = action;
    }

    public void Start()
    {
        Action?.Execute();
    }
}
