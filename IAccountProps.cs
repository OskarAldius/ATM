namespace WestcoastBank;

public interface IAccountProps //Alla interface är public
{
      int Balance { get;  } //--- virtual betyder den här är möjlig att osidosätta/ hantera 
      string AccountNumber { get; } 
  
     List<Transaction> Transactions { get; } 
}
