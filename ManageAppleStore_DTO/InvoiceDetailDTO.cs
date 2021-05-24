using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class InvoiceDetailDTO
    {
        private int _IInvoiceID;
        private string _StrProductID;
        private int _IQuantity;
        private decimal _DecUnitPrice;

        public InvoiceDetailDTO()
        {
            _IInvoiceID = 0;
            _StrProductID = string.Empty;
            _IQuantity = 0;
            _DecUnitPrice = 0;
        }

        public InvoiceDetailDTO(int iInvoiceID = 0, string strProductID = null, int iQuantity = 0, decimal decUnitPrice = 0)
        {
            _IInvoiceID = iInvoiceID;
            _StrProductID = strProductID;
            _IQuantity = iQuantity;
            _DecUnitPrice = decUnitPrice;
        }

        public int IInvoiceID { get => _IInvoiceID; set => _IInvoiceID = value; }
        public string StrProductID { get => _StrProductID; set => _StrProductID = value; }
        public int IQuantity { get => _IQuantity; set => _IQuantity = value; }
        public decimal DecUnitPrice { get => _DecUnitPrice; set => _DecUnitPrice = value; }
    }
}
