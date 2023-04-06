using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingOnline
{
    public class Phone
    {
        public Phone(Image image, string name, string price, int discount, string[] details)
        {
            Image = image;
            Name = name;
            Price = price;
            Discount = discount;
            this.details = details;
        }

        public Image Image { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Discount { get; set; }
        public String[] details { get; set; }

    }
}
