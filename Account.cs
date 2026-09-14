namespace WestcoastBank;



public class Account(string accountNumber, string firstName, string lastName) // ----konstruktor
{


    public virtual int Balance { get;  set; } //--- virtual betyder den här är möjlig att osidosätta/ hantera 
    public string AccountNumber { get; } = accountNumber;
    Customer Custmer {get; set;} = new(){FirstName = firstName, LastName = lastName};
    
    public List<Transaction> Transactions { get; } = [];
    

    public virtual void Deposit(int amount)
    {
        Balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }

    public void WithDraw(int amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot");
        }
        Balance -= amount;

        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }

    protected void AddTransaction(int amount, TransactionTypeEnum type) // protected öppnar inte upp för någon annan än barnen
    {
        Transaction tran = new()
        {
            TransactionAmount = amount,
            TransactionType = type
        };
        Transactions.Add(tran);
    }
}

