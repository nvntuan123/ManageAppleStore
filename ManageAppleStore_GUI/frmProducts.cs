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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        #region Properties

        #endregion
        #region Methods
        #endregion
        #region Events
        private void frmQLSP_Load(object sender, EventArgs e)
        {
            try
            {
                #region Designs form
                this.Visible = false;
                Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

                this.CenterToScreen();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && ((Keys)e.KeyChar != Keys.Back) && ((Keys)e.KeyChar != Keys.Enter))
            {
                e.Handled = true;
                txtSalePrice.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var _DLG_OpenExcel = new OpenFileDialog();
            //    _DLG_OpenExcel.Title = @"Import File Excel";
            //    //_DLG_OpenExcel.FileName =
            //    _DLG_OpenExcel.Filter = @"Microsoft Excel|*.xlsx";
            //    if (_DLG_OpenExcel.ShowDialog() == DialogResult.OK)
            //    {
            //        //MessageBox.Show(Path.GetExtension(_DLG_OpenExcel.FileName)); // Lấy ra đuôi file. VD: abc.png => lấy ra tên đuôi file là .png
            //        //MessageBox.Show(Path.GetFileName(_DLG_OpenExcel.FileName)); // Lấy ra tền file + đuôi file VD: abc.png => lấy hết là abc.png
            //        //MessageBox.Show(Path.GetFileNameWithoutExtension(_DLG_OpenExcel.FileName)); // Lấy ra tên file k bao gồm đuôi file VD: abc.png => lấy phần abc.
            //        string _STR_FileName = Path.GetFileName(_DLG_OpenExcel.FileName);
            //        // Mở file excel
            //        var package = new ExcelPackage(new FileInfo(_DLG_OpenExcel.FileName));

            //        // Lấy ra sheet đầu tiên để thao tác.
            //        ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

            //        BindingList<SanPham_DTO> _LST_DSSP_ImportExcel = new BindingList<SanPham_DTO>();
            //        #region
            //        // Duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file Excel.Vì Excel bắt đầu từ số 1 không phải số 0.
            //        for (int i = workSheet.Dimension.Start.Row + 1; i < workSheet.Dimension.End.Row; ++i)
            //        {
            //            try
            //            {
            //                int j = 1; // Biến j như là cột.

            //                string _STR_MaSP = "";
            //                string _STR_TenSP = "";
            //                DateTime _DT_NamSX = new DateTime();
            //                string _STR_MaLoaiSP = "";
            //                decimal _DEC_GiaBan = 0;

            //                if (workSheet.Cells[i, j].Value == null || workSheet.Cells[i, (j + 1)].Value == null) // Kiem tra ma rong
            //                    continue;

            //                // Kiem tra trung ma sp.
            //                bool _B_CheckMaSP = false;
            //                foreach (SanPham_DTO sp in lstSP)
            //                {
            //                    if (sp.strMaSP == workSheet.Cells[i, j].Value.ToString())
            //                    {
            //                        _B_CheckMaSP = true;
            //                        break;
            //                    }
            //                }

            //                if (_B_CheckMaSP)
            //                    continue;

            //                _STR_MaSP = workSheet.Cells[i, j++].Value.ToString();
            //                _STR_TenSP = workSheet.Cells[i, j++].Value.ToString();

            //                var _VAR_NamSX = workSheet.Cells[i, j++].Value;
            //                if (_VAR_NamSX != null)
            //                    _DT_NamSX = (DateTime)_VAR_NamSX;

            //                if (workSheet.Cells[i, j].Value != null)
            //                    _STR_MaLoaiSP = workSheet.Cells[i, j++].Value.ToString();
            //                else
            //                    j++;

            //                string _STR_GiaBan = "";
            //                if (workSheet.Cells[i, j].Value != null)
            //                    _STR_GiaBan = workSheet.Cells[i, j++].Value.ToString();

            //                bool _B_Check = false;
            //                if (_STR_GiaBan != "")
            //                {
            //                    foreach (char c in _STR_GiaBan.ToCharArray())
            //                    {
            //                        if (c < '0' || c > '9')
            //                        {
            //                            _B_Check = true;
            //                            break;
            //                        }
            //                    }
            //                }

            //                if (!_B_Check && _STR_GiaBan != "")
            //                    _DEC_GiaBan = decimal.Parse(_STR_GiaBan);

            //                //MessageBox.Show(_STR_MaSP);
            //                //MessageBox.Show(_STR_TenSP);
            //                //MessageBox.Show(_DT_NamSX.ToString());
            //                //MessageBox.Show(_STR_MaLoaiSP);
            //                //MessageBox.Show(_DEC_GiaBan.ToString());
            //                SanPham_DTO _SP_ExcelAdd = new SanPham_DTO()
            //                {
            //                    strMaSP = _STR_MaSP,
            //                    strTenSP = _STR_TenSP,
            //                    dtNamSX = _DT_NamSX,
            //                    strMaLoaiSP = _STR_MaLoaiSP,
            //                    decGiaBan = _DEC_GiaBan
            //                };

            //                //Add vao list.
            //                lstSP.Add(_SP_ExcelAdd);

            //                _LST_DSSP_ImportExcel.Add(_SP_ExcelAdd);
            //            }
            //            catch (Exception ex)
            //            {
            //                DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        #endregion
            //        if (_LST_DSSP_ImportExcel.Count > 0)
            //        {
            //            foreach (SanPham_DTO sp in _LST_DSSP_ImportExcel)
            //            {
            //                SanPham_BUS.themSanPham_BUS(sp);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (gvDSSP.RowCount > 0)
            //    {
            //        SaveFileDialog dialog = new SaveFileDialog();
            //        dialog.Title = "Export File Excel";
            //        dialog.FileName = "";
            //        dialog.Filter = @"Micrsoft Excel|*.xlsx";

            //        if (dialog.ShowDialog() == DialogResult.OK)
            //        {
            //            gvDSSP.ColumnPanelRowHeight = 40; // Chinh do cao cua row.
            //            gvDSSP.OptionsPrint.AutoWidth = AutoSize;
            //            gvDSSP.OptionsPrint.ShowPrintExportProgress = true;
            //            gvDSSP.OptionsPrint.AllowCancelPrintExport = true;
            //            DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions();
            //            options.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
            //            options.ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFile;
            //            options.SheetName = "DSSP";
            //            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.Default;
            //            gvDSSP.ExportToXlsx(dialog.FileName, options);

            //            if (File.Exists(dialog.FileName))
            //            {
            //                if (DevExpress.XtraEditors.XtraMessageBox.Show("Mở File Excel Vừa Tạo ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //                {
            //                    System.Diagnostics.Process.Start(dialog.FileName);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch
            //{

            //}
        }
        #endregion
    }
}
