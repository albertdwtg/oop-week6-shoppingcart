using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> test = new List<string>();
            test.Add("orange");
            test.Add("orange");
            test.Add("apple");
            Console.WriteLine("The cost of your shopping cart is : "+cost(test));
            Console.ReadLine();

        }
        static double cost(List<string> cart)
        {
            double cost = 0;
            foreach(string s in cart)
            {
                if(s.ToUpper()=="ORANGE")
                {
                    cost = cost + 0.25;
                }
                if(s.ToUpper()=="APPLE")
                {
                    cost = cost + 0.60;
                }
                
            }
            return cost;
        }
    }
}
