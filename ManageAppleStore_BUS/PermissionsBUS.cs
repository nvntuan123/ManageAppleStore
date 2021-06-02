using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ManageAppleStore_DAO;
using ManageAppleStore_DTO;

namespace ManageAppleStore_BUS
{
    public class PermissionsBUS
    {
        public static BindingList<PermissionsDTO> getListByEmpOfTypeIDBUS(string StrEmpOfTypeID)
        {
            return PermissionsDAO.getListByEmpOfTypeIDDAO(StrEmpOfTypeID);
        }

        public static PermissionsDTO getListByEmpOfTypeIDAndFormBUS(string StrEmpOfTypeID, string StrFrmID)
        {
            return PermissionsDAO.getListByEmpOfTypeIDAndFormDAO(StrEmpOfTypeID, StrFrmID);
        }

        public static bool addPermissionBUS(PermissionsDTO Per)
        {
            return PermissionsDAO.addDAO(Per);
        }

        public static bool updatePermission(PermissionsDTO Per)
        {
            return PermissionsDAO.updateDAO(Per);
        }
    }
}
