using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class CountryVatTax
    {
        private readonly int countryID;
        private readonly double vatTax;
        private readonly bool isDefault;

        public CountryVatTax ( int id , double vat , bool isDef )
        {
            countryID = id;
            vatTax = vat;
            isDefault = isDef;
        }
        public int CountryID
        {
            get
            {
                return countryID;
            }
        }

        public double VatTax
        {
            get
            {
                return vatTax;
            }
        }

        public bool IsDefault
        {
            get
            {
                return isDefault;
            }
        }


    }
}
