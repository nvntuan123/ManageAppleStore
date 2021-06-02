using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class EmployeeOfTypesDTO : TypesDTO
    {
        public EmployeeOfTypesDTO() :  base()
        {
            
        }

        public EmployeeOfTypesDTO(string strID, string strName, bool bStatus, string str) : base(strID, strName, bStatus)
        {
            
        }
    }
}
