using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using ManageAppleStore_BUS;
using ManageAppleStore_DTO;

namespace ManageAppleStore_GUI
{
    public partial class frmBillDetails : Form
    {
        public frmBillDetails()
        {
            InitializeComponent();
        }
        #region Properties
        private BillDTO _Bill = new BillDTO();

        public BillDTO Bill { get => _Bill; set => _Bill = value; }

        private ProductsDTO _ProductCurrent = null;

        private BindingList<EmployeesDTO> _LstEmployList = new BindingList<EmployeesDTO>();
        private BindingList<CustomersDTO> _LstCustomerList = new BindingList<CustomersDTO>();
        private BindingList<ProductsDTO> _LstProductList = new BindingList<ProductsDTO>();
        private BindingList<BillDetailDTO> _LstBillDetailList = new BindingList<BillDetailDTO>();
        private BindingList<ProductOfTypesDTO> _LstProductTypeList = new BindingList<ProductOfTypesDTO>();
        private BindingList<IMEIDTO> _LstIMEIList = new BindingList<IMEIDTO>();
        #endregion
        #region Methods
        private bool _B_indicatorIcon = true;

        private void gvPhanQuyen_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    string sText = (e.RowHandle + 1).ToString();
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString(sText, e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = sText;
                }
                if (!_B_indicatorIcon)
                    e.Info.ImageIndex = -1;

                if (e.RowHandle == GridControl.InvalidRowHandle)
                {
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString("STT", e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = "STT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvPhanQuyen_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }

        // Load du lieu nhan vien.
        void loadDSNhanVien(BindingList<EmployeesDTO> LstEmployee)
        {
            lookUpEdit_TenNV.Properties.DataSource = _LstEmployList;
            lookUpEdit_TenNV.Properties.Columns["colTenNV"].FieldName = "StrFullName";
        }

        // Load du lieu khach hang.
        void loadDSKhachHang(BindingList<CustomersDTO> LstCus)
        {
            lookUpEdit_TenKH.Properties.DataSource = _LstCustomerList;
            lookUpEdit_TenKH.Properties.Columns["colTenKH"].FieldName = "strHoTenKH";
        }

        // Load du lieu loai san pham.
        void loadDSLoaiSanPham(BindingList<ProductOfTypesDTO> LstProductTypes)
        {
            LookUpEdit_LoaiSP.DataSource = _LstProductTypeList;
            LookUpEdit_LoaiSP.Columns["colMaLoaiSP"].FieldName = "strMaLoaiSP";
            LookUpEdit_LoaiSP.Columns["colTenLoaiSP"].FieldName = "strTenLoaiSP";
        }

        // Load DS san pham theo hdban.
        void loadDSSP_HDBan(int _I_MaHDB, BindingList<BillDetailDTO> LstBillDetails, BindingList<ProductsDTO> LstProducts)
        {

        }
        #endregion
        #region Events
        private void frmBillDetails_Load(object sender, EventArgs e)
        {
            /*Designs Form*/
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            /*Designs Form*/
            grpThongTinHDBan.Enabled = false;
            if (_Bill != null)
            {
                //// Load du lieu nhan vien.
                //_LST_DSNhanVien = NhanVien_BUS.loadDSNV_BUS();
                //loadDSNhanVien(_LST_DSNhanVien);

                //// Load du lieu khach hang.
                //_LST_DSKhachHang = KhachHang_BUS.loadDSKhachHang_BUS();
                //loadDSKhachHang(_LST_DSKhachHang);

                //// Load du lieu hoa don len grp.
                //txtMaHDBan.Text = _HDBan.I_MaHDB.ToString();
                //dtNgayLap.EditValue = _HDBan.DT_NgayBan;
                //lookUpEdit_TenNV.EditValue = _HDBan.STR_MaNV;
                //lookUpEdit_TenKH.EditValue = _HDBan.STR_MaKH;
                //txtTongTien.Text = _HDBan.DEC_TongTien.ToString();

                //// Load du lieu loai san pham.
                //_LST_DSLSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
                //loadDSLoaiSanPham(_LST_DSLSP);

                //// Load DS san pham vao gridview.
                //if (_Bill != null)
                //{
                //    _LST_DSSanPhamBan = SanPhamBan_BUS.loadDSSanPhamBan_MaHDB_BUS(_HDBan.I_MaHDB);
                //    gcDSCTHDBan.DataSource = _LST_DSSanPhamBan;
                //}
            }
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            //DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCTHDBan_Click(object sender, EventArgs e)
        {

        }

        private void gvDSCTHDBan_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSCTHDBan.SelectedRowsCount > 0)
            {
                _ProductCurrent = (SanPhamBan_DTO)gvDSCTHDBan.GetRow(gvDSCTHDBan.FocusedRowHandle);
                _LstIMEIList = IMEI_BUS.loadDSIMEIThaoHDB_BUS(_ProductCurrent., _Bill.IBillID);
                gcDSMaIMEI.DataSource = _LST_DSIMEI;
            }
        }
        #endregion
    }
}
