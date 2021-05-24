using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class IMEIDTO
    {
        private string _StrIMEIID;
        private string _StrProductID;
        private int _IInvoiceID;
        private int _IBillID;

        public IMEIDTO()
        {
            _StrIMEIID = string.Empty;
            _StrProductID = string.Empty;
            _IInvoiceID = 0;
            _IBillID = 0;
        }

        public IMEIDTO(string strIMEIID, string strProductID, int iInvoiceID, int iBillID)
        {
            _StrIMEIID = strIMEIID;
            _StrProductID = strProductID;
            _IInvoiceID = iInvoiceID;
            _IBillID = iBillID;
        }

        public string StrIMEIID { get => _StrIMEIID; set => _StrIMEIID = value; }
        public string StrProductID { get => _StrProductID; set => _StrProductID = value; }
        public int IInvoiceID { get => _IInvoiceID; set => _IInvoiceID = value; }
        public int IBillID { get => _IBillID; set => _IBillID = value; }
    }
}
