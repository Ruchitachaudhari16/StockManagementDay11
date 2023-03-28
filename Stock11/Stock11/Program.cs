using static Stock11.Stock;

namespace Stock11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stock management system");
            

            StockPortfolio portfolio = new StockPortfolio();
            //To print for 5 stocks
            for (int i = 1; i <=5; i++)
            {
              
                Console.WriteLine("Enter the StockName:");
                string stockname = Console.ReadLine();

                Console.WriteLine("Enter the number of shares");
                int numOfShares = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the shares price ");
                decimal sharePrice = Convert.ToDecimal(Console.ReadLine());
                Stock stock = new Stock();
                stock.StockName = stockname;
                stock.NumOfShares = numOfShares;
                stock.SharePrice = (float)sharePrice;

               portfolio.AddStock(stock);
            }

           portfolio.PrintStockReport();

        }
    }
}