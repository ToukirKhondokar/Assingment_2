namespace Assingment_2
{




    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CreditCard credit_card_1 = new CreditCard();
                credit_card_1.Withdraw(500);
                credit_card_1.PayBill(1000000);


                CreditCard credit_card_2 = new CreditCard();
                credit_card_1.Withdraw(22000);
                credit_card_1.PayBill(100000);

            }
            catch(Exception ex) 
            {
                Console.WriteLine($"{ex.Message}");    
            
            }

        }
    }
}
