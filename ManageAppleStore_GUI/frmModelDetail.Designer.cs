
namespace ManageAppleStore_GUI
{
    partial class frmModelDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelDetail));
            this.repositoryItemLookUpEdit_MaModel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ItemMemoEdit_MoTaModel = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gcModelDetailList = new DevExpress.XtraGrid.GridControl();
            this.gvModelDetailList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThongSoKyThuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpThongTinSanPham = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.dtYearOfProduct = new DevExpress.XtraEditors.DateEdit();
            this.txtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtProductID = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblThemModel = new DevExpress.XtraEditors.LabelControl();
            this.cmbModel = new DevExpress.XtraEditors.LookUpEdit();
            this.mmeDescription = new DevExpress.XtraEditors.MemoEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSpecifications = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_MaModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemMemoEdit_MoTaModel)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcModelDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModelDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinSanPham)).BeginInit();
            this.grpThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYearOfProduct.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYearOfProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpecifications.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit_MaModel
            // 
            this.repositoryItemLookUpEdit_MaModel.AutoHeight = false;
            this.repositoryItemLookUpEdit_MaModel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_MaModel.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenModel", "Tên Model")});
            this.repositoryItemLookUpEdit_MaModel.DisplayMember = "strTenModel";
            this.repositoryItemLookUpEdit_MaModel.Name = "repositoryItemLookUpEdit_MaModel";
            this.repositoryItemLookUpEdit_MaModel.NullText = "Tên Model";
            this.repositoryItemLookUpEdit_MaModel.ValueMember = "strMaModel";
            // 
            // ItemMemoEdit_MoTaModel
            // 
            this.ItemMemoEdit_MoTaModel.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ItemMemoEdit_MoTaModel.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ItemMemoEdit_MoTaModel.MaxLength = 100000;
            this.ItemMemoEdit_MoTaModel.Name = "ItemMemoEdit_MoTaModel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblRefresh);
            this.panel2.Controls.Add(this.lblQuayLai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 39);
            this.panel2.TabIndex = 11;
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
            this.lblRefresh.Location = new System.Drawing.Point(933, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(74, 39);
            this.lblRefresh.TabIndex = 17;
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
            this.lblQuayLai.Location = new System.Drawing.Point(0, 0);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(182, 39);
            this.lblQuayLai.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblHienThi);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 528);
            this.panel1.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnDelete.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseBorderColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.Location = new System.Drawing.Point(1, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 53);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Appearance.Options.UseForeColor = true;
            this.btnEdit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnEdit.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnEdit.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.AppearanceHovered.Options.UseBackColor = true;
            this.btnEdit.AppearanceHovered.Options.UseBorderColor = true;
            this.btnEdit.AppearanceHovered.Options.UseFont = true;
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEdit.Location = new System.Drawing.Point(1, 427);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 53);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Sửa";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnAdd.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnAdd.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseBorderColor = true;
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdd.Location = new System.Drawing.Point(0, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 53);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm";
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
            this.lblHienThi.Location = new System.Drawing.Point(13, 161);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(157, 64);
            this.lblHienThi.TabIndex = 18;
            this.lblHienThi.Text = "Chi Tiết Cấu Hình\r\nSản Phẩm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSave.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.Location = new System.Drawing.Point(343, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 31;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            // 
            // gcModelDetailList
            // 
            this.gcModelDetailList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcModelDetailList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcModelDetailList.Location = new System.Drawing.Point(188, 247);
            this.gcModelDetailList.MainView = this.gvModelDetailList;
            this.gcModelDetailList.Name = "gcModelDetailList";
            this.gcModelDetailList.Size = new System.Drawing.Size(816, 316);
            this.gcModelDetailList.TabIndex = 16;
            this.gcModelDetailList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvModelDetailList});
            // 
            // gvModelDetailList
            // 
            this.gvModelDetailList.Appearance.Empty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvModelDetailList.Appearance.Empty.Options.UseFont = true;
            this.gvModelDetailList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelDetailList.Appearance.EvenRow.Options.UseFont = true;
            this.gvModelDetailList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvModelDetailList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvModelDetailList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelDetailList.Appearance.OddRow.Options.UseFont = true;
            this.gvModelDetailList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelDetailList.Appearance.Row.Options.UseFont = true;
            this.gvModelDetailList.Appearance.TopNewRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelDetailList.Appearance.TopNewRow.Options.UseFont = true;
            this.gvModelDetailList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvModelDetailList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvModelDetailList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenModel,
            this.colMaSP,
            this.colThongSoKyThuat,
            this.colMoTa});
            this.gvModelDetailList.GridControl = this.gcModelDetailList;
            this.gvModelDetailList.Name = "gvModelDetailList";
            this.gvModelDetailList.NewItemRowText = "Thêm Mới";
            this.gvModelDetailList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvModelDetailList.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvModelDetailList.OptionsBehavior.Editable = false;
            this.gvModelDetailList.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvModelDetailList.OptionsSelection.MultiSelect = true;
            this.gvModelDetailList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvModelDetailList.OptionsView.RowAutoHeight = true;
            this.gvModelDetailList.OptionsView.ShowAutoFilterRow = true;
            this.gvModelDetailList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvModelDetailList.OptionsView.ShowGroupPanel = false;
            this.gvModelDetailList.OptionsView.ShowIndicator = false;
            this.gvModelDetailList.OptionsView.ShowViewCaption = true;
            this.gvModelDetailList.ViewCaption = "Chi Tiết Cấu Hình Sản Phẩm";
            // 
            // colTenModel
            // 
            this.colTenModel.Caption = "Tên Model";
            this.colTenModel.ColumnEdit = this.repositoryItemLookUpEdit_MaModel;
            this.colTenModel.FieldName = "strMaModel";
            this.colTenModel.Name = "colTenModel";
            this.colTenModel.Visible = true;
            this.colTenModel.VisibleIndex = 0;
            this.colTenModel.Width = 155;
            // 
            // colMaSP
            // 
            this.colMaSP.Caption = "Mã Sản Phẩm";
            this.colMaSP.FieldName = "strMaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Width = 114;
            // 
            // colThongSoKyThuat
            // 
            this.colThongSoKyThuat.Caption = "Thông Số Kỹ Thuật";
            this.colThongSoKyThuat.FieldName = "strThongSoKyThuat";
            this.colThongSoKyThuat.Name = "colThongSoKyThuat";
            this.colThongSoKyThuat.Visible = true;
            this.colThongSoKyThuat.VisibleIndex = 1;
            this.colThongSoKyThuat.Width = 245;
            // 
            // colMoTa
            // 
            this.colMoTa.Caption = "Mô Tả";
            this.colMoTa.ColumnEdit = this.ItemMemoEdit_MoTaModel;
            this.colMoTa.FieldName = "strMoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Width = 418;
            // 
            // grpThongTinSanPham
            // 
            this.grpThongTinSanPham.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinSanPham.Appearance.Options.UseFont = true;
            this.grpThongTinSanPham.AppearanceCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinSanPham.AppearanceCaption.Options.UseFont = true;
            this.grpThongTinSanPham.Controls.Add(this.label3);
            this.grpThongTinSanPham.Controls.Add(this.txtProductName);
            this.grpThongTinSanPham.Controls.Add(this.dtYearOfProduct);
            this.grpThongTinSanPham.Controls.Add(this.txtSalePrice);
            this.grpThongTinSanPham.Controls.Add(this.txtQuantity);
            this.grpThongTinSanPham.Controls.Add(this.txtProductID);
            this.grpThongTinSanPham.Controls.Add(this.label5);
            this.grpThongTinSanPham.Controls.Add(this.label8);
            this.grpThongTinSanPham.Controls.Add(this.label1);
            this.grpThongTinSanPham.Controls.Add(this.label2);
            this.grpThongTinSanPham.Location = new System.Drawing.Point(642, 45);
            this.grpThongTinSanPham.Name = "grpThongTinSanPham";
            this.grpThongTinSanPham.Size = new System.Drawing.Size(362, 196);
            this.grpThongTinSanPham.TabIndex = 17;
            this.grpThongTinSanPham.Text = "Thông Tin Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Năm sản xuất";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(126, 59);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Size = new System.Drawing.Size(225, 24);
            this.txtProductName.TabIndex = 48;
            // 
            // dtYearOfProduct
            // 
            this.dtYearOfProduct.EditValue = new System.DateTime(2019, 5, 24, 14, 39, 31, 102);
            this.dtYearOfProduct.Location = new System.Drawing.Point(126, 119);
            this.dtYearOfProduct.Name = "dtYearOfProduct";
            this.dtYearOfProduct.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtYearOfProduct.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtYearOfProduct.Properties.Appearance.Options.UseBackColor = true;
            this.dtYearOfProduct.Properties.Appearance.Options.UseFont = true;
            this.dtYearOfProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtYearOfProduct.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtYearOfProduct.Size = new System.Drawing.Size(102, 24);
            this.dtYearOfProduct.TabIndex = 7;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(126, 89);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSalePrice.Properties.Appearance.Options.UseFont = true;
            this.txtSalePrice.Size = new System.Drawing.Size(225, 24);
            this.txtSalePrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(126, 152);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Size = new System.Drawing.Size(102, 24);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(126, 29);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProductID.Properties.Appearance.Options.UseFont = true;
            this.txtProductID.Size = new System.Drawing.Size(174, 24);
            this.txtProductID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(50, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Giá bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã sản phẩm";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lblThemModel);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.cmbModel);
            this.groupControl1.Controls.Add(this.mmeDescription);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtSpecifications);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Location = new System.Drawing.Point(188, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(448, 196);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Thông Tin Sản Phẩm";
            // 
            // lblThemModel
            // 
            this.lblThemModel.Appearance.Options.UseImage = true;
            this.lblThemModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lblThemModel.AppearanceHovered.Options.UseBackColor = true;
            this.lblThemModel.Location = new System.Drawing.Point(272, 32);
            this.lblThemModel.Name = "lblThemModel";
            this.lblThemModel.Size = new System.Drawing.Size(0, 13);
            this.lblThemModel.TabIndex = 19;
            // 
            // cmbModel
            // 
            this.cmbModel.Location = new System.Drawing.Point(101, 28);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbModel.Properties.Appearance.Options.UseFont = true;
            this.cmbModel.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbModel.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbModel.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbModel.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbModel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenModel", "Tên Model")});
            this.cmbModel.Properties.DisplayMember = "strTenModel";
            this.cmbModel.Properties.NullText = "Tên Model";
            this.cmbModel.Properties.ValueMember = "strMaModel";
            this.cmbModel.Size = new System.Drawing.Size(162, 24);
            this.cmbModel.TabIndex = 57;
            // 
            // mmeDescription
            // 
            this.mmeDescription.Location = new System.Drawing.Point(101, 92);
            this.mmeDescription.Name = "mmeDescription";
            this.mmeDescription.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mmeDescription.Properties.Appearance.Options.UseFont = true;
            this.mmeDescription.Size = new System.Drawing.Size(342, 101);
            this.mmeDescription.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(35, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Mô Tả";
            // 
            // txtSpecifications
            // 
            this.txtSpecifications.Location = new System.Drawing.Point(101, 59);
            this.txtSpecifications.Name = "txtSpecifications";
            this.txtSpecifications.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSpecifications.Properties.Appearance.Options.UseFont = true;
            this.txtSpecifications.Size = new System.Drawing.Size(225, 24);
            this.txtSpecifications.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Tên Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Thông Số";
            // 
            // frmModelDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 567);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpThongTinSanPham);
            this.Controls.Add(this.gcModelDetailList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModelDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModelDetail";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_MaModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemMemoEdit_MoTaModel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcModelDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModelDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinSanPham)).EndInit();
            this.grpThongTinSanPham.ResumeLayout(false);
            this.grpThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYearOfProduct.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYearOfProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpecifications.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraGrid.GridControl gcModelDetailList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvModelDetailList;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colThongSoKyThuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTenModel;
        private DevExpress.XtraEditors.GroupControl grpThongTinSanPham;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.DateEdit dtYearOfProduct;
        private DevExpress.XtraEditors.TextEdit txtSalePrice;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtSpecifications;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.MemoEdit mmeDescription;
        private DevExpress.XtraEditors.LookUpEdit cmbModel;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_MaModel;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit ItemMemoEdit_MoTaModel;
        private DevExpress.XtraEditors.LabelControl lblThemModel;
    }
}