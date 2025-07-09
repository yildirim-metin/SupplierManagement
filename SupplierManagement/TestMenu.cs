using MenuLibrary;

namespace SupplierManagement;

internal static class TestMenu
{
    internal static void Test()
    {
        IItem episode1 = new Item("Episode 1");
        Console.WriteLine(episode1.Label);

        Menu mainMenu = new("Menu principale");

        IAction action = new ActionTest();
        if (episode1 is Item itemTest)
        {
            itemTest.Action = action;
            itemTest.Start();

            mainMenu.AddItem('a', itemTest);
        }

        Item episode2 = new("Episode 2");
        Item episode3 = new("Episode 3");
        Item episode4 = new("Episode 4");

        Menu secondMenu = new("Menu secondaire");
        secondMenu.AddItem('a', episode1);
        secondMenu.AddItem('b', episode2);

        mainMenu.AddItem('b', episode2);
        mainMenu.AddItem('c', episode3);
        mainMenu.AddItem('d', episode4);
        mainMenu.AddItem('e', secondMenu);

        mainMenu.Start();

        Menu menu = new MenuBuilder("test")
            .Item('a', "test 1", action)
            .Menu('b', new MenuBuilder("test 2").Item('a', "test 2.1", action).Build())
            .Item('c', "test 3", action)
            .Build();

        menu.Start();
    }
}
