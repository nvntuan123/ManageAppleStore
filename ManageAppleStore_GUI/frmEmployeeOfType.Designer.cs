
namespace ManageAppleStore_GUI
{
    partial class frmEmployeeOfType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeOfType));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gcEmployeeOfTypeList = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeOfTypeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpTTLoaiNV = new DevExpress.XtraEditors.GroupControl();
            this.txtEmployeeOfTypeName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeOfTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeOfTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTLoaiNV)).BeginInit();
            this.grpTTLoaiNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeOfTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblRefresh);
            this.panel2.Controls.Add(this.lblQuayLai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 39);
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
            this.lblRefresh.Location = new System.Drawing.Point(839, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(74, 39);
            this.lblRefresh.TabIndex = 18;
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
            this.lblQuayLai.Size = new System.Drawing.Size(180, 39);
            this.lblQuayLai.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblHienThi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 465);
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
            this.btnDelete.Location = new System.Drawing.Point(0, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 55);
            this.btnDelete.TabIndex = 22;
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
            this.btnEdit.Location = new System.Drawing.Point(0, 372);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 55);
            this.btnEdit.TabIndex = 21;
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
            this.btnAdd.Location = new System.Drawing.Point(0, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 55);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm";
            // 
            // lblHienThi
            // 
            this.lblHienThi.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblHienThi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHienThi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHienThi.Appearance.Options.UseBackColor = true;
            this.lblHienThi.Appearance.Options.UseFont = true;
            this.lblHienThi.Appearance.Options.UseForeColor = true;
            this.lblHienThi.Appearance.Options.UseTextOptions = true;
            this.lblHienThi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHienThi.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblHienThi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHienThi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblHienThi.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblHienThi.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblHienThi.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblHienThi.LineVisible = true;
            this.lblHienThi.Location = new System.Drawing.Point(12, 156);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(157, 57);
            this.lblHienThi.TabIndex = 16;
            this.lblHienThi.Text = "Quản Lý \r\nLoại Nhân Viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSave.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.Location = new System.Drawing.Point(273, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 23;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gcEmployeeOfTypeList);
            this.panel3.Controls.Add(this.grpTTLoaiNV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(180, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 465);
            this.panel3.TabIndex = 13;
            // 
            // gcEmployeeOfTypeList
            // 
            this.gcEmployeeOfTypeList.Location = new System.Drawing.Point(9, 156);
            this.gcEmployeeOfTypeList.MainView = this.gvEmployeeOfTypeList;
            this.gcEmployeeOfTypeList.Name = "gcEmployeeOfTypeList";
            this.gcEmployeeOfTypeList.Size = new System.Drawing.Size(715, 306);
            this.gcEmployeeOfTypeList.TabIndex = 1;
            this.gcEmployeeOfTypeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeOfTypeList});
            // 
            // gvEmployeeOfTypeList
            // 
            this.gvEmployeeOfTypeList.Appearance.Empty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployeeOfTypeList.Appearance.Empty.Options.UseFont = true;
            this.gvEmployeeOfTypeList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvEmployeeOfTypeList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployeeOfTypeList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEmployeeOfTypeList.Appearance.EvenRow.Options.UseFont = true;
            this.gvEmployeeOfTypeList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployeeOfTypeList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEmployeeOfTypeList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvEmployeeOfTypeList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployeeOfTypeList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEmployeeOfTypeList.Appearance.OddRow.Options.UseFont = true;
            this.gvEmployeeOfTypeList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployeeOfTypeList.Appearance.Row.Options.UseFont = true;
            this.gvEmployeeOfTypeList.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployeeOfTypeList.Appearance.SelectedRow.Options.UseFont = true;
            this.gvEmployeeOfTypeList.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvEmployeeOfTypeList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployeeOfTypeList.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvEmployeeOfTypeList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvEmployeeOfTypeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiNhanVien,
            this.colLoaiNhanVien});
            this.gvEmployeeOfTypeList.GridControl = this.gcEmployeeOfTypeList;
            this.gvEmployeeOfTypeList.Name = "gvEmployeeOfTypeList";
            this.gvEmployeeOfTypeList.OptionsBehavior.Editable = false;
            this.gvEmployeeOfTypeList.OptionsSelection.MultiSelect = true;
            this.gvEmployeeOfTypeList.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvEmployeeOfTypeList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEmployeeOfTypeList.OptionsView.EnableAppearanceOddRow = true;
            this.gvEmployeeOfTypeList.OptionsView.ShowAutoFilterRow = true;
            this.gvEmployeeOfTypeList.OptionsView.ShowGroupPanel = false;
            this.gvEmployeeOfTypeList.OptionsView.ShowIndicator = false;
            this.gvEmployeeOfTypeList.OptionsView.ShowViewCaption = true;
            this.gvEmployeeOfTypeList.ViewCaption = "Danh Sách Loại Nhân Viên";
            // 
            // colMaLoaiNhanVien
            // 
            this.colMaLoaiNhanVien.Caption = "Mã Loại Nhân Viên";
            this.colMaLoaiNhanVien.FieldName = "strMaLoaiNV";
            this.colMaLoaiNhanVien.Name = "colMaLoaiNhanVien";
            this.colMaLoaiNhanVien.Visible = true;
            this.colMaLoaiNhanVien.VisibleIndex = 0;
            // 
            // colLoaiNhanVien
            // 
            this.colLoaiNhanVien.Caption = "Loại Nhân Viên";
            this.colLoaiNhanVien.FieldName = "strTenLoaiNV";
            this.colLoaiNhanVien.Name = "colLoaiNhanVien";
            this.colLoaiNhanVien.Visible = true;
            this.colLoaiNhanVien.VisibleIndex = 1;
            // 
            // grpTTLoaiNV
            // 
            this.grpTTLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTLoaiNV.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTLoaiNV.Appearance.Options.UseFont = true;
            this.grpTTLoaiNV.AppearanceCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTLoaiNV.AppearanceCaption.Options.UseFont = true;
            this.grpTTLoaiNV.Controls.Add(this.btnSave);
            this.grpTTLoaiNV.Controls.Add(this.txtEmployeeOfTypeName);
            this.grpTTLoaiNV.Controls.Add(this.labelControl8);
            this.grpTTLoaiNV.Controls.Add(this.labelControl1);
            this.grpTTLoaiNV.Controls.Add(this.txtID);
            this.grpTTLoaiNV.Location = new System.Drawing.Point(9, 6);
            this.grpTTLoaiNV.Name = "grpTTLoaiNV";
            this.grpTTLoaiNV.Size = new System.Drawing.Size(715, 144);
            this.grpTTLoaiNV.TabIndex = 0;
            this.grpTTLoaiNV.Text = "Thông Tin Chi Tiết Loại Nhân Viên";
            // 
            // txtEmployeeOfTypeName
            // 
            this.txtEmployeeOfTypeName.Location = new System.Drawing.Point(476, 40);
            this.txtEmployeeOfTypeName.Name = "txtEmployeeOfTypeName";
            this.txtEmployeeOfTypeName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmployeeOfTypeName.Properties.Appearance.Options.UseFont = true;
            this.txtEmployeeOfTypeName.Size = new System.Drawing.Size(169, 24);
            this.txtEmployeeOfTypeName.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(357, 43);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(97, 17);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Loại Nhân Viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Loại Nhân Viên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(151, 40);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(169, 24);
            this.txtID.TabIndex = 2;
            // 
            // frmEmployeeOfType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeOfType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeOfType";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeOfTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeOfTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTLoaiNV)).EndInit();
            this.grpTTLoaiNV.ResumeLayout(false);
            this.grpTTLoaiNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeOfTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl grpTTLoaiNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtEmployeeOfTypeName;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gcEmployeeOfTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployeeOfTypeList;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiNhanVien;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
    }
}