
namespace ManageAppleStore_GUI
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.grpThongTinCTKH = new DevExpress.XtraEditors.GroupControl();
            this.cmbCustomerOfType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblCustomerOfType = new System.Windows.Forms.Label();
            this.radFemale = new DevExpress.XtraEditors.CheckEdit();
            this.radMale = new DevExpress.XtraEditors.CheckEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.dteBirthDay = new DevExpress.XtraEditors.DateEdit();
            this.lblIID_Card = new DevExpress.XtraEditors.LabelControl();
            this.lblGender = new DevExpress.XtraEditors.LabelControl();
            this.lblBirthDay = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblNumberPhone = new DevExpress.XtraEditors.LabelControl();
            this.lblFullName = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.txtID_Card = new DevExpress.XtraEditors.TextEdit();
            this.txtNumberPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBefore = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblShow = new DevExpress.XtraEditors.LabelControl();
            this.btnEditCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcCustomerList = new DevExpress.XtraGrid.GridControl();
            this.gvCustomerList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDTKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinhKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinhKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemDateEdit_NgaySinhKH = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colCMNDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmailKh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinCTKH)).BeginInit();
            this.grpThongTinCTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerOfType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radFemale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_Card.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NgaySinhKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NgaySinhKH.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTinCTKH
            // 
            this.grpThongTinCTKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinCTKH.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinCTKH.Appearance.Options.UseFont = true;
            this.grpThongTinCTKH.AppearanceCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinCTKH.AppearanceCaption.Options.UseFont = true;
            this.grpThongTinCTKH.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.grpThongTinCTKH.Controls.Add(this.cmbCustomerOfType);
            this.grpThongTinCTKH.Controls.Add(this.btnSave);
            this.grpThongTinCTKH.Controls.Add(this.lblCustomerOfType);
            this.grpThongTinCTKH.Controls.Add(this.radFemale);
            this.grpThongTinCTKH.Controls.Add(this.radMale);
            this.grpThongTinCTKH.Controls.Add(this.txtAddress);
            this.grpThongTinCTKH.Controls.Add(this.lblAddress);
            this.grpThongTinCTKH.Controls.Add(this.dteBirthDay);
            this.grpThongTinCTKH.Controls.Add(this.lblIID_Card);
            this.grpThongTinCTKH.Controls.Add(this.lblGender);
            this.grpThongTinCTKH.Controls.Add(this.lblBirthDay);
            this.grpThongTinCTKH.Controls.Add(this.lblEmail);
            this.grpThongTinCTKH.Controls.Add(this.lblNumberPhone);
            this.grpThongTinCTKH.Controls.Add(this.lblFullName);
            this.grpThongTinCTKH.Controls.Add(this.lblID);
            this.grpThongTinCTKH.Controls.Add(this.txtEmail);
            this.grpThongTinCTKH.Controls.Add(this.txtFullName);
            this.grpThongTinCTKH.Controls.Add(this.txtID_Card);
            this.grpThongTinCTKH.Controls.Add(this.txtNumberPhone);
            this.grpThongTinCTKH.Controls.Add(this.txtID);
            this.grpThongTinCTKH.Location = new System.Drawing.Point(7, 8);
            this.grpThongTinCTKH.Name = "grpThongTinCTKH";
            this.grpThongTinCTKH.Size = new System.Drawing.Size(880, 182);
            this.grpThongTinCTKH.TabIndex = 0;
            this.grpThongTinCTKH.Text = "Thông Tin Khách Hàng";
            // 
            // cmbCustomerOfType
            // 
            this.cmbCustomerOfType.Location = new System.Drawing.Point(127, 148);
            this.cmbCustomerOfType.Name = "cmbCustomerOfType";
            this.cmbCustomerOfType.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCustomerOfType.Properties.Appearance.Options.UseFont = true;
            this.cmbCustomerOfType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCustomerOfType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbCustomerOfType.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCustomerOfType.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbCustomerOfType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomerOfType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("strMaLoaiKH", "Mã Loại KH", 119, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("strLoaiKH", "Loại Khách Hàng", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("iPhanTramGG", "Phần Trăm GG", 115, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bTrangThai", "Trạng Thái", 95, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbCustomerOfType.Properties.DisplayMember = "strLoaiKH";
            this.cmbCustomerOfType.Properties.NullText = "Loại Khách Hàng";
            this.cmbCustomerOfType.Properties.ValueMember = "strMaLoaiKH";
            this.cmbCustomerOfType.Size = new System.Drawing.Size(213, 24);
            this.cmbCustomerOfType.TabIndex = 56;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(694, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            // 
            // lblCustomerOfType
            // 
            this.lblCustomerOfType.AutoSize = true;
            this.lblCustomerOfType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCustomerOfType.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerOfType.Location = new System.Drawing.Point(5, 151);
            this.lblCustomerOfType.Name = "lblCustomerOfType";
            this.lblCustomerOfType.Size = new System.Drawing.Size(119, 17);
            this.lblCustomerOfType.TabIndex = 55;
            this.lblCustomerOfType.Text = "Loại Khách Hàng";
            // 
            // radFemale
            // 
            this.radFemale.Location = new System.Drawing.Point(544, 30);
            this.radFemale.Name = "radFemale";
            this.radFemale.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radFemale.Properties.Appearance.Options.UseFont = true;
            this.radFemale.Properties.Caption = "Nữ";
            this.radFemale.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radFemale.Size = new System.Drawing.Size(41, 21);
            this.radFemale.TabIndex = 5;
            // 
            // radMale
            // 
            this.radMale.Location = new System.Drawing.Point(454, 29);
            this.radMale.Name = "radMale";
            this.radMale.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radMale.Properties.Appearance.Options.UseFont = true;
            this.radMale.Properties.Caption = "Nam";
            this.radMale.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radMale.Size = new System.Drawing.Size(52, 21);
            this.radMale.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(454, 84);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(213, 24);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAddress.Appearance.Options.UseFont = true;
            this.lblAddress.Location = new System.Drawing.Point(381, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 17);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Địa Chỉ";
            // 
            // dteBirthDay
            // 
            this.dteBirthDay.EditValue = null;
            this.dteBirthDay.Location = new System.Drawing.Point(127, 118);
            this.dteBirthDay.Name = "dteBirthDay";
            this.dteBirthDay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteBirthDay.Properties.Appearance.Options.UseFont = true;
            this.dteBirthDay.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteBirthDay.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dteBirthDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBirthDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBirthDay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteBirthDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteBirthDay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteBirthDay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteBirthDay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteBirthDay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteBirthDay.Size = new System.Drawing.Size(213, 24);
            this.dteBirthDay.TabIndex = 3;
            // 
            // lblIID_Card
            // 
            this.lblIID_Card.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIID_Card.Appearance.Options.UseFont = true;
            this.lblIID_Card.Location = new System.Drawing.Point(384, 60);
            this.lblIID_Card.Name = "lblIID_Card";
            this.lblIID_Card.Size = new System.Drawing.Size(43, 17);
            this.lblIID_Card.TabIndex = 1;
            this.lblIID_Card.Text = "CMND";
            // 
            // lblGender
            // 
            this.lblGender.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGender.Appearance.Options.UseFont = true;
            this.lblGender.Location = new System.Drawing.Point(370, 32);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 17);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Giới Tính";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBirthDay.Appearance.Options.UseFont = true;
            this.lblBirthDay.Location = new System.Drawing.Point(57, 121);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(66, 17);
            this.lblBirthDay.TabIndex = 1;
            this.lblBirthDay.Text = "Ngày Sinh";
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Location = new System.Drawing.Point(392, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumberPhone.Appearance.Options.UseFont = true;
            this.lblNumberPhone.Location = new System.Drawing.Point(32, 92);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(92, 17);
            this.lblNumberPhone.TabIndex = 1;
            this.lblNumberPhone.Text = "Số Điện Thoại";
            // 
            // lblFullName
            // 
            this.lblFullName.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFullName.Appearance.Options.UseFont = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 63);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(109, 17);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Tên Khách Hàng";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(18, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Mã Khách Hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(454, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(213, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(127, 58);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Size = new System.Drawing.Size(213, 24);
            this.txtFullName.TabIndex = 1;
            // 
            // txtID_Card
            // 
            this.txtID_Card.Location = new System.Drawing.Point(454, 57);
            this.txtID_Card.Name = "txtID_Card";
            this.txtID_Card.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID_Card.Properties.Appearance.Options.UseFont = true;
            this.txtID_Card.Size = new System.Drawing.Size(213, 24);
            this.txtID_Card.TabIndex = 6;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(127, 88);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNumberPhone.Properties.Appearance.Options.UseFont = true;
            this.txtNumberPhone.Properties.MaxLength = 12;
            this.txtNumberPhone.Size = new System.Drawing.Size(213, 24);
            this.txtNumberPhone.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 28);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(131, 24);
            this.txtID.TabIndex = 0;
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
            this.lblRefresh.Location = new System.Drawing.Point(1003, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(74, 39);
            this.lblRefresh.TabIndex = 14;
            this.lblRefresh.ToolTip = "Làm mới";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblRefresh);
            this.panel2.Controls.Add(this.lblBefore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 39);
            this.panel2.TabIndex = 9;
            // 
            // lblBefore
            // 
            this.lblBefore.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBefore.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBefore.Appearance.Options.UseFont = true;
            this.lblBefore.Appearance.Options.UseImage = true;
            this.lblBefore.Appearance.Options.UseImageAlign = true;
            this.lblBefore.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(106)))), ((int)(((byte)(111)))));
            this.lblBefore.AppearanceHovered.Options.UseBackColor = true;
            this.lblBefore.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBefore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblBefore.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBefore.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblBefore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblQuayLai.ImageOptions.Image")));
            this.lblBefore.Location = new System.Drawing.Point(0, 0);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(182, 39);
            this.lblBefore.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.lblShow);
            this.panel4.Controls.Add(this.btnEditCustomer);
            this.panel4.Controls.Add(this.btnDeleteCustomer);
            this.panel4.Controls.Add(this.btnAddCustomer);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 510);
            this.panel4.TabIndex = 1;
            // 
            // lblShow
            // 
            this.lblShow.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblShow.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblShow.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblShow.Appearance.Options.UseBackColor = true;
            this.lblShow.Appearance.Options.UseFont = true;
            this.lblShow.Appearance.Options.UseForeColor = true;
            this.lblShow.Appearance.Options.UseTextOptions = true;
            this.lblShow.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblShow.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblShow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblShow.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblShow.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblShow.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblShow.LineVisible = true;
            this.lblShow.Location = new System.Drawing.Point(3, 159);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(176, 38);
            this.lblShow.TabIndex = 17;
            this.lblShow.Text = "Quản Lý Khách Hàng";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCustomer.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Appearance.Options.UseBackColor = true;
            this.btnEditCustomer.Appearance.Options.UseFont = true;
            this.btnEditCustomer.Appearance.Options.UseForeColor = true;
            this.btnEditCustomer.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnEditCustomer.AppearanceHovered.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditCustomer.AppearanceHovered.Options.UseBackColor = true;
            this.btnEditCustomer.AppearanceHovered.Options.UseFont = true;
            this.btnEditCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEditCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKH.ImageOptions.Image")));
            this.btnEditCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditCustomer.Location = new System.Drawing.Point(-2, 394);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(185, 55);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.TabStop = false;
            this.btnEditCustomer.Text = "Sửa";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteCustomer.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Appearance.Options.UseBackColor = true;
            this.btnDeleteCustomer.Appearance.Options.UseFont = true;
            this.btnDeleteCustomer.Appearance.Options.UseForeColor = true;
            this.btnDeleteCustomer.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnDeleteCustomer.AppearanceHovered.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteCustomer.AppearanceHovered.Options.UseBackColor = true;
            this.btnDeleteCustomer.AppearanceHovered.Options.UseFont = true;
            this.btnDeleteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.ImageOptions.Image")));
            this.btnDeleteCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(-1, 306);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDeleteCustomer.Size = new System.Drawing.Size(185, 55);
            this.btnDeleteCustomer.TabIndex = 1;
            this.btnDeleteCustomer.TabStop = false;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.ToolTip = "Xóa Thông Tin Khách Hàng";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddCustomer.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Appearance.Options.UseBackColor = true;
            this.btnAddCustomer.Appearance.Options.UseFont = true;
            this.btnAddCustomer.Appearance.Options.UseForeColor = true;
            this.btnAddCustomer.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnAddCustomer.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnAddCustomer.AppearanceHovered.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddCustomer.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddCustomer.AppearanceHovered.Options.UseBorderColor = true;
            this.btnAddCustomer.AppearanceHovered.Options.UseFont = true;
            this.btnAddCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.ImageOptions.Image")));
            this.btnAddCustomer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddCustomer.Location = new System.Drawing.Point(-1, 225);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(185, 55);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.TabStop = false;
            this.btnAddCustomer.Text = "Thêm ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcCustomerList);
            this.panel1.Controls.Add(this.grpThongTinCTKH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(182, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 510);
            this.panel1.TabIndex = 0;
            // 
            // gcCustomerList
            // 
            this.gcCustomerList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcCustomerList.Location = new System.Drawing.Point(6, 196);
            this.gcCustomerList.MainView = this.gvCustomerList;
            this.gcCustomerList.Name = "gcCustomerList";
            this.gcCustomerList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.ItemDateEdit_NgaySinhKH});
            this.gcCustomerList.Size = new System.Drawing.Size(881, 311);
            this.gcCustomerList.TabIndex = 1;
            this.gcCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomerList});
            // 
            // gvCustomerList
            // 
            this.gvCustomerList.Appearance.Empty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCustomerList.Appearance.Empty.Options.UseFont = true;
            this.gvCustomerList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvCustomerList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCustomerList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCustomerList.Appearance.EvenRow.Options.UseFont = true;
            this.gvCustomerList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCustomerList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCustomerList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvCustomerList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCustomerList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCustomerList.Appearance.OddRow.Options.UseFont = true;
            this.gvCustomerList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCustomerList.Appearance.Row.Options.UseFont = true;
            this.gvCustomerList.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCustomerList.Appearance.SelectedRow.Options.UseFont = true;
            this.gvCustomerList.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvCustomerList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCustomerList.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvCustomerList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvCustomerList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colHoTenKH,
            this.colSDTKH,
            this.colGioiTinhKH,
            this.colNgaySinhKH,
            this.colCMNDKH,
            this.colEmailKh,
            this.colDiaChiKH});
            this.gvCustomerList.GridControl = this.gcCustomerList;
            this.gvCustomerList.Name = "gvCustomerList";
            this.gvCustomerList.OptionsBehavior.Editable = false;
            this.gvCustomerList.OptionsSelection.MultiSelect = true;
            this.gvCustomerList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCustomerList.OptionsView.EnableAppearanceOddRow = true;
            this.gvCustomerList.OptionsView.ShowAutoFilterRow = true;
            this.gvCustomerList.OptionsView.ShowGroupPanel = false;
            this.gvCustomerList.OptionsView.ShowIndicator = false;
            this.gvCustomerList.OptionsView.ShowViewCaption = true;
            this.gvCustomerList.ViewCaption = "Danh Sách Khách Hàng";
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Mã Khách Hàng";
            this.colMaKH.FieldName = "strMaKH";
            this.colMaKH.Name = "colMaKH";
            // 
            // colHoTenKH
            // 
            this.colHoTenKH.Caption = "Tên Khách Hàng";
            this.colHoTenKH.FieldName = "strHoTenKH";
            this.colHoTenKH.Name = "colHoTenKH";
            this.colHoTenKH.Visible = true;
            this.colHoTenKH.VisibleIndex = 0;
            this.colHoTenKH.Width = 252;
            // 
            // colSDTKH
            // 
            this.colSDTKH.Caption = "Số Điện Thoại";
            this.colSDTKH.FieldName = "strSDTKH";
            this.colSDTKH.Name = "colSDTKH";
            this.colSDTKH.Visible = true;
            this.colSDTKH.VisibleIndex = 1;
            this.colSDTKH.Width = 222;
            // 
            // colGioiTinhKH
            // 
            this.colGioiTinhKH.Caption = "Giới Tính";
            this.colGioiTinhKH.FieldName = "strGioiTinhKH";
            this.colGioiTinhKH.Name = "colGioiTinhKH";
            this.colGioiTinhKH.Visible = true;
            this.colGioiTinhKH.VisibleIndex = 2;
            this.colGioiTinhKH.Width = 122;
            // 
            // colNgaySinhKH
            // 
            this.colNgaySinhKH.Caption = "Ngày Sinh";
            this.colNgaySinhKH.ColumnEdit = this.ItemDateEdit_NgaySinhKH;
            this.colNgaySinhKH.FieldName = "dtNgaySinhKH";
            this.colNgaySinhKH.Name = "colNgaySinhKH";
            this.colNgaySinhKH.Visible = true;
            this.colNgaySinhKH.VisibleIndex = 3;
            this.colNgaySinhKH.Width = 198;
            // 
            // ItemDateEdit_NgaySinhKH
            // 
            this.ItemDateEdit_NgaySinhKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ItemDateEdit_NgaySinhKH.Appearance.Options.UseFont = true;
            this.ItemDateEdit_NgaySinhKH.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ItemDateEdit_NgaySinhKH.AppearanceDropDown.Options.UseFont = true;
            this.ItemDateEdit_NgaySinhKH.AutoHeight = false;
            this.ItemDateEdit_NgaySinhKH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemDateEdit_NgaySinhKH.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemDateEdit_NgaySinhKH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ItemDateEdit_NgaySinhKH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ItemDateEdit_NgaySinhKH.EditFormat.FormatString = "dd/MM/yyyy";
            this.ItemDateEdit_NgaySinhKH.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ItemDateEdit_NgaySinhKH.Mask.EditMask = "dd/MM/yyyy";
            this.ItemDateEdit_NgaySinhKH.Mask.UseMaskAsDisplayFormat = true;
            this.ItemDateEdit_NgaySinhKH.Name = "ItemDateEdit_NgaySinhKH";
            // 
            // colCMNDKH
            // 
            this.colCMNDKH.Caption = "CMND";
            this.colCMNDKH.FieldName = "iCMNDKH";
            this.colCMNDKH.Name = "colCMNDKH";
            this.colCMNDKH.Visible = true;
            this.colCMNDKH.VisibleIndex = 4;
            this.colCMNDKH.Width = 204;
            // 
            // colEmailKh
            // 
            this.colEmailKh.Caption = "Email";
            this.colEmailKh.FieldName = "strEmailKH";
            this.colEmailKh.Name = "colEmailKh";
            this.colEmailKh.Visible = true;
            this.colEmailKh.VisibleIndex = 5;
            this.colEmailKh.Width = 251;
            // 
            // colDiaChiKH
            // 
            this.colDiaChiKH.Caption = "Địa Chỉ";
            this.colDiaChiKH.FieldName = "strDiaChiKH";
            this.colDiaChiKH.Name = "colDiaChiKH";
            this.colDiaChiKH.Visible = true;
            this.colDiaChiKH.VisibleIndex = 6;
            this.colDiaChiKH.Width = 389;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "strThanhVienKH";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinCTKH)).EndInit();
            this.grpThongTinCTKH.ResumeLayout(false);
            this.grpThongTinCTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerOfType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radFemale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_Card.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NgaySinhKH.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NgaySinhKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpThongTinCTKH;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.DateEdit dteBirthDay;
        private DevExpress.XtraEditors.LabelControl lblIID_Card;
        private DevExpress.XtraEditors.LabelControl lblGender;
        private DevExpress.XtraEditors.LabelControl lblBirthDay;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblNumberPhone;
        private DevExpress.XtraEditors.LabelControl lblFullName;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.TextEdit txtID_Card;
        private DevExpress.XtraEditors.TextEdit txtNumberPhone;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblBefore;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEditCustomer;
        private DevExpress.XtraEditors.SimpleButton btnDeleteCustomer;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblShow;
        private DevExpress.XtraEditors.CheckEdit radFemale;
        private DevExpress.XtraEditors.CheckEdit radMale;
        private DevExpress.XtraGrid.GridControl gcCustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomerList;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSDTKH;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinhKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinhKH;
        private DevExpress.XtraGrid.Columns.GridColumn colCMNDKH;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailKh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChiKH;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ItemDateEdit_NgaySinhKH;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomerOfType;
        private System.Windows.Forms.Label lblCustomerOfType;
    }
}