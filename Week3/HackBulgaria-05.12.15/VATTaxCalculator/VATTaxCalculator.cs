using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class NotSupportedCountryException : Exception
    {
        public NotSupportedCountryException ( ) { }
        public NotSupportedCountryException ( string message ) : base(message) { }
    }
    public class VATTaxCalculator
    {
        private readonly List<CountryVatTax> countryList;

        public VATTaxCalculator ( List<CountryVatTax> list )
        {
            countryList = new List<CountryVatTax>(list);
        }

        public List<CountryVatTax> CountryList
        {
            get
            {
                return countryList;
            }
        }
        public decimal CalculateTax ( decimal value )
        {
            foreach(var item in countryList)
            {
                if(item.IsDefault)
                {
                    return value + value * (decimal)item.VatTax;
                }
            }
            throw new NotSupportedCountryException("There is no default country in the list!");
        }

        public decimal CalculateTax ( decimal value , int countryID )
        {
            foreach(var item in countryList)
            {
                if(countryID == item.CountryID)
                {
                    return value + value * (decimal)item.VatTax;
                }
            }
            throw new NotSupportedCountryException("ID not found in the calculator's data base!");
        }
    }
}
