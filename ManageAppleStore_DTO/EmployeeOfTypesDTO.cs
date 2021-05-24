using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class EmployeeOfTypesDTO : TypesDTO
    {
        EmployeeOfTypesDTO() : base()
        {

        }

        EmployeeOfTypesDTO(string strID, string strName, bool bStatus) : base(strID, strName, bStatus)
        {

        }
    }
}
