using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        public List<Product> content=new List<Product>();
        public string name;
        
        public Cart(string _name)
        {
            this.name = _name;
            
        }
        public int countApple()
        {
            int total = 0;
            foreach(Product p in this.content)
            {
                if(p.name.ToUpper()=="APPLE")
                {
                    total = total + 1;
                }
                
            }
            return total;
        }
        public double Cost()
        {
            double price = 0;
            foreach (Product s in this.content)
            {
                price = price + s.cost;
            }
            return price;
        }
        public int countOrange()
        {
            int total = 0;
            foreach (Product p in this.content)
            {
                if (p.name.ToUpper() == "ORANGE")
                {
                    total = total + 1;
                }

            }
            return total;
        }
        public double promo(double cost)
        {
            int count = countApple()/2;
            for(int i=0;i<count;i++)
            {
                cost = cost - 0.6;
            }
            count = countOrange();
            int pack = count / 3;
            for(int i=0;i<pack;i++)
            {
                cost = cost - 0.25;
            }
            return cost;
        }
    }
}
