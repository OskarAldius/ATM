namespace WestcoastBank;

enum TransactionTyoeEnum
{
    Insättning,

    Uttag
}
class Account(string accountNO) // Konstruktorn är flyttad sim ett arguemnt
{
    // Autoimpemnted Properties
    public int Balance{get; private set;}
    public string AccountNumber { get; } = accountNO;
    public string? FirstName { get; set; } 
    public string? LastName { get; set; }
    public List<Transaction> Transactions { get; } =[];

    public void Deposit(int amount)
    {
        Balance+=amount;

        AddTransaction(amount, TransactionTyoeEnum.Insättning);
        
    }

    public void Withdraw(int amount)
    {
        if(Balance < amount)
        {
            throw new Exception("Du har inte tillräkligt på kontot");
        }
          Balance -= amount;
          AddTransaction(amount, TransactionTyoeEnum.Uttag);
         
    }
    private void AddTransaction(int amount,TransactionTyoeEnum type)
    {
        Transaction tran = new()
        {
           
            TransactionAmount =amount,
            TransactionType = type 
    
        };

        
        Transactions.Add(tran);

    }

}

class Transaction
{

    public DateTime TransactionDate{get;} = DateTime.Now;
    public TransactionTyoeEnum TransactionType{get;set;}
    public int TransactionAmount{get;set;}

    public override string ToString()
    {
        return $"Transaktionsdatum: {TransactionDate} - Transaktionstyp: {TransactionType} - Belopp: {TransactionAmount}";
    }

}
