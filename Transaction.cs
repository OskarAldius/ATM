namespace WestcoastBank;

public class Transaction
{
    public DateTime TransactionDate { get; } = DateTime.Now;
    public TransactionTypeEnum TransactionType { get; set; }
    public int TransactionAmount { get; set; }
    public override string ToString() // ToString hur en typ kan repesentera sig som ett strängformat
    {
        return $"Transaktionsdatum: {TransactionDate} Transaktionstyp: {TransactionType} Belopp: {TransactionAmount}";
    }
}
