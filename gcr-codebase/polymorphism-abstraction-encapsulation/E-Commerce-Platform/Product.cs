using System;

namespace E_Commerce_Platform
{
    public abstract class Product
    {
        private int productId;
        private string name;
        private decimal price;

        public int ProductId
        {
            get { return productId; }
            protected set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            protected set
            {
                if (value > 0)
                    price = value;
            }
        }

        protected Product(int productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public abstract decimal CalculateDiscount();
    }
}
