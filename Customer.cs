namespace WestcoastBank;

public class Customer
{
    // get betyder att du kan läsa värdet.
    // set betyder att du kan ändra värdet.
 public required string FirstName { get; set; } // -- detta är een property/ egnekskap
    public required string LastName { get; set; }
    public  string?  Email { get; set; }
    public  string? Phone {get; set;}
    List<Adress> ?Adresses {get;set;}
}
