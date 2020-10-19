using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public string name;
        public double cost;
        public Product(string _name)
        {
            this.name = _name;
            if (this.name.ToUpper() == "APPLE")
            {
                this.cost = 0.60;
            }
            if(this.name.ToUpper()=="ORANGE")
            {
                this.cost = 0.25;
            }
            if (this.name.ToUpper() == "CHAIR")
            {
                this.cost = 25;
            }
            if (this.name.ToUpper() == "BANANA")
            {
                this.cost = 0.15;
            }

        }
    }
}
