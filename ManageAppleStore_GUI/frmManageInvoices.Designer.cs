namespace ManageAppleStore_GUI
{
    partial class frmManageInvoices
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInvoices));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcInvoiceList = new DevExpress.XtraGrid.GridControl();
            this.gvInvoiceList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_gvColMaNV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_gvColMaKH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dtToDate = new DevExpress.XtraEditors.DateEdit();
            this.btnStatistic = new DevExpress.XtraEditors.SimpleButton();
            this.btnBillDetail = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAllBill = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdateBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteBill = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblQuayLai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 39);
            this.panel2.TabIndex = 10;
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
            this.lblQuayLai.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblQuayLai.Location = new System.Drawing.Point(0, 0);
            this.lblQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(195, 39);
            this.lblQuayLai.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // gcInvoiceList
            // 
            this.gcInvoiceList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gcInvoiceList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            gridLevelNode1.RelationName = "Level1";
            this.gcInvoiceList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcInvoiceList.Location = new System.Drawing.Point(190, 222);
            this.gcInvoiceList.MainView = this.gvInvoiceList;
            this.gcInvoiceList.Margin = new System.Windows.Forms.Padding(4);
            this.gcInvoiceList.Name = "gcInvoiceList";
            this.gcInvoiceList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_gvColMaNV,
            this.LookUpEdit_gvColMaKH});
            this.gcInvoiceList.Size = new System.Drawing.Size(1062, 503);
            this.gcInvoiceList.TabIndex = 11;
            this.gcInvoiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoiceList});
            // 
            // gvInvoiceList
            // 
            this.gvInvoiceList.Appearance.Empty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvoiceList.Appearance.Empty.Options.UseFont = true;
            this.gvInvoiceList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvInvoiceList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvoiceList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvInvoiceList.Appearance.EvenRow.Options.UseFont = true;
            this.gvInvoiceList.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvInvoiceList.Appearance.FooterPanel.Options.UseFont = true;
            this.gvInvoiceList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvInvoiceList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvInvoiceList.Appearance.GroupFooter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvInvoiceList.Appearance.GroupFooter.Options.UseFont = true;
            this.gvInvoiceList.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvInvoiceList.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvInvoiceList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvoiceList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvInvoiceList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvInvoiceList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvInvoiceList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvInvoiceList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvoiceList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvInvoiceList.Appearance.OddRow.Options.UseFont = true;
            this.gvInvoiceList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvoiceList.Appearance.Row.Options.UseFont = true;
            this.gvInvoiceList.Appearance.Row.Options.UseTextOptions = true;
            this.gvInvoiceList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvInvoiceList.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvoiceList.Appearance.SelectedRow.Options.UseFont = true;
            this.gvInvoiceList.Appearance.TopNewRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvoiceList.Appearance.TopNewRow.Options.UseFont = true;
            this.gvInvoiceList.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvInvoiceList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvoiceList.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvInvoiceList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvInvoiceList.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvInvoiceList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvInvoiceList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHDB,
            this.colNgayBan,
            this.colMaNV,
            this.colMaKH,
            this.colTongTien});
            this.gvInvoiceList.GridControl = this.gcInvoiceList;
            this.gvInvoiceList.Name = "gvInvoiceList";
            this.gvInvoiceList.NewItemRowText = "Thêm Mới";
            this.gvInvoiceList.OptionsBehavior.Editable = false;
            this.gvInvoiceList.OptionsSelection.MultiSelect = true;
            this.gvInvoiceList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInvoiceList.OptionsView.EnableAppearanceOddRow = true;
            this.gvInvoiceList.OptionsView.ShowAutoFilterRow = true;
            this.gvInvoiceList.OptionsView.ShowFooter = true;
            this.gvInvoiceList.OptionsView.ShowGroupPanel = false;
            this.gvInvoiceList.OptionsView.ShowViewCaption = true;
            this.gvInvoiceList.ViewCaption = "Danh Sách Hóa Đơn";
            // 
            // colMaHDB
            // 
            this.colMaHDB.Caption = "Mã Hóa Đơn";
            this.colMaHDB.FieldName = "I_MaHDB";
            this.colMaHDB.Name = "colMaHDB";
            this.colMaHDB.Visible = true;
            this.colMaHDB.VisibleIndex = 0;
            this.colMaHDB.Width = 136;
            // 
            // colNgayBan
            // 
            this.colNgayBan.Caption = "Ngày Bán";
            this.colNgayBan.FieldName = "DT_NgayBan";
            this.colNgayBan.Name = "colNgayBan";
            this.colNgayBan.Visible = true;
            this.colNgayBan.VisibleIndex = 1;
            this.colNgayBan.Width = 121;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Nhân Viên";
            this.colMaNV.ColumnEdit = this.LookUpEdit_gvColMaNV;
            this.colMaNV.FieldName = "STR_MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 2;
            this.colMaNV.Width = 191;
            // 
            // LookUpEdit_gvColMaNV
            // 
            this.LookUpEdit_gvColMaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaNV.Appearance.Options.UseFont = true;
            this.LookUpEdit_gvColMaNV.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaNV.AppearanceDropDown.Options.UseFont = true;
            this.LookUpEdit_gvColMaNV.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaNV.AppearanceDropDownHeader.Options.UseFont = true;
            this.LookUpEdit_gvColMaNV.AutoHeight = false;
            this.LookUpEdit_gvColMaNV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_gvColMaNV.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenNV", "Tên Nhân Viên")});
            this.LookUpEdit_gvColMaNV.DisplayMember = "strHoTen";
            this.LookUpEdit_gvColMaNV.Name = "LookUpEdit_gvColMaNV";
            this.LookUpEdit_gvColMaNV.NullText = "Nhân Viên";
            this.LookUpEdit_gvColMaNV.ValueMember = "strMaNV";
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Khách Hàng";
            this.colMaKH.ColumnEdit = this.LookUpEdit_gvColMaKH;
            this.colMaKH.FieldName = "STR_MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 3;
            this.colMaKH.Width = 192;
            // 
            // LookUpEdit_gvColMaKH
            // 
            this.LookUpEdit_gvColMaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaKH.Appearance.Options.UseFont = true;
            this.LookUpEdit_gvColMaKH.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaKH.AppearanceDropDown.Options.UseFont = true;
            this.LookUpEdit_gvColMaKH.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaKH.AppearanceDropDownHeader.Options.UseFont = true;
            this.LookUpEdit_gvColMaKH.AutoHeight = false;
            this.LookUpEdit_gvColMaKH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_gvColMaKH.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenKH", "Tên Khách Hàng")});
            this.LookUpEdit_gvColMaKH.DisplayMember = "strHoTenKH";
            this.LookUpEdit_gvColMaKH.Name = "LookUpEdit_gvColMaKH";
            this.LookUpEdit_gvColMaKH.NullText = "Khách Hàng";
            this.LookUpEdit_gvColMaKH.ValueMember = "strMaKH";
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.DisplayFormat.FormatString = "c0";
            this.colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongTien.FieldName = "DEC_TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DEC_TongTien", "{0:c0}")});
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 4;
            this.colTongTien.Width = 298;
            // 
            // dtFromDate
            // 
            this.dtFromDate.EditValue = new System.DateTime(2019, 5, 24, 14, 39, 31, 102);
            this.dtFromDate.Location = new System.Drawing.Point(80, 32);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtFromDate.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.dtFromDate.Properties.Appearance.Options.UseFont = true;
            this.dtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtFromDate.Size = new System.Drawing.Size(115, 24);
            this.dtFromDate.TabIndex = 16;
            // 
            // dtToDate
            // 
            this.dtToDate.EditValue = new System.DateTime(2019, 5, 24, 0, 0, 0, 0);
            this.dtToDate.Location = new System.Drawing.Point(80, 62);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtToDate.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtToDate.Properties.Appearance.Options.UseBackColor = true;
            this.dtToDate.Properties.Appearance.Options.UseFont = true;
            this.dtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtToDate.Size = new System.Drawing.Size(115, 24);
            this.dtToDate.TabIndex = 17;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnStatistic.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatistic.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Appearance.Options.UseBackColor = true;
            this.btnStatistic.Appearance.Options.UseFont = true;
            this.btnStatistic.Appearance.Options.UseForeColor = true;
            this.btnStatistic.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnStatistic.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatistic.AppearanceHovered.Options.UseBackColor = true;
            this.btnStatistic.AppearanceHovered.Options.UseFont = true;
            this.btnStatistic.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnStatistic.Location = new System.Drawing.Point(201, 37);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(144, 45);
            this.btnStatistic.TabIndex = 18;
            this.btnStatistic.Text = "Thống Kê";
            // 
            // btnBillDetail
            // 
            this.btnBillDetail.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBillDetail.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBillDetail.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBillDetail.Appearance.Options.UseBackColor = true;
            this.btnBillDetail.Appearance.Options.UseFont = true;
            this.btnBillDetail.Appearance.Options.UseForeColor = true;
            this.btnBillDetail.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnBillDetail.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBillDetail.AppearanceHovered.Options.UseBackColor = true;
            this.btnBillDetail.AppearanceHovered.Options.UseFont = true;
            this.btnBillDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnBillDetail.Location = new System.Drawing.Point(413, 95);
            this.btnBillDetail.Name = "btnBillDetail";
            this.btnBillDetail.Size = new System.Drawing.Size(184, 65);
            this.btnBillDetail.TabIndex = 19;
            this.btnBillDetail.Text = "Chi Tiết Hóa Đơn";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnAllBill);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dtFromDate);
            this.groupControl1.Controls.Add(this.dtToDate);
            this.groupControl1.Controls.Add(this.btnStatistic);
            this.groupControl1.Location = new System.Drawing.Point(895, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 172);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Thống Kê Hóa Đơn";
            // 
            // btnAllBill
            // 
            this.btnAllBill.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAllBill.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAllBill.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAllBill.Appearance.Options.UseBackColor = true;
            this.btnAllBill.Appearance.Options.UseFont = true;
            this.btnAllBill.Appearance.Options.UseForeColor = true;
            this.btnAllBill.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnAllBill.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAllBill.AppearanceHovered.Options.UseBackColor = true;
            this.btnAllBill.AppearanceHovered.Options.UseFont = true;
            this.btnAllBill.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAllBill.Location = new System.Drawing.Point(9, 118);
            this.btnAllBill.Name = "btnAllBill";
            this.btnAllBill.Size = new System.Drawing.Size(162, 45);
            this.btnAllBill.TabIndex = 21;
            this.btnAllBill.Text = "Tất Cả Hóa Đơn";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 17);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Đến Ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 17);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Từ Ngày";
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBill.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateBill.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBill.Appearance.Options.UseBackColor = true;
            this.btnUpdateBill.Appearance.Options.UseFont = true;
            this.btnUpdateBill.Appearance.Options.UseForeColor = true;
            this.btnUpdateBill.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateBill.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateBill.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdateBill.AppearanceHovered.Options.UseFont = true;
            this.btnUpdateBill.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdateBill.Location = new System.Drawing.Point(0, 259);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(184, 65);
            this.btnUpdateBill.TabIndex = 21;
            this.btnUpdateBill.Text = "Cập Nhật Hóa Đơn";
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBill.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteBill.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBill.Appearance.Options.UseBackColor = true;
            this.btnDeleteBill.Appearance.Options.UseFont = true;
            this.btnDeleteBill.Appearance.Options.UseForeColor = true;
            this.btnDeleteBill.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteBill.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteBill.AppearanceHovered.Options.UseBackColor = true;
            this.btnDeleteBill.AppearanceHovered.Options.UseFont = true;
            this.btnDeleteBill.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDeleteBill.Location = new System.Drawing.Point(0, 357);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(184, 65);
            this.btnDeleteBill.TabIndex = 22;
            this.btnDeleteBill.Text = "Xóa Hóa Đơn";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Controls.Add(this.btnDeleteBill);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnUpdateBill);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 686);
            this.panel4.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 180);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 38);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Quản Lý Hóa Đơn Bán";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txtTotalPrice);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.btnBillDetail);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.cmbCustomer);
            this.groupControl2.Controls.Add(this.cmbEmployee);
            this.groupControl2.Controls.Add(this.txtID);
            this.groupControl2.Controls.Add(this.dtDate);
            this.groupControl2.Location = new System.Drawing.Point(189, 46);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(700, 169);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Thông Tin Hóa Đơn Nhập";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(406, 32);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.txtTotalPrice.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTotalPrice.Properties.DisplayFormat.FormatString = "c0";
            this.txtTotalPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalPrice.Properties.EditFormat.FormatString = "c0";
            this.txtTotalPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalPrice.Size = new System.Drawing.Size(191, 24);
            this.txtTotalPrice.TabIndex = 27;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(51, 61);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 17);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "Ngày Bán";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(333, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 17);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Tổng Tiền";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 122);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(109, 17);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Tên Khách Hàng";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 17);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Tên Nhân Viên";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(33, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 17);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Mã Hóa Đơn";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Location = new System.Drawing.Point(121, 119);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCustomer.Properties.Appearance.Options.UseFont = true;
            this.cmbCustomer.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCustomer.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbCustomer.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCustomer.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenKH", "Tên Khách Hàng")});
            this.cmbCustomer.Properties.DisplayMember = "strHoTenKH";
            this.cmbCustomer.Properties.NullText = "Tên Khách Hàng";
            this.cmbCustomer.Properties.ValueMember = "strMaKH";
            this.cmbCustomer.Size = new System.Drawing.Size(192, 24);
            this.cmbCustomer.TabIndex = 21;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Location = new System.Drawing.Point(121, 89);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbEmployee.Properties.Appearance.Options.UseFont = true;
            this.cmbEmployee.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbEmployee.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbEmployee.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbEmployee.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenNV", "Tên Nhân Viên")});
            this.cmbEmployee.Properties.DisplayMember = "strHoTen";
            this.cmbEmployee.Properties.NullText = "Tên Nhân Viên";
            this.cmbEmployee.Properties.ValueMember = "strMaNV";
            this.cmbEmployee.Size = new System.Drawing.Size(192, 24);
            this.cmbEmployee.TabIndex = 20;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 29);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(192, 24);
            this.txtID.TabIndex = 19;
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(121, 59);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtDate.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtDate.Properties.Appearance.Options.UseBackColor = true;
            this.dtDate.Properties.Appearance.Options.UseFont = true;
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtDate.Size = new System.Drawing.Size(191, 24);
            this.dtDate.TabIndex = 18;
            // 
            // frmManageInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1252, 725);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcInvoiceList);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageInvoices";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcInvoiceList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoiceList;
        private DevExpress.XtraEditors.DateEdit dtFromDate;
        private DevExpress.XtraEditors.DateEdit dtToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDB;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_gvColMaNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_gvColMaKH;
        private DevExpress.XtraEditors.SimpleButton btnStatistic;
        private DevExpress.XtraEditors.SimpleButton btnBillDetail;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpdateBill;
        private DevExpress.XtraEditors.SimpleButton btnDeleteBill;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit cmbEmployee;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private DevExpress.XtraEditors.SimpleButton btnAllBill;
    }
}