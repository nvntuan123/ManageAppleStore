using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class EmployeesDTO : PersonDTO
    {
        private string _StrPassword;
        private string _StrEmployeeOfTypeID;
        private decimal _DecSalary;

        public EmployeesDTO() : base()
        {
            _StrPassword = string.Empty;
            _StrEmployeeOfTypeID = string.Empty;
            _DecSalary = 0;
        }

        public EmployeesDTO(string strID, string strFullName, int iIDCard, string strNumberPhone, string strEmail, DateTime dTBirthDay, string strGender, string strAddress, bool bStatus, string strPassword, string strEmployeeOfTypeID, decimal decSalary) : base(strID, strFullName, iIDCard, strNumberPhone, strEmail, dTBirthDay, strGender, strAddress, bStatus)
        {
            _StrPassword = strPassword;
            _StrEmployeeOfTypeID = strEmployeeOfTypeID;
            _DecSalary = decSalary;
        }

        public string StrPassword { get => _StrPassword; set => _StrPassword = value; }
        public string StrEmployeeOfTypeID { get => _StrEmployeeOfTypeID; set => _StrEmployeeOfTypeID = value; }
        public decimal DecSalary { get => _DecSalary; set => _DecSalary = value; }
    }
}
