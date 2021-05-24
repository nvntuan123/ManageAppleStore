using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class CustomersDTO : PersonDTO
    {
        private string _StrCustomerOfTypeID;

        public CustomersDTO(string strID, string strFullName, int iIDCard, string strNumberPhone, string strEmail, DateTime dTBirthDay, string strGender, string strAddress, bool bStatus, string strCustomerOfTypeID) : base(strID, strFullName, iIDCard, strNumberPhone, strEmail, dTBirthDay, strGender, strAddress, bStatus)
        {
            _StrCustomerOfTypeID = strCustomerOfTypeID;
        }

        public string StrCustomerOfTypeID { get => _StrCustomerOfTypeID; set => _StrCustomerOfTypeID = value; }
    }
}
