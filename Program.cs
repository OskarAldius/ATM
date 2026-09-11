using WestcoastBank;

namespace ATM;


class Program

{
   static Account account = new("1234-5678") { };
   //static Account account = new Account("1234-5678");
    static void Main()
    {
       account.FirstName = "Michael";
       account.LastName = "Gustavsson";
       
        System.Console.WriteLine("------------------------------------------------------------------------------");
        System.Console.WriteLine("För att sätta in tryck på tangenten 'd'");
        System.Console.WriteLine("För att ut tryck på tangenten 'w'");
        System.Console.WriteLine("För att se saldo tryck på tangenten 'b'");
        System.Console.WriteLine("För att se transaktionerna tryck på tangenten 't'");
        System.Console.WriteLine("För att avsluta tryck på tangenten 'x'");
        System.Console.WriteLine("------------------------------------------------------------------------------");

App();
       
    }

    static void App()
    {
         try
        {
            while (true)
            {
                var key = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(key)|| key!= "d"&& key!= "t"&& key!= "w"&& key!= "b"&& key!= "x")
                {
                    continue;
                }
                
                
                if( key == "x")
                {
                    Environment.Exit(0);

                }

                switch (key)
                {
                    case "b":
                    DisplayBalance();
                    break;

                    case "t":
                    DisplayTransactions();
                    break;
                    case "d":
                    
                     Console.WriteLine("Hur mycket vill du sätta in?");
                            var amount = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            
                            throw new Exception("Du måste ange ett heltalsvärde");
                        }


                    if (!int.TryParse(amount, out int result))
                    {
                         throw new Exception("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
                        
                    }
                    Deposit(result);

                    break;
                    case "w":
                        System.Console.WriteLine("Hur mcyket vill du ta ut?");
                        amount = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            throw new Exception("Du måste age ett heltalsvärde");

                        }
                        if(!int.TryParse(amount, out int value))
                        {
                             throw new Exception("Du måste skriva in ett heltalsvärde för att jag ska kunna förstå!");
                           

                        }
                         Withdraw(value);
                    break;
                    default:
                    Environment.Exit(0);
                    break;
                }


            }

        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            App();
        }
        finally
        {
            System.Console.WriteLine("Nu är de fredag");
            
        }
  
  
        
    }
        static void DisplayBalance()
    {
        System.Console.WriteLine($"Ditt nuvarande saldo är: {account.Balance}");

    }

    static void Deposit(int amount)
    {
        if (amount > 0)
        {
        account.Deposit(amount);
        

        }
        else
        {
            System.Console.WriteLine("Du kan inte sätta in 0 eller negativt");
        }

    }
    static void Withdraw(int amount)
    {
       account.Withdraw(amount);
        
    }

    static void DisplayTransactions()
    {
        foreach(var tran in account.Transactions)
        {
            System.Console.WriteLine(tran.ToString());

        }

    }
   

}

 

       /*   int x = 10;    
         int y = x;      //copy by value => Vi kopierar x värde(10) till y...
        Console.WriteLine("X = {0}", x); 
        Console.WriteLine("Y = {0}", y);
        y = 20;
        
        Console.WriteLine("X = {0}", x);
        Console.WriteLine("Y = {0}", y);  */
      
      /* int[] numbers = new int[5];
      Console.WriteLine(numbers.Length);
      numbers[0] = 1;
      numbers[1] = 3;


     
       Console.WriteLine(numbers[1]);
        Array.Resize(ref numbers, 6);
      numbers[5] = 5;
      Console.WriteLine(numbers[5]);



      string[] names = ["wilma", "batman", "Oskar"];

      Console.WriteLine(names.Length);
      Console.WriteLine(names[1]);

      object[] vehicles = new object[5];
      vehicles[0] = new{make="volvo", model="XC60",color="Blue",mileage=20000};
      vehicles[1] = new{make="Fiat", model="Uno",color="Brown",mileage=20000};


      Console.WriteLine(vehicles[0]); */

       /*  string firstName = "michael Gustavsson";

        Console.WriteLine(firstName.StartsWith("O"));
        Console.WriteLine(firstName.ToLower().StartsWith("osk"));  // Tolower ingorerar stor bokstav 
        Console.WriteLine(firstName.EndsWith("ar"));
        System.Console.WriteLine(firstName.Length);
        System.Console.WriteLine(firstName.Substring(0));
        System.Console.WriteLine(firstName[..]);
        System.Console.WriteLine(firstName.Substring(1));
        System.Console.WriteLine(firstName[1..]);
        System.Console.WriteLine(firstName.Substring(0, 6));
        System.Console.WriteLine(firstName[..6]);
        System.Console.WriteLine(firstName[6..]);
        var names = firstName.Split(' ');
        System.Console.WriteLine(names.Length);
        System.Console.WriteLine(names [0]);
        System.Console.WriteLine(names [1]);

        string name1 = "Nisse";
        string name2 = "Eva";
/* 
        string name = name1 + " " + name2; */
        
        /*  System.Console.WriteLine("{0}", name1); */
     /*    string name = $"Välkomna {name1} och {name2}";
        System.Console.WriteLine(name);

        double value = 799.97579;
        System.Console.WriteLine("Värdet är: {0}", value);
        System.Console.WriteLine("Värdet är: {0:N2}", value);
        System.Console.WriteLine("Värdet är: {0:C2}", value);

        System.Console.WriteLine(firstName.Contains("ael Gus")); */ 
     /*    int balance = 0;
        Console.ForegroundColor = ConsoleColor.Green;
       System.Console.WriteLine("Hur mcyket vill du sätta in?");
       var amount = int.Parse(Console.ReadLine());
Console.ResetColor();
       balance += amount;


        Console.ForegroundColor = ConsoleColor.DarkCyan;

       System.Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now);
       System.Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.Date);
       System.Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.TimeOfDay);
       System.Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.ToLongDateString());
       System.Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.ToShortDateString());
       System.Console.WriteLine("Ditt saldo är nu {0} - {1}", balance, DateTime.Now.ToShortTimeString());

       System.Console.WriteLine("Hur mycket vill du ta ut?");
       amount = int.Parse(Console.ReadLine());
Console.ResetColor();
       balance -= amount;
       
       System.Console.WriteLine("Ditt saldo är nu {0}", balance); */

   /*   System.Console.WriteLine("Hej, ange ditt förnamn");
     string förnamn = Console.ReadLine();

     System.Console.WriteLine(förnamn);

     System.Console.WriteLine("Tack, skriv nu in ditt efternamn");
     string efternamn = Console.ReadLine();
     System.Console.WriteLine(efternamn);

     Console.ForegroundColor = ConsoleColor.Yellow;

     System.Console.WriteLine("Välkmen " + förnamn + " " + efternamn);

   System.Console.WriteLine("Skapa ett lösenord");
   int lösen = int.Parse(Console.ReadLine());
   System.Console.WriteLine("Upprepa nu ditt lösenord");
   int lösen2 = int.Parse(Console.ReadLine());
      
      
      if(lösen == lösen2)
      {
         
          System.Console.WriteLine("grattis");
         
      }
         else
         {
             
            System.Console.WriteLine("Det stämmer inte, försök igen");
         }
       */
     /*  int age = 25;
        int result = Demo(age);
        int refResult = DemoRef(ref age);

      System.Console.WriteLine($"Local age: {age}");
      System.Console.WriteLine($"Returned age: {result}");
     System.Console.WriteLine("ByReference-----------------");
      System.Console.WriteLine($"Local age: {age}");
      System.Console.WriteLine($"Returned age: {refResult}");


   static int Demo(int age) //copyByvalue
      {
         age++;
         return age;


      }

      static int DemoRef(ref int age)
      {
         age++;
         return age;


      } */
 
     


   /* static void Deposit(decimal amount)
   {
      balance += (int)amount; // Rekommendrande sättet...
      //balance += Convert.ToInt32(amount);

   }

   
    static void Deposit(int amount,string accountNumber) // Header - Defination
   { // body...
      balance += amount;


   }
 
 */


  