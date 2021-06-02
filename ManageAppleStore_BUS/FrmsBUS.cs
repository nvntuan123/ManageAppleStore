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
    public class FrmsBUS
    {
        public static BindingList<FrmsDTO> loadFrmsBUS()
        {
            return FrmsDAO.loadListDAO();
        }
    }
}
