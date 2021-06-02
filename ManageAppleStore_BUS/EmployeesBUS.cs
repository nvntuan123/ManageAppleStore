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
    public class EmployeesBUS
    {
        public static BindingList<EmployeesDTO> loadListBUS()
        {
            return EmployeesDAO.loadListDAO();
        }

        public static List<string> loadIDListBUS()
        {
            return EmployeesDAO.loadIDListDAO();
        }

        public static bool addEmpBUS(EmployeesDTO Emp)
        {
            return EmployeesDAO.addDAO(Emp);
        }

        public static bool deleteEmpDAO(EmployeesDTO Emp)
        {
            return EmployeesDAO.deleteDAO(Emp);
        }

        public static string getByIdNumberPhone(string StrNumberPhone)
        {
            return EmployeesDAO.getByIDNumberPhone(StrNumberPhone);
        }

        public static string getIDByIDCard(string StrIDCard)
        {
            return EmployeesDAO.getIDByIDCard(StrIDCard);
        }

        public static string checkEmailBUS(string StrEmail)
        {
            return EmployeesDAO.checkEmailDAO(StrEmail);
        }
    }
}
