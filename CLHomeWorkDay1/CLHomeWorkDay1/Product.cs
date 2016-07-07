using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHomeWorkDay1
{
    public interface IProduct
    {
         int Id { get; set; }
         int Cost { get; set; }
         int Revenue { get; set; }
         int SellPrice { get; set; }
    }

    public class Product: IProduct
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
