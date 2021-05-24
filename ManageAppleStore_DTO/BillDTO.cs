using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class BillDTO
    {
        private int _IBillID;
        private DateTime? _DTBillOfDay = null;
        private decimal _DecTotalPrice;
        private string _StrEmployeeID;
        private string _StrCustomerID;
        private int _IDiscountsID;
        private bool _BStatus;

        public BillDTO()
        {
            _IBillID = 0;
            _DecTotalPrice = 0;
            _StrEmployeeID = string.Empty;
            _StrCustomerID = string.Empty;
            _IDiscountsID = 0;
            _BStatus = false;
        }

        public BillDTO(int iBillID = 0, DateTime? dTBillOfDay = null, decimal decTotalPrice = 0, string strEmployeeID = null, string strCustomerID = null, int iDiscountsID = 0, bool bStatus = false)
        {
            _IBillID = iBillID;
            _DTBillOfDay = dTBillOfDay;
            _DecTotalPrice = decTotalPrice;
            _StrEmployeeID = strEmployeeID;
            _StrCustomerID = strCustomerID;
            _IDiscountsID = iDiscountsID;
            _BStatus = bStatus;
        }

        public int IBillID { get => _IBillID; set => _IBillID = value; }
        public DateTime? DTBillOfDay { get => _DTBillOfDay; set => _DTBillOfDay = value; }
        public decimal DecTotalPrice { get => _DecTotalPrice; set => _DecTotalPrice = value; }
        public string StrEmployeeID { get => _StrEmployeeID; set => _StrEmployeeID = value; }
        public string StrCustomerID { get => _StrCustomerID; set => _StrCustomerID = value; }
        public int IDiscountsID { get => _IDiscountsID; set => _IDiscountsID = value; }
        public bool BStatus { get => _BStatus; set => _BStatus = value; }
    }
}
