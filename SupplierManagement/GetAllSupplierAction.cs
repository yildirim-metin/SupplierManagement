using MenuLibrary;

namespace SupplierManagement;

class GetAllSupplierAction : IAction
{
    public SupplierList SupplierList { get; }

    public GetAllSupplierAction(SupplierList supplierList)
    {
        SupplierList = supplierList;
    }

    public void Execute()
    {
        Console.WriteLine("Voici la liste des fournisseurs : ");

        foreach (Supplier supplier in SupplierList.GetSuppliers())
        {
            Console.WriteLine(supplier);
        }

        Console.Write("Appuyer sur une touche pour revenir au menu principale...");
        Console.ReadKey();
    }
}
