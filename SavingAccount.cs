namespace WestcoastBank;

public class SavingAccount(string accountNo, string fname, string lname):
Account(accountNo, fname,lname)
{
    //public SavingAccount(string accountNo):base(accountNo) gammla sättet 


    const double INTEREST_RATE = 0.05;
     public override int Balance => 
         Convert.ToInt32(base.Balance * (1+INTEREST_RATE));

    
    public double InterestRate { get; set; }

    public void CalculateInsterest()
    {
        
    }
public override void Deposit(int amount)
    {
        base.Balance += amount;
    AddTransaction(amount, TransactionTypeEnum.Insättning);
    }

}
