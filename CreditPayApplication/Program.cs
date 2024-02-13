namespace CreditPayApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Applications applications = new Applications(new PersonalFinanceCredit(), new FileLogger());
            applications.Pay();
            
        }
    }
}
