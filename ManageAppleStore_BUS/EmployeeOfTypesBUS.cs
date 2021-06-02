using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageAppleStore_DAO;
using ManageAppleStore_DTO;

namespace ManageAppleStore_BUS
{
    public class EmployeeOfTypesBUS
    {
        public static BindingList<EmployeeOfTypesDTO> loadListBUS()
        {
            return EmployeeOfTypesDAO.loadListDAO();
        }

        public static List<string> loadIDListBUS()
        {
            return EmployeeOfTypesDAO.loadIDListDAO();
        }

        public static bool updateBUS(EmployeeOfTypesDTO Emp)
        {
            return EmployeeOfTypesDAO.updateDAO(Emp);
        }

        public static bool addEmpOfTypeBUS(EmployeeOfTypesDTO Emp)
        {
            return EmployeeOfTypesDAO.addDAO(Emp);
        }

        public static bool updateStatusBUS(EmployeeOfTypesDTO Emp)
        {
            return EmployeeOfTypesDAO.updateStatusDAO(Emp);
        }

        public bool checkIDBUS(EmployeeOfTypesDTO Emp)
        {
            return EmployeeOfTypesDAO.checkIDDAO(Emp);
        }

        public bool checkNameBUS(EmployeeOfTypesDTO Emp)
        {
            return EmployeeOfTypesDAO.checkNameDAO(Emp);
        }

        public static string getMaxIDBUS()
        {
            string StrMaxID = Garena.returnMaxID(EmployeeOfTypesDAO.loadIDListDAO());
            if (StrMaxID == "1")
            {
                return "LNV" + StrMaxID;
            }

            return StrMaxID;
        }

        public static bool addRule(EmployeeOfTypesDTO EmpOfType)
        {
            BindingList<FrmsDTO> LstFrmList = new BindingList<FrmsDTO>();
            LstFrmList = FrmsBUS.loadFrmsBUS();
            foreach (var value in LstFrmList)
            {
                PermissionsDTO Per = new PermissionsDTO();
                Per.StrEmployeeOfTypeID = EmpOfType.StrID;
                Per.StrFrmID = value.StrFrmID;
                if (value.StrFrmID == "frmPermissions")
                {
                    Per.BView = true;
                }

                if (!PermissionsBUS.addPermissionBUS(Per))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
