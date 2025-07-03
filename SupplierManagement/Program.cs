using MenuLibrary;

Console.WriteLine("Supplier management");

IItem item = new Item("item1");
Console.WriteLine(item.Label);

IAction action = new ActionTest();
if (item is Item itemTest)
{
    itemTest.Action = action;
    itemTest.Start();
}