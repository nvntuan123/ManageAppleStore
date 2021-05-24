using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class BillDetailDTO
    {
        private int _IBillID;
        private string _StrProductID;
        private int _IQuantity;
        private decimal _DecUnitPrice;

        public BillDetailDTO()
        {
            _IBillID = 0;
            _StrProductID = string.Empty;
            _IQuantity = 0;
            _DecUnitPrice = 0;
        }

        public BillDetailDTO(int iBillID = 0, string strProductID = null, int iQuantity = 0, decimal decUnitPrice = 0)
        {
            _IBillID = iBillID;
            _StrProductID = strProductID;
            _IQuantity = iQuantity;
            _DecUnitPrice = decUnitPrice;
        }

        public int IBillID { get => _IBillID; set => _IBillID = value; }
        public string StrProductID { get => _StrProductID; set => _StrProductID = value; }
        public int IQuantity { get => _IQuantity; set => _IQuantity = value; }
        public decimal DecUnitPrice { get => _DecUnitPrice; set => _DecUnitPrice = value; }
    }
}
