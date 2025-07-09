using MenuLibrary;
using SupplierManagement;

Console.WriteLine("Supplier management");

SupplierList supplierList = new();

Menu menuSupplier = new MenuBuilder("MENU PRINCIPALE")
    .Item('a', "Ajouter un fournisseur", new AddSupplierAction(supplierList))
    .Build();

menuSupplier.Start();