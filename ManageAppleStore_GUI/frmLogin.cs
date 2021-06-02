using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageAppleStore_BUS;
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

            LstEmp = EmployeesBUS.loadListBUS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LstEmp == null)
            {
                MessageBox.Show("Chưa Có Nhân Viên Nào Trong Danh Sách!");
            }
            else
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
                    bool BCheckID = false, BCheckPas = false;

                    foreach (EmployeesDTO Emp in LstEmp)
                    {
                        if (txtID.Text == Emp.StrNumberPhone)
                        {
                            BCheckID = true;
                            if (txtPassword.Text == Emp.StrPassword)
                            {
                                BCheckPas = true;
                            }
                        }

                        if (BCheckID && BCheckPas)
                        {
                            EmpSelected = Emp;
                            EmpLogin = Emp;
                            break;
                        }
                    }

                    if (BCheckID && BCheckPas)
                    {
                        if (DLogin != null)
                        {
                            DLogin(true, EmpSelected);
                            this.Close();
                        }
                    }
                    else if (!BCheckID)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Sai Tài Khoản!", "Thông Báo");
                        lblError.Visible = true;
                        lblError.Location = new Point(241, 82);
                        txtID.Focus();
                    }
                    else if (!BCheckPas)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Sai Mật Khẩu!", "Thông Báo");
                        lblError.Visible = true;
                        lblError.Location = new Point(241, 138);
                        txtPassword.Focus();
                    }
                }
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
