using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05._06
{
    internal class Product
    {
        private string _prodName;
        private Money _price;

        public Product(string prodName, string currency, int denomination, int fractionalPart)
        {
            _prodName = prodName;
            _price = new Money(currency, denomination, fractionalPart);
        }

        public string ProdName { get { return _prodName; } }
        public Money Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return $"Product: {_prodName}\n" +
                $"Price: {_price}\n";
        }

        public void ReducePrice (int denomination, int fractionalPart)
        {
            //if( denomination > 0 && fractionalPart > 0)  // if  den -10
            if( denomination <= _price.Denomination && fractionalPart <= _price.FractionalPart) 
            {
                _price.Denomination -= denomination;
                _price.FractionalPart -= fractionalPart;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Error, wrong price reduction\n");
            }
        }

    }
}
