using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class InvoiceDTO
    {
        private int _IInvoiceID;
        private string _StrEmployeeID;
        private DateTime? _DTInvoiceDay = null;
        private decimal _DecTotalPrice;
        private bool _BStatus;

        public InvoiceDTO()
        {
            _IInvoiceID = 0;
            _StrEmployeeID = string.Empty;
            _DecTotalPrice = 0;
            _BStatus = false;
        }

        public InvoiceDTO(int iInvoiceID = 0, string strEmployeeID = null, DateTime? dtInvoiceDay = null, decimal decTotalPrice = 0, bool bStatus = false)
        {
            _IInvoiceID = iInvoiceID;
            _StrEmployeeID = strEmployeeID;
            _DTInvoiceDay = dtInvoiceDay;
            _DecTotalPrice = decTotalPrice;
            _BStatus = bStatus;
        }

        public int IInvoiceID { get => _IInvoiceID; set => _IInvoiceID = value; }
        public string StrEmployeeID { get => _StrEmployeeID; set => _StrEmployeeID = value; }
        public DateTime? DTInvoiceDay { get => _DTInvoiceDay; set => _DTInvoiceDay = value; }
        public decimal DecTotalPrice { get => _DecTotalPrice; set => _DecTotalPrice = value; }
        public bool BStatus { get => _BStatus; set => _BStatus = value; }
    }
}
