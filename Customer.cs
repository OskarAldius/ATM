namespace WestcoastBank;

public class Customer
{
    // get betyder att du kan läsa värdet.
    // set betyder att du kan ändra värdet.
    public Customer(string id)
    {
        FindCustomer(id);
    }
 public  string? FirstName { get; private set; } // -- detta är een property/ egnekskap
    public  string? LastName { get; private set; }
    public  string?  Email { get; set; }
    public  string? Phone {get; set;}
    List<Adress> ?Adresses {get;set;}

    public void UpdateCustomer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    private void FindCustomer(string id)
    {
        FirstName = "Michael";
        LastName = "Gustavsson";
        Email = "michael@mail.com";
        Phone = "009230292";
    }
}
