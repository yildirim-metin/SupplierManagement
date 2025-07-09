using MenuLibrary;

namespace SupplierManagement;

class AddSupplierAction : IAction
{
    private readonly SupplierList _supplierList;

    public AddSupplierAction(SupplierList supplierList)
    {
        _supplierList = supplierList;
    }

    public void Execute()
    {
        Console.Write("Entrer le nom du fournisseur : ");
        string? supplierName = Console.ReadLine();

        while (string.IsNullOrEmpty(supplierName))
        {
            Console.Write("Entrer le nom du fournisseur : ");
            supplierName = Console.ReadLine();
        }

        Console.Write("Entrer le numéro de téléphone du fournisseur : ");
        string? phoneNumber = Console.ReadLine();

        while (string.IsNullOrEmpty(phoneNumber))
        {
            Console.Write("Entrer le numéro de téléphone du fournisseur : ");
            phoneNumber = Console.ReadLine();
        }

        Console.Write("Entrer l'email du fournisseur : ");
        string? email = Console.ReadLine();

        while (string.IsNullOrEmpty(email))
        {
            Console.Write("Entrer l'email du fournisseur : ");
            email = Console.ReadLine();
        }

        int id = ++SupplierList.nextIdSupplier;
        Supplier supplier = new(id, supplierName, phoneNumber, email);

        _supplierList.AddSupplier(supplier);
    }
}
