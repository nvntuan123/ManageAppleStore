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

namespace ManageAppleStore_GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Properties
        public delegate void DGLogin(bool bTrangThai, EmployeesDTO nvDangNhap);
        public DGLogin DLogin;
        public static EmployeesDTO EmpLogin = null;

        BindingList<EmployeesDTO> LstEmp = null;
        public static EmployeesDTO EmpSelected = null;

        Point LastPoint;
        #endregion
        #region Methods
        #endregion
        #region Events
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Center, 150, 180);

            txtID.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;
            btnExit.TabIndex = 3;

            lblError.Visible = false;
            txtID.Focus();

            //lstNV = NhanVien_BUS.loadDSNV_BUS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lblError.Location = new Point(241, 82);
                lblError.Visible = true;
                txtID.Focus();
            }
            else if (txtPassword.Text == string.Empty)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lblError.Location = new Point(241, 138);
                lblError.Visible = true;
                txtPassword.Focus();
            }
            else
            {
                lblError.Visible = false;

                EmpSelected = new EmployeesDTO(); // Khởi tạo.
                bool bCheckTK = false, bCheckMK = false;

                //foreach (Employees_DTO nv in LstEmp)
                //{
                //    if (txtTaiKhoan.Text == nv.strSDT)
                //    {
                //        bCheckTK = true;
                //        if (txtPassword.Text == nv.strMatKhau)
                //        {
                //            bCheckMK = true;
                //        }
                //    }

                //    if (bCheckTK && bCheckMK)
                //    {
                //        nvSelected = nv;
                //        nvDangNhap_ToanCuc = nv;
                //        break;
                //    }
                //}

                //if (bCheckTK && bCheckMK)
                //{
                //    if (dangNhap != null)
                //    {
                //        dangNhap(true, nvSelected);
                //        this.Close();
                //    }
                //}
                //else if (!bCheckTK)
                //{
                //    DevExpress.XtraEditors.XtraMessageBox.Show("Sai Tài Khoản!", "Thông Báo");
                //    lblError.Visible = true;
                //    lblError.Location = new Point(241, 82);
                //    txtTaiKhoan.Focus();
                //}
                //else if (!bCheckMK)
                //{
                //    DevExpress.XtraEditors.XtraMessageBox.Show("Sai Mật Khẩu!", "Thông Báo");
                //    lblError.Visible = true;
                //    lblError.Location = new Point(241, 138);
                //    txtPassword.Focus();
                //}
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Center, 150, 30);
            this.Close();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        #endregion
    }
}
