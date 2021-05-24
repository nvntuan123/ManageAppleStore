using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageAppleStore_DTO;
using ManageAppleStore_BUS;

namespace ManageAppleStore_GUI
{
    public partial class frmManageInvoices : Form
    {
        public frmManageInvoices()
        {
            InitializeComponent();
        }
        #region Properties
        BindingList<EmployeesDTO> _LST_DSNhanVien = new BindingList<EmployeesDTO>();
        //BindingList<Invoi> _LST_DSHDNhapFromToDate = new BindingList<HDNhap_DTO>();
        #endregion
        #region Methods
        #endregion
        #region Events
        #endregion
    }
}
