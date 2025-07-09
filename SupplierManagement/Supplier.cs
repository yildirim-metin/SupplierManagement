namespace SupplierManagement;

class Supplier
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public bool HasOrder { get; set; }

    public Supplier(int id, string name, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        HasOrder = false;
    }
}
