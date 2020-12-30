
namespace ManageAppleStore_GUI
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpThongTinChiTiet = new DevExpress.XtraEditors.GroupControl();
            this.btnModelDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnIMEI_ID = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.dtYearOfProdcut = new DevExpress.XtraEditors.DateEdit();
            this.cmbProductOfType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.btnEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gcProductList = new DevExpress.XtraGrid.GridControl();
            this.gvProductList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_LoaiSP = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemDateEdit_NamSX = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.LookUpEdit_MauSac = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinChiTiet)).BeginInit();
            this.grpThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYearOfProdcut.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYearOfProdcut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductOfType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_LoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_MauSac)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpThongTinChiTiet
            // 
            this.grpThongTinChiTiet.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinChiTiet.AppearanceCaption.Options.UseFont = true;
            this.grpThongTinChiTiet.Controls.Add(this.btnModelDetail);
            this.grpThongTinChiTiet.Controls.Add(this.btnIMEI_ID);
            this.grpThongTinChiTiet.Controls.Add(this.label3);
            this.grpThongTinChiTiet.Controls.Add(this.txtName);
            this.grpThongTinChiTiet.Controls.Add(this.dtYearOfProdcut);
            this.grpThongTinChiTiet.Controls.Add(this.cmbProductOfType);
            this.grpThongTinChiTiet.Controls.Add(this.txtSalePrice);
            this.grpThongTinChiTiet.Controls.Add(this.txtQuantity);
            this.grpThongTinChiTiet.Controls.Add(this.txtID);
            this.grpThongTinChiTiet.Controls.Add(this.label5);
            this.grpThongTinChiTiet.Controls.Add(this.label8);
            this.grpThongTinChiTiet.Controls.Add(this.label7);
            this.grpThongTinChiTiet.Controls.Add(this.label1);
            this.grpThongTinChiTiet.Controls.Add(this.label2);
            this.grpThongTinChiTiet.Location = new System.Drawing.Point(9, 9);
            this.grpThongTinChiTiet.Name = "grpThongTinChiTiet";
            this.grpThongTinChiTiet.Size = new System.Drawing.Size(768, 158);
            this.grpThongTinChiTiet.TabIndex = 0;
            this.grpThongTinChiTiet.Text = "Thông Tin Sản Phẩm";
            // 
            // btnModelDetail
            // 
            this.btnModelDetail.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModelDetail.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnModelDetail.Appearance.Options.UseBackColor = true;
            this.btnModelDetail.Appearance.Options.UseFont = true;
            this.btnModelDetail.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnModelDetail.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelDetail.AppearanceHovered.Options.UseBackColor = true;
            this.btnModelDetail.AppearanceHovered.Options.UseFont = true;
            this.btnModelDetail.Location = new System.Drawing.Point(604, 109);
            this.btnModelDetail.Name = "btnModelDetail";
            this.btnModelDetail.Size = new System.Drawing.Size(153, 33);
            this.btnModelDetail.TabIndex = 51;
            this.btnModelDetail.Text = "Cấu Hình Chi Tiết";
            // 
            // btnIMEI_ID
            // 
            this.btnIMEI_ID.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnIMEI_ID.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIMEI_ID.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnIMEI_ID.Appearance.Options.UseBackColor = true;
            this.btnIMEI_ID.Appearance.Options.UseFont = true;
            this.btnIMEI_ID.Appearance.Options.UseForeColor = true;
            this.btnIMEI_ID.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnIMEI_ID.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMEI_ID.AppearanceHovered.Options.UseBackColor = true;
            this.btnIMEI_ID.AppearanceHovered.Options.UseFont = true;
            this.btnIMEI_ID.Location = new System.Drawing.Point(436, 109);
            this.btnIMEI_ID.Name = "btnIMEI_ID";
            this.btnIMEI_ID.Size = new System.Drawing.Size(109, 33);
            this.btnIMEI_ID.TabIndex = 50;
            this.btnIMEI_ID.Text = "Mã IMEI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(422, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Năm sản xuất";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 58);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(219, 24);
            this.txtName.TabIndex = 48;
            // 
            // dtYearOfProdcut
            // 
            this.dtYearOfProdcut.EditValue = new System.DateTime(2019, 5, 24, 14, 39, 31, 102);
            this.dtYearOfProdcut.Location = new System.Drawing.Point(538, 58);
            this.dtYearOfProdcut.Name = "dtYearOfProdcut";
            this.dtYearOfProdcut.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtYearOfProdcut.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtYearOfProdcut.Properties.Appearance.Options.UseBackColor = true;
            this.dtYearOfProdcut.Properties.Appearance.Options.UseFont = true;
            this.dtYearOfProdcut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtYearOfProdcut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtYearOfProdcut.Size = new System.Drawing.Size(150, 24);
            this.dtYearOfProdcut.TabIndex = 7;
            // 
            // cmbProductOfType
            // 
            this.cmbProductOfType.Location = new System.Drawing.Point(126, 88);
            this.cmbProductOfType.Name = "cmbProductOfType";
            this.cmbProductOfType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbProductOfType.Properties.Appearance.Options.UseFont = true;
            this.cmbProductOfType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbProductOfType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbProductOfType.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbProductOfType.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbProductOfType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductOfType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenLoaiSP", "Loại Sản Phẩm")});
            this.cmbProductOfType.Properties.NullText = "Loại Sản Phẩm";
            this.cmbProductOfType.Size = new System.Drawing.Size(219, 24);
            this.cmbProductOfType.TabIndex = 2;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(538, 28);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSalePrice.Properties.Appearance.Options.UseFont = true;
            this.txtSalePrice.Size = new System.Drawing.Size(219, 24);
            this.txtSalePrice.TabIndex = 5;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(126, 118);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Size = new System.Drawing.Size(174, 24);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 28);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(174, 24);
            this.txtID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(466, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã sản phẩm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.lblRefresh);
            this.panel3.Controls.Add(this.lblQuayLai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 39);
            this.panel3.TabIndex = 8;
            // 
            // lblRefresh
            // 
            this.lblRefresh.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblRefresh.Appearance.Options.UseBorderColor = true;
            this.lblRefresh.Appearance.Options.UseImage = true;
            this.lblRefresh.AppearanceHovered.Options.UseImage = true;
            this.lblRefresh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRefresh.ImageOptions.HoveredImage = ((System.Drawing.Image)(resources.GetObject("lblRefresh.ImageOptions.HoveredImage")));
            this.lblRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblRefresh.ImageOptions.Image")));
            this.lblRefresh.Location = new System.Drawing.Point(1056, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(74, 39);
            this.lblRefresh.TabIndex = 15;
            this.lblRefresh.ToolTip = "Làm mới";
            // 
            // lblQuayLai
            // 
            this.lblQuayLai.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuayLai.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuayLai.Appearance.Options.UseFont = true;
            this.lblQuayLai.Appearance.Options.UseImage = true;
            this.lblQuayLai.Appearance.Options.UseImageAlign = true;
            this.lblQuayLai.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(106)))), ((int)(((byte)(111)))));
            this.lblQuayLai.AppearanceHovered.Options.UseBackColor = true;
            this.lblQuayLai.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblQuayLai.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblQuayLai.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblQuayLai.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblQuayLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblQuayLai.ImageOptions.Image")));
            this.lblQuayLai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblQuayLai.Location = new System.Drawing.Point(0, 0);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(182, 39);
            this.lblQuayLai.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.lblHienThi);
            this.panel4.Controls.Add(this.btnEditProduct);
            this.panel4.Controls.Add(this.btnDeleteProduct);
            this.panel4.Controls.Add(this.btnAddProduct);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 526);
            this.panel4.TabIndex = 9;
            // 
            // lblHienThi
            // 
            this.lblHienThi.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblHienThi.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHienThi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHienThi.Appearance.Options.UseBackColor = true;
            this.lblHienThi.Appearance.Options.UseFont = true;
            this.lblHienThi.Appearance.Options.UseForeColor = true;
            this.lblHienThi.Appearance.Options.UseTextOptions = true;
            this.lblHienThi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHienThi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHienThi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblHienThi.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblHienThi.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblHienThi.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblHienThi.LineVisible = true;
            this.lblHienThi.Location = new System.Drawing.Point(14, 180);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(157, 38);
            this.lblHienThi.TabIndex = 23;
            this.lblHienThi.Text = "Quản Lý Sản Phẩm";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProduct.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProduct.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditProduct.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Appearance.Options.UseBackColor = true;
            this.btnEditProduct.Appearance.Options.UseFont = true;
            this.btnEditProduct.Appearance.Options.UseForeColor = true;
            this.btnEditProduct.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnEditProduct.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditProduct.AppearanceHovered.Options.UseBackColor = true;
            this.btnEditProduct.AppearanceHovered.Options.UseFont = true;
            this.btnEditProduct.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEditProduct.Location = new System.Drawing.Point(0, 405);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(183, 62);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Sửa";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteProduct.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Appearance.Options.UseBackColor = true;
            this.btnDeleteProduct.Appearance.Options.UseFont = true;
            this.btnDeleteProduct.Appearance.Options.UseForeColor = true;
            this.btnDeleteProduct.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteProduct.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteProduct.AppearanceHovered.Options.UseBackColor = true;
            this.btnDeleteProduct.AppearanceHovered.Options.UseFont = true;
            this.btnDeleteProduct.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDeleteProduct.Location = new System.Drawing.Point(0, 324);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(183, 62);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Xóa";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddProduct.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Appearance.Options.UseBackColor = true;
            this.btnAddProduct.Appearance.Options.UseFont = true;
            this.btnAddProduct.Appearance.Options.UseForeColor = true;
            this.btnAddProduct.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnAddProduct.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddProduct.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddProduct.AppearanceHovered.Options.UseFont = true;
            this.btnAddProduct.AppearanceHovered.Options.UseForeColor = true;
            this.btnAddProduct.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 243);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(183, 62);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Thêm ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.Location = new System.Drawing.Point(791, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnImportExcel);
            this.panel1.Controls.Add(this.gcProductList);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.grpThongTinChiTiet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(183, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 526);
            this.panel1.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnExportExcel.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportExcel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Appearance.Options.UseBackColor = true;
            this.btnExportExcel.Appearance.Options.UseFont = true;
            this.btnExportExcel.Appearance.Options.UseForeColor = true;
            this.btnExportExcel.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnExportExcel.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportExcel.AppearanceHovered.Options.UseBackColor = true;
            this.btnExportExcel.AppearanceHovered.Options.UseFont = true;
            this.btnExportExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExportExcel.Location = new System.Drawing.Point(791, 122);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(144, 45);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "Xuất File Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportExcel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnImportExcel.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImportExcel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Appearance.Options.UseBackColor = true;
            this.btnImportExcel.Appearance.Options.UseFont = true;
            this.btnImportExcel.Appearance.Options.UseForeColor = true;
            this.btnImportExcel.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnImportExcel.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.AppearanceHovered.Options.UseBackColor = true;
            this.btnImportExcel.AppearanceHovered.Options.UseFont = true;
            this.btnImportExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnImportExcel.Location = new System.Drawing.Point(791, 63);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(144, 45);
            this.btnImportExcel.TabIndex = 2;
            this.btnImportExcel.Text = "Thêm File Excel";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // gcProductList
            // 
            this.gcProductList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gcProductList.Location = new System.Drawing.Point(9, 173);
            this.gcProductList.MainView = this.gvProductList;
            this.gcProductList.Name = "gcProductList";
            this.gcProductList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_LoaiSP,
            this.ItemDateEdit_NamSX,
            this.LookUpEdit_MauSac});
            this.gcProductList.Size = new System.Drawing.Size(935, 347);
            this.gcProductList.TabIndex = 1;
            this.gcProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductList});
            // 
            // gvProductList
            // 
            this.gvProductList.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProductList.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvProductList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvProductList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProductList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProductList.Appearance.EvenRow.Options.UseFont = true;
            this.gvProductList.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProductList.Appearance.FooterPanel.Options.UseFont = true;
            this.gvProductList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvProductList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gvProductList.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvProductList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProductList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProductList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvProductList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProductList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProductList.Appearance.OddRow.Options.UseFont = true;
            this.gvProductList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProductList.Appearance.Row.Options.UseFont = true;
            this.gvProductList.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvProductList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProductList.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvProductList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvProductList.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProductList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gvProductList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoaiSP,
            this.colGiaBan,
            this.colSoLuong,
            this.colNamSX});
            this.gvProductList.GridControl = this.gcProductList;
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.OptionsBehavior.Editable = false;
            this.gvProductList.OptionsSelection.MultiSelect = true;
            this.gvProductList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProductList.OptionsView.EnableAppearanceOddRow = true;
            this.gvProductList.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gvProductList.OptionsView.ShowAutoFilterRow = true;
            this.gvProductList.OptionsView.ShowFooter = true;
            this.gvProductList.OptionsView.ShowGroupPanel = false;
            this.gvProductList.OptionsView.ShowIndicator = false;
            this.gvProductList.OptionsView.ShowViewCaption = true;
            this.gvProductList.ViewCaption = "Danh Sách Sản Phẩm";
            // 
            // colMaSP
            // 
            this.colMaSP.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaSP.AppearanceCell.Options.UseFont = true;
            this.colMaSP.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaSP.AppearanceHeader.Options.UseFont = true;
            this.colMaSP.Caption = "Mã Sản Phẩm";
            this.colMaSP.FieldName = "strMaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            this.colMaSP.Width = 111;
            // 
            // colTenSP
            // 
            this.colTenSP.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSP.AppearanceCell.Options.UseFont = true;
            this.colTenSP.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSP.AppearanceHeader.Options.UseFont = true;
            this.colTenSP.Caption = "Tên Sản Phẩm";
            this.colTenSP.FieldName = "strTenSP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            this.colTenSP.Width = 162;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLoaiSP.AppearanceCell.Options.UseFont = true;
            this.colLoaiSP.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLoaiSP.AppearanceHeader.Options.UseFont = true;
            this.colLoaiSP.Caption = "Loại Sản Phẩm";
            this.colLoaiSP.ColumnEdit = this.LookUpEdit_LoaiSP;
            this.colLoaiSP.FieldName = "strMaLoaiSP";
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.Visible = true;
            this.colLoaiSP.VisibleIndex = 2;
            this.colLoaiSP.Width = 144;
            // 
            // LookUpEdit_LoaiSP
            // 
            this.LookUpEdit_LoaiSP.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_LoaiSP.AppearanceDropDown.Options.UseFont = true;
            this.LookUpEdit_LoaiSP.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_LoaiSP.AppearanceDropDownHeader.Options.UseFont = true;
            this.LookUpEdit_LoaiSP.AutoHeight = false;
            this.LookUpEdit_LoaiSP.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_LoaiSP.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaLoaiSP", "Mã Loại Sản Phẩm", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenLoaiSP", "Loại Sản Phẩm")});
            this.LookUpEdit_LoaiSP.DisplayMember = "strTenLoaiSP";
            this.LookUpEdit_LoaiSP.Name = "LookUpEdit_LoaiSP";
            this.LookUpEdit_LoaiSP.NullText = "Loại Sản Phẩm";
            this.LookUpEdit_LoaiSP.ValueMember = "strMaLoaiSP";
            // 
            // colGiaBan
            // 
            this.colGiaBan.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGiaBan.AppearanceCell.Options.UseFont = true;
            this.colGiaBan.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGiaBan.AppearanceHeader.Options.UseFont = true;
            this.colGiaBan.Caption = "Giá Bán";
            this.colGiaBan.DisplayFormat.FormatString = "c";
            this.colGiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiaBan.FieldName = "decGiaBan";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "decGiaBan", "Tổng Tiền = {0:c}")});
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 3;
            this.colGiaBan.Width = 230;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSoLuong.AppearanceCell.Options.UseFont = true;
            this.colSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colSoLuong.Caption = "SL";
            this.colSoLuong.FieldName = "iSoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            this.colSoLuong.Width = 44;
            // 
            // colNamSX
            // 
            this.colNamSX.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNamSX.AppearanceCell.Options.UseFont = true;
            this.colNamSX.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNamSX.AppearanceHeader.Options.UseFont = true;
            this.colNamSX.Caption = "Năm Sản Xuất";
            this.colNamSX.ColumnEdit = this.ItemDateEdit_NamSX;
            this.colNamSX.FieldName = "dtNamSX";
            this.colNamSX.Name = "colNamSX";
            this.colNamSX.Visible = true;
            this.colNamSX.VisibleIndex = 5;
            this.colNamSX.Width = 140;
            // 
            // ItemDateEdit_NamSX
            // 
            this.ItemDateEdit_NamSX.AutoHeight = false;
            this.ItemDateEdit_NamSX.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemDateEdit_NamSX.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemDateEdit_NamSX.Name = "ItemDateEdit_NamSX";
            // 
            // LookUpEdit_MauSac
            // 
            this.LookUpEdit_MauSac.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_MauSac.AppearanceDropDown.Options.UseFont = true;
            this.LookUpEdit_MauSac.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_MauSac.AppearanceDropDownHeader.Options.UseFont = true;
            this.LookUpEdit_MauSac.AutoHeight = false;
            this.LookUpEdit_MauSac.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_MauSac.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaMau", "Mã Màu", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenMau", "Tên Màu")});
            this.LookUpEdit_MauSac.DisplayMember = "strTenMau";
            this.LookUpEdit_MauSac.Name = "LookUpEdit_MauSac";
            this.LookUpEdit_MauSac.NullText = "Màu Sắc";
            this.LookUpEdit_MauSac.ValueMember = "iMaMau";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmQLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinChiTiet)).EndInit();
            this.grpThongTinChiTiet.ResumeLayout(false);
            this.grpThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYearOfProdcut.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYearOfProdcut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductOfType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_LoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_MauSac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.GroupControl grpThongTinChiTiet;
        private DevExpress.XtraEditors.LookUpEdit cmbProductOfType;
        private DevExpress.XtraEditors.TextEdit txtSalePrice;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEditProduct;
        private DevExpress.XtraEditors.SimpleButton btnDeleteProduct;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private DevExpress.XtraGrid.GridControl gcProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductList;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiSP;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_LoaiSP;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
        private DevExpress.XtraEditors.DateEdit dtYearOfProdcut;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSX;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ItemDateEdit_NamSX;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnIMEI_ID;
        private DevExpress.XtraEditors.SimpleButton btnModelDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_MauSac;
        private DevExpress.XtraEditors.SimpleButton btnImportExcel;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
    }
}