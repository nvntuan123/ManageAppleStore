using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class ProductsDTO
    {
        private string _StrProductID;
        private string _StrProductName;
        private DateTime? _DTYearOfProduct = null;
        private decimal _DecSalePrice;
        private string _StrProductOfTypeID;
        private bool _BStatus;

        public ProductsDTO()
        {
            _StrProductID = string.Empty;
            _StrProductName = string.Empty;
            _DecSalePrice = 0;
            _StrProductOfTypeID = string.Empty;
            _BStatus = false;
        }

        public ProductsDTO(string strProductID = null, string strProductName = null, DateTime? dTYearOfProduct = default, decimal decSalePrice = 0, string strProductOfTypeID = null, bool bStatus = false)
        {
            _StrProductID = strProductID;
            _StrProductName = strProductName;
            _DTYearOfProduct = dTYearOfProduct;
            _DecSalePrice = decSalePrice;
            _StrProductOfTypeID = strProductOfTypeID;
            _BStatus = bStatus;
        }

        public string StrProductID { get => _StrProductID; set => _StrProductID = value; }
        public string StrProductName { get => _StrProductName; set => _StrProductName = value; }
        public DateTime? DTYearOfProduct { get => _DTYearOfProduct; set => _DTYearOfProduct = value; }
        public decimal DecSalePrice { get => _DecSalePrice; set => _DecSalePrice = value; }
        public string StrProductOfTypeID { get => _StrProductOfTypeID; set => _StrProductOfTypeID = value; }
        public bool BStatus { get => _BStatus; set => _BStatus = value; }
    }
}
