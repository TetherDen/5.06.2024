using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05._06
{
    internal class Money
    {
        private string _currency;
        private int _denomination;
        private int _fractionalPart;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
        public int Denomination 
        {
            get { return _denomination; }
            set
            {
                if (value >= 0)
                    _denomination = value;
                else throw new ArgumentOutOfRangeException("Denomination must be >= 0. \n");
            }
        }
        public int FractionalPart
        {
            get { return _fractionalPart; }
            set
            {
                if( value >= 0 && value < 100)
                    _fractionalPart = value;
                else throw new ArgumentOutOfRangeException("FractionalPart must be value >= 0 && < 100 \n");
            }
        }

        public Money(string currency, int denomination, int fractionalPart)
        {
            _currency = currency;
            Denomination = denomination;
            FractionalPart = fractionalPart;
        }

        public override string ToString()
        {
            return $"{_currency}: {_denomination},{_fractionalPart}";
        }


    }
}
