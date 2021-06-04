using System;
using System.Collections.Generic;


namespace PramotionEngineCodeTest
{
   public class Program
    {
        public static void Main(string[] args)
        {
            List<MyProduct> products = new List<MyProduct>();
            
            Console.WriteLine("Please Enter total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {                
                Console.WriteLine(" Please enter the type of product:A,B,C or D");
                string type= Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }

            int totalPrice = GetTotalPriceOfProduct(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetTotalPriceOfProduct(List<MyProduct> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A"||pr.Id=="a")
                {
                    counterofA=counterofA + 1;
                }
                if (pr.Id == "B"||pr.Id=="b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C"||pr.Id=="c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id=="d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
    public class MyProduct
    {

        public string Id { get; set; }
        public decimal Price { get; set; }
        

        public MyProduct(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;
                    
                    break;
                case "B":
                    this.Price = 30m;
                    
                    break;
                case "C":
                    this.Price = 20m;
                 
                    break;
                case "D":
                    this.Price = 2015m;
                    break;
            }
        }

    }
}