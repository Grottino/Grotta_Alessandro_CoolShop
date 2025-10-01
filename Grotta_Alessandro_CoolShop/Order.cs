using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grotta_Alessandro_CoolShop
{
    internal class Order
    {
        public int Id { get; set; }
        public string ArticleName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double PercentageDiscount { get; set; }
        public string Buyer { get; set; }


        public override string ToString()
        {
            return $"{Id}, {ArticleName}, {Quantity}, {Price}, {PercentageDiscount}, {Buyer}";





        }
    }
}

    
