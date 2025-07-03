namespace MenuLibrary;

public class MenuBuilder
{
    private readonly Menu _menu;

    public MenuBuilder(string menuLabel)
    {
        _menu = new Menu(menuLabel);
    }

    public MenuBuilder Item(char key, string label, IAction action)
    {
        _menu.AddItem(key, new Item(label, action));
        return this;
    }

    public MenuBuilder Menu(char key, Menu menu)
    {
        _menu.AddItem(key, menu);
        return this;
    }

    public Menu Build()
    {
        return _menu;
    }
}
