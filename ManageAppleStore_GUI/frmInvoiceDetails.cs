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
    public partial class frmInvoiceDetails : Form
    {
        public frmInvoiceDetails()
        {
            InitializeComponent();
        }
        #region Properties
        private InvoiceDTO _Invoice = new InvoiceDTO();

        public InvoiceDTO Invoice { get => _Invoice; set => _Invoice = value; }

        BindingList<EmployeesDTO> _LstEmployeeList = new BindingList<EmployeesDTO>();
        BindingList<InvoiceDetailDTO> _LstInvoiceDetailList = new BindingList<InvoiceDetailDTO>();
        BindingList<ProductsDTO> _LstProductList = new BindingList<ProductsDTO>();
        BindingList<ProductOfTypesDTO> _LstProductTypeList = new BindingList<ProductOfTypesDTO>();
        #endregion
        #region Methods
        private bool _BIndicatorIcon = true;

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
                if (!_BIndicatorIcon)
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

        // Load du lieu nhan vien.
        void loadEmployeeList(BindingList<EmployeesDTO> LstEmploy)
        {
            lookUpEdit_TenNV.Properties.DataSource = LstEmploy;
            lookUpEdit_TenNV.Properties.Columns["colTenNV"].FieldName = "StrFullName";
        }

        void loadEmployeeTypeList(BindingList<ProductOfTypesDTO> _LstProductTypeList)
        {
            LookUpEdit_LoaiSP.DataSource = _LstProductTypeList;
            LookUpEdit_LoaiSP.Columns["colMaLoaiSP"].FieldName = "strMaLoaiSP";
            LookUpEdit_LoaiSP.Columns["colTenLoaiSP"].FieldName = "strTenLoaiSP";
        }

        void loadInvoiceList(int _IBillID, BindingList<InvoiceDetailDTO> _LstInvoiceDetailList, BindingList<ProductsDTO> _LstProductList)
        {

        }
        #endregion
        #region Events
        private void frmInvoiceDetails_Load(object serder, EventArgs e)
        {
            /*Designs Form*/
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            /*Designs Form*/

            if (_Invoice != null)
            {
                //// Load du lieu nhan vien.
                //_LstEmployeeList = EmployeesBu.loadDSNV_BUS();
                //loadDSNhanVien(_LST_DSNhanVien);

                //// Load du lieu hoa don len grp.
                //txtMaHDNhap.Text = _HDNhap.I_MaHDN.ToString();
                //dtNgayLap.EditValue = _HDNhap.DT_NgayLap;
                //lookUpEdit_TenNV.EditValue = _HDNhap.STR_MaNV;
                //txtTongTien.Text = _HDNhap.DEC_TongTien.ToString();

                //// Load du lieu loai san pham.
                //_LST_DSLSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
                //loadDSLoaiSanPham(_LST_DSLSP);

                // Load DS san pham vao gridview.
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
        #endregion
    }
}
