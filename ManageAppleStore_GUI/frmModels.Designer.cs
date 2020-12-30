
namespace ManageAppleStore_GUI
{
    partial class frmModels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModels));
            this.repositoryItemLookUpEdit_MaModel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ItemMemoEdit_MoTaModel = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaModel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaLModel = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemModel = new DevExpress.XtraEditors.SimpleButton();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLuuModel = new DevExpress.XtraEditors.SimpleButton();
            this.gcModelList = new DevExpress.XtraGrid.GridControl();
            this.gvModelList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstrMaModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrTenModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaModel = new DevExpress.XtraEditors.TextEdit();
            this.txtTenModel = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_MaModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemMemoEdit_MoTaModel)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcModelList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModelList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenModel.Properties)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(900, 39);
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
            this.lblRefresh.Location = new System.Drawing.Point(826, 0);
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
            this.panel1.Controls.Add(this.btnXoaModel);
            this.panel1.Controls.Add(this.btnSuaLModel);
            this.panel1.Controls.Add(this.btnThemModel);
            this.panel1.Controls.Add(this.lblHienThi);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 461);
            this.panel1.TabIndex = 12;
            // 
            // btnXoaModel
            // 
            this.btnXoaModel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaModel.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaModel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoaModel.Appearance.Options.UseBackColor = true;
            this.btnXoaModel.Appearance.Options.UseFont = true;
            this.btnXoaModel.Appearance.Options.UseForeColor = true;
            this.btnXoaModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaModel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaModel.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaModel.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoaModel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXoaModel.AppearanceHovered.Options.UseFont = true;
            this.btnXoaModel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoaModel.Location = new System.Drawing.Point(-1, 299);
            this.btnXoaModel.Name = "btnXoaModel";
            this.btnXoaModel.Size = new System.Drawing.Size(185, 55);
            this.btnXoaModel.TabIndex = 30;
            this.btnXoaModel.TabStop = false;
            this.btnXoaModel.Text = "Xóa";
            // 
            // btnSuaLModel
            // 
            this.btnSuaLModel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaLModel.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLModel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSuaLModel.Appearance.Options.UseBackColor = true;
            this.btnSuaLModel.Appearance.Options.UseFont = true;
            this.btnSuaLModel.Appearance.Options.UseForeColor = true;
            this.btnSuaLModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLModel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLModel.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLModel.AppearanceHovered.Options.UseBackColor = true;
            this.btnSuaLModel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSuaLModel.AppearanceHovered.Options.UseFont = true;
            this.btnSuaLModel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSuaLModel.Location = new System.Drawing.Point(-1, 366);
            this.btnSuaLModel.Name = "btnSuaLModel";
            this.btnSuaLModel.Size = new System.Drawing.Size(185, 55);
            this.btnSuaLModel.TabIndex = 29;
            this.btnSuaLModel.TabStop = false;
            this.btnSuaLModel.Text = "Sửa";
            // 
            // btnThemModel
            // 
            this.btnThemModel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnThemModel.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemModel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThemModel.Appearance.Options.UseBackColor = true;
            this.btnThemModel.Appearance.Options.UseFont = true;
            this.btnThemModel.Appearance.Options.UseForeColor = true;
            this.btnThemModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemModel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemModel.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemModel.AppearanceHovered.Options.UseBackColor = true;
            this.btnThemModel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThemModel.AppearanceHovered.Options.UseFont = true;
            this.btnThemModel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemModel.Location = new System.Drawing.Point(-1, 233);
            this.btnThemModel.Name = "btnThemModel";
            this.btnThemModel.Size = new System.Drawing.Size(185, 55);
            this.btnThemModel.TabIndex = 28;
            this.btnThemModel.TabStop = false;
            this.btnThemModel.Text = "Thêm";
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
            this.lblHienThi.Text = "Cấu Hình\r\nSản Phẩm";
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
            // btnLuuModel
            // 
            this.btnLuuModel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.btnLuuModel.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuModel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuuModel.Appearance.Options.UseBackColor = true;
            this.btnLuuModel.Appearance.Options.UseFont = true;
            this.btnLuuModel.Appearance.Options.UseForeColor = true;
            this.btnLuuModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuModel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuModel.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuModel.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuuModel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLuuModel.AppearanceHovered.Options.UseFont = true;
            this.btnLuuModel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuuModel.Location = new System.Drawing.Point(278, 85);
            this.btnLuuModel.Name = "btnLuuModel";
            this.btnLuuModel.Size = new System.Drawing.Size(150, 45);
            this.btnLuuModel.TabIndex = 31;
            this.btnLuuModel.TabStop = false;
            this.btnLuuModel.Text = "Lưu";
            // 
            // gcModelList
            // 
            this.gcModelList.Location = new System.Drawing.Point(186, 200);
            this.gcModelList.MainView = this.gvModelList;
            this.gcModelList.Name = "gcModelList";
            this.gcModelList.Size = new System.Drawing.Size(710, 295);
            this.gcModelList.TabIndex = 16;
            this.gcModelList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvModelList});
            // 
            // gvModelList
            // 
            this.gvModelList.Appearance.Empty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvModelList.Appearance.Empty.Options.UseFont = true;
            this.gvModelList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelList.Appearance.EvenRow.Options.UseFont = true;
            this.gvModelList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvModelList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelList.Appearance.OddRow.Options.UseFont = true;
            this.gvModelList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelList.Appearance.Row.Options.UseFont = true;
            this.gvModelList.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvModelList.Appearance.SelectedRow.Options.UseFont = true;
            this.gvModelList.Appearance.TopNewRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvModelList.Appearance.TopNewRow.Options.UseFont = true;
            this.gvModelList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvModelList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvModelList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstrMaModel,
            this.colstrTenModel,
            this.colbTrangThai});
            this.gvModelList.GridControl = this.gcModelList;
            this.gvModelList.Name = "gvModelList";
            this.gvModelList.NewItemRowText = "Thêm Mới";
            this.gvModelList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvModelList.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvModelList.OptionsBehavior.Editable = false;
            this.gvModelList.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvModelList.OptionsSelection.MultiSelect = true;
            this.gvModelList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvModelList.OptionsView.RowAutoHeight = true;
            this.gvModelList.OptionsView.ShowAutoFilterRow = true;
            this.gvModelList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvModelList.OptionsView.ShowGroupPanel = false;
            this.gvModelList.OptionsView.ShowIndicator = false;
            this.gvModelList.OptionsView.ShowViewCaption = true;
            this.gvModelList.ViewCaption = "Chi Tiết Cấu Hình Sản Phẩm";
            // 
            // colstrMaModel
            // 
            this.colstrMaModel.Caption = "Mã Model";
            this.colstrMaModel.FieldName = "strMaModel";
            this.colstrMaModel.Name = "colstrMaModel";
            this.colstrMaModel.Visible = true;
            this.colstrMaModel.VisibleIndex = 0;
            // 
            // colstrTenModel
            // 
            this.colstrTenModel.Caption = "Tên Model";
            this.colstrTenModel.FieldName = "strTenModel";
            this.colstrTenModel.Name = "colstrTenModel";
            this.colstrTenModel.Visible = true;
            this.colstrTenModel.VisibleIndex = 1;
            // 
            // colbTrangThai
            // 
            this.colbTrangThai.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbTrangThai.AppearanceCell.Options.UseFont = true;
            this.colbTrangThai.AppearanceHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbTrangThai.AppearanceHeader.Options.UseFont = true;
            this.colbTrangThai.Caption = "Trạng Thái";
            this.colbTrangThai.FieldName = "bTrangThai";
            this.colbTrangThai.Name = "colbTrangThai";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtMaModel);
            this.groupControl1.Controls.Add(this.btnLuuModel);
            this.groupControl1.Controls.Add(this.txtTenModel);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Location = new System.Drawing.Point(188, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(708, 144);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtMaModel
            // 
            this.txtMaModel.Location = new System.Drawing.Point(125, 42);
            this.txtMaModel.Name = "txtMaModel";
            this.txtMaModel.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaModel.Properties.Appearance.Options.UseFont = true;
            this.txtMaModel.Size = new System.Drawing.Size(183, 24);
            this.txtMaModel.TabIndex = 58;
            // 
            // txtTenModel
            // 
            this.txtTenModel.Location = new System.Drawing.Point(474, 42);
            this.txtTenModel.Name = "txtTenModel";
            this.txtTenModel.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenModel.Properties.Appearance.Options.UseFont = true;
            this.txtTenModel.Size = new System.Drawing.Size(183, 24);
            this.txtTenModel.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(42, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mã Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(391, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Tên Model";
            // 
            // frmModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcModelList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModels";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_MaModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemMemoEdit_MoTaModel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcModelList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModelList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenModel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraGrid.GridControl gcModelList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvModelList;
        private DevExpress.XtraEditors.SimpleButton btnLuuModel;
        private DevExpress.XtraEditors.SimpleButton btnXoaModel;
        private DevExpress.XtraEditors.SimpleButton btnSuaLModel;
        private DevExpress.XtraEditors.SimpleButton btnThemModel;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_MaModel;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit ItemMemoEdit_MoTaModel;
        private DevExpress.XtraEditors.TextEdit txtMaModel;
        private DevExpress.XtraGrid.Columns.GridColumn colstrMaModel;
        private DevExpress.XtraGrid.Columns.GridColumn colstrTenModel;
        private DevExpress.XtraGrid.Columns.GridColumn colbTrangThai;
    }
}