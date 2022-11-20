using System.Runtime.InteropServices;

namespace BusinessModel
{
    public class SaleInfo
    {
        public string Country { get; set; }
        public string Saleability { get; set; }
        public DateTime OnSaleDate { get; set; }
        public bool IsEbook { get; set; }
        public ListPrice ListPrice { get; set; }
        public RetailPrice RetailPrice { get; set; }
        public string BuyLink { get; set; }

    }
}