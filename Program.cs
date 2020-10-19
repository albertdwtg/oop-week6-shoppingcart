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
            Cart exo = new Cart("exo");
            Product app1 = new Product("apple");
            Product app2 = new Product("apple");
            Product or1 = new Product("orange");
            Product or2 = new Product("orange");
            Product or3 = new Product("orange");
            exo.content.Add(app1);
            exo.content.Add(app2);
            exo.content.Add(or1);
            exo.content.Add(or2);
            exo.content.Add(or3);
            double cost = exo.Cost();
            double final = exo.promo(cost);
            Console.WriteLine("The cost of your shopping cart is : "+final);
            Console.ReadLine();

        }
        

    }
}
