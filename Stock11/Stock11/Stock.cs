using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Stock11
{
    internal class Stock
    {

        public string StockName { get; set; }
        public int NumOfShares { get; set; }
        public float SharePrice { get; set; }

        public float GetStockValue()
        {
            //It will calculate the stock value 
            return NumOfShares * SharePrice;
        }

        public class StockPortfolio
        {
            //create list of stocks 
            List<Stock> stocks = new List<Stock>();

            //add values to stock 

            public void AddStock(Stock stock)
            {
                stocks.Add(stock);
            }
            public float GetTotalStockValue()
            {
                float totalStockValue = 0;

                //Total stock value= total stock +stockvalue 
                foreach (Stock stock in stocks)
                {
                    totalStockValue = totalStockValue + stock.GetStockValue();
                }

                return totalStockValue;
            }
            //print stock report 
            public void PrintStockReport()
            {
                Console.WriteLine("*************Welcome To Stock Management***************");
                Console.WriteLine("**********Stock Report:****************");


                foreach (Stock stock in stocks)
                {
                    float value = stock.GetStockValue();
                    Console.WriteLine(" StockName:"+stock.StockName);
                    Console.WriteLine(" NumberofShares: "+stock.NumOfShares);
                    Console.WriteLine(" PriceOfShare: "+stock.SharePrice);
                    Console.WriteLine("--------");
                }

                //Calculate total value of stocks 
                float totalStocks = GetTotalStockValue();

                Console.WriteLine("Total number of stocks:" + totalStocks);
                Console.WriteLine();
                


        }
        }
    }

}