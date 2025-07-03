
namespace MenuLibrary;

public class Menu : IItem
{
    private Dictionary<char, IItem> Items { get; }
    public string Label { get; }

    public Menu(string label)
    {
        Items = [];
        Label = label;
    }

    public void Start()
    {
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.Clear();
            DrawMenu();
            string? choice = Console.ReadLine();

            if (!char.TryParse(choice, out char key) || char.IsDigit(key))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Le choix <{choice}> n'est pas une lettre");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(1000);
            }
            else if (!Items.TryGetValue(key, out var item))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Le choix <{key}> n'existe pas !");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(1000);
            }
            else if (key == Items.Last().Key)
            {
                exitProgram = true;
            }
            else
            {
                Console.Clear();
                item.Start();
            }
        }
    }

    public void AddItem(char key, IItem item)
    {
        Items.Add(key, item);
    }

    private void DrawMenu()
    {
        Console.WriteLine("=================");
        Console.WriteLine(Label.ToUpper());
        Console.WriteLine("=================");

        AddQuitItem();

        foreach (KeyValuePair<char, IItem> entry in Items)
        {
            Console.WriteLine($"{entry.Key}. {entry.Value}");
        }
    }

    private void AddQuitItem()
    {
        KeyValuePair<char, IItem> lastEntry = Items.Last();

        if (!lastEntry.Value.Equals(new Item("Quitter")))
        {
            int letterInAscii = lastEntry.Key;
            letterInAscii++;
            AddItem((char)letterInAscii, new Item("Quitter"));
        }
    }

    public override string ToString()
    {
        return Label;
    }
}
