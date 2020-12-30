using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAppleStore_GUI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        #region Events
        private void frmHome_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Center, 150, 180);

            timer1.Start();
            //lstLoaiNV = LoaiNhanVien_BUS.layDSLoaiNV_BUS();

            panUserAndRole.Visible = false;
            //lblHienThi_ChucVu.Visible = false;
            //lblHienThi_Ten.Visible = false;

            //tileItemModel.Visible = false;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            //if (!bTrangThaiDangNhap)
            //{
            //    frmDangNhap frm = new frmDangNhap();
            //    frm.dangNhap = setTrangThaiDangNhap;
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    setTrangThaiDangNhap(false, null);
            //}
        }

        private void tileItemQLLoaiNV_ItemClick(object sender, TileItemEventArgs e)
        {
            //if (bTrangThaiDangNhap)
            //{
            //    frmQLLoaiNV frm = new frmQLLoaiNV();
            //    _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

            //    if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
            //        XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        frm.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void tileItemTTNV_ItemClick(object sender, TileItemEventArgs e)
        {
            //if (bTrangThaiDangNhap)
            //{
            //    frmTTNV frm = new frmTTNV();
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void tileItemThongKeBaoCao_ItemClick(object sender, TileItemEventArgs e)
        {
            //if (bTrangThaiDangNhap)
            //{
            //    frmBaoCao frm = new frmBaoCao();
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void tileItemQLLoaiSP_ItemClick(object sender, TileItemEventArgs e)
        {
            //if (bTrangThaiDangNhap)
            //{
            //    frmQLLoaiSP frm = new frmQLLoaiSP();
            //    _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

            //    if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
            //        XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        frm.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void tileItemXemSP_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //frmQLSP frm = new frmQLSP();
            //_B_TrangThaiClickXem = true;
            //frm.ShowDialog();
        }

        private void tileItemQLSP_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //if (bTrangThaiDangNhap)
            //{
            //    frmQLSP frm = new frmQLSP();
            //    _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

            //    if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
            //        XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //    {
            //        _B_TrangThaiClickXem = false;
            //        frm.ShowDialog();
            //    }
            //}
            //else
            //{
            //    XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void tileItemThongTinPhanMem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            XtraMessageBox.Show(tileItemDateTime.RowCount.ToString());
        }

        private void tileItemQLHDBan_ItemClick(object sender, TileItemEventArgs e)
        {
            //if (bTrangThaiDangNhap)
            //{
            //    frmQLHoaDonBan frm = new frmQLHoaDonBan();
            //    _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

            //    if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
            //        XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        frm.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void tileItemQLHDNhap_ItemClick(object sender, TileItemEventArgs e)
        {
            //if (bTrangThaiDangNhap)
            //{
            //    frmQLHoaDonNhap frm = new frmQLHoaDonNhap();
            //    _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

            //    if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
            //        XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        frm.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tileItemDateTime.Elements[0].Text = string.Format("{0:HH:mm:ss }", DateTime.Now);
            tileItemDateTime.Elements[1].Text = string.Format("{0:MM/yyyy}", DateTime.Now);
            tileItemDateTime.Elements[3].Text = string.Format("{0:dd}", DateTime.Now);
            tileItemDateTime.Elements[2].Text = string.Format("{0:dddd}", DateTime.Now);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //if (panelMenu.Size.Width == 38)
            //{
            //    panelMenu.Size = new Size(210, 60);
            //    if (bTrangThaiDangNhap)
            //    {
            //        lblHienThi_ChucVu.Visible = true;
            //    }
            //    else
            //    {
            //        lblHienThi_ChucVu.Visible = false;
            //    }
            //}
            //else
            //{
            //    panelMenu.Size = new Size(38, 60);
            //    lblHienThi_ChucVu.Visible = false;
            //}
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            //frmTTPM frm = new frmTTPM();
            //frm.ShowDialog();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Center, 150, 180);
            Application.Exit();
        }
        #endregion
    }
}
