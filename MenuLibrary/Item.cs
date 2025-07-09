namespace MenuLibrary;

public class Item : IItem
{
    public string Label { get; }

    public IAction Action { private get; set; }

    public Item(string label, IAction action)
    {
        Label = label;
        Action = action;
    }

    public void Start()
    {
        Action.Execute();
    }

    public override string ToString()
    {
        return Label;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }
        
        if (obj is not Item other)
        {
            return false;
        }

        return Label == other.Label;
    }

    public override int GetHashCode()
    {
        return Label?.GetHashCode() ?? 0;
    }
}
