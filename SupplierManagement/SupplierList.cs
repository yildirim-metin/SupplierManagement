namespace SupplierManagement;

class SupplierList
{
    public static int nextIdSupplier = 0;

    private readonly List<Supplier> _suppliers;
    
    public SupplierList()
    {
        _suppliers = [];
    }

    public void AddSupplier(Supplier supplier)
    {
        _suppliers.Add(supplier);
    }

    public List<Supplier> GetSuppliers()
    {
        return _suppliers;
    }
}
