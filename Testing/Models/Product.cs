using System;


namespace Testing.Models
{

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Product
    {
        public Product()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
    }
}