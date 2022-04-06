namespace DOAN_CHUNGKHOAN
{
    partial class fmChungKhoan
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxBGTT = new System.Windows.Forms.GroupBox();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.listBoxThongTin = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxSoLenh = new System.Windows.Forms.GroupBox();
            this.lENHDATGridControl = new DevExpress.XtraGrid.GridControl();
            this.lENHDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUNGKHOANDataSet = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBoxDatLenh = new System.Windows.Forms.GroupBox();
            this.txtGiaDat = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnDatLenh = new System.Windows.Forms.Button();
            this.lbGiaDat = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbMACP = new System.Windows.Forms.Label();
            this.txtMaCP = new System.Windows.Forms.TextBox();
            this.radioBan = new System.Windows.Forms.RadioButton();
            this.radioMua = new System.Windows.Forms.RadioButton();
            this.lENHDATTableAdapter = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter();
            this.tableAdapterManager = new DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.groupBoxBGTT.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSoLenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxDatLenh.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBGTT
            // 
            this.groupBoxBGTT.Controls.Add(this.groupBoxThongTin);
            this.groupBoxBGTT.Controls.Add(this.dataGridView1);
            this.groupBoxBGTT.Controls.Add(this.listBox1);
            this.groupBoxBGTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBGTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxBGTT.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBGTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBGTT.Name = "groupBoxBGTT";
            this.groupBoxBGTT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBGTT.Size = new System.Drawing.Size(1793, 400);
            this.groupBoxBGTT.TabIndex = 3;
            this.groupBoxBGTT.TabStop = false;
            this.groupBoxBGTT.Text = "BẢNG GIÁ TRỰC TUYẾN";
            this.groupBoxBGTT.Enter += new System.EventHandler(this.groupBoxBGTT_Enter);
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.lbThongTin);
            this.groupBoxThongTin.Controls.Add(this.btnReset);
            this.groupBoxThongTin.Controls.Add(this.listBoxThongTin);
            this.groupBoxThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThongTin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxThongTin.Location = new System.Drawing.Point(1570, 17);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(220, 381);
            this.groupBoxThongTin.TabIndex = 7;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "THÔNG TIN";
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Location = new System.Drawing.Point(38, 192);
            this.lbThongTin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(0, 17);
            this.lbThongTin.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 192);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listBoxThongTin
            // 
            this.listBoxThongTin.FormattingEnabled = true;
            this.listBoxThongTin.ItemHeight = 16;
            this.listBoxThongTin.Location = new System.Drawing.Point(11, 22);
            this.listBoxThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxThongTin.Name = "listBoxThongTin";
            this.listBoxThongTin.Size = new System.Drawing.Size(154, 148);
            this.listBoxThongTin.TabIndex = 2;
            this.listBoxThongTin.SelectedIndexChanged += new System.EventHandler(this.listBoxThongTin_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1567, 381);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 17);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1787, 381);
            this.listBox1.TabIndex = 0;
            // 
            // groupBoxSoLenh
            // 
            this.groupBoxSoLenh.Controls.Add(this.lENHDATGridControl);
            this.groupBoxSoLenh.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSoLenh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxSoLenh.Location = new System.Drawing.Point(0, 400);
            this.groupBoxSoLenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSoLenh.Name = "groupBoxSoLenh";
            this.groupBoxSoLenh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSoLenh.Size = new System.Drawing.Size(1155, 262);
            this.groupBoxSoLenh.TabIndex = 5;
            this.groupBoxSoLenh.TabStop = false;
            this.groupBoxSoLenh.Text = "SỐ LỆNH";
            this.groupBoxSoLenh.Enter += new System.EventHandler(this.groupBoxSoLenh_Enter);
            // 
            // lENHDATGridControl
            // 
            this.lENHDATGridControl.DataSource = this.lENHDATBindingSource;
            this.lENHDATGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lENHDATGridControl.Location = new System.Drawing.Point(3, 17);
            this.lENHDATGridControl.MainView = this.gridView1;
            this.lENHDATGridControl.Name = "lENHDATGridControl";
            this.lENHDATGridControl.Size = new System.Drawing.Size(1141, 243);
            this.lENHDATGridControl.TabIndex = 0;
            this.lENHDATGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lENHDATBindingSource
            // 
            this.lENHDATBindingSource.DataMember = "LENHDAT";
            this.lENHDATBindingSource.DataSource = this.cHUNGKHOANDataSet;
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Tomato;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.GridControl = this.lENHDATGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // groupBoxDatLenh
            // 
            this.groupBoxDatLenh.Controls.Add(this.txtGiaDat);
            this.groupBoxDatLenh.Controls.Add(this.txtSoLuong);
            this.groupBoxDatLenh.Controls.Add(this.dtpNgay);
            this.groupBoxDatLenh.Controls.Add(this.btnDatLenh);
            this.groupBoxDatLenh.Controls.Add(this.lbGiaDat);
            this.groupBoxDatLenh.Controls.Add(this.lbSoLuong);
            this.groupBoxDatLenh.Controls.Add(this.lbNgay);
            this.groupBoxDatLenh.Controls.Add(this.lbMACP);
            this.groupBoxDatLenh.Controls.Add(this.txtMaCP);
            this.groupBoxDatLenh.Controls.Add(this.radioBan);
            this.groupBoxDatLenh.Controls.Add(this.radioMua);
            this.groupBoxDatLenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDatLenh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxDatLenh.Location = new System.Drawing.Point(1155, 400);
            this.groupBoxDatLenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDatLenh.Name = "groupBoxDatLenh";
            this.groupBoxDatLenh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDatLenh.Size = new System.Drawing.Size(638, 262);
            this.groupBoxDatLenh.TabIndex = 6;
            this.groupBoxDatLenh.TabStop = false;
            this.groupBoxDatLenh.Text = "ĐẶT LỆNH MỚI";
            this.groupBoxDatLenh.Enter += new System.EventHandler(this.groupBoxDatLenh_Enter);
            // 
            // txtGiaDat
            // 
            this.txtGiaDat.Location = new System.Drawing.Point(326, 248);
            this.txtGiaDat.Name = "txtGiaDat";
            this.txtGiaDat.Size = new System.Drawing.Size(200, 22);
            this.txtGiaDat.TabIndex = 15;
            this.txtGiaDat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaDat_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(326, 203);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 22);
            this.txtSoLuong.TabIndex = 14;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "";
            this.dtpNgay.Enabled = false;
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(326, 155);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpNgay.TabIndex = 13;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // btnDatLenh
            // 
            this.btnDatLenh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDatLenh.Location = new System.Drawing.Point(252, 318);
            this.btnDatLenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatLenh.Name = "btnDatLenh";
            this.btnDatLenh.Size = new System.Drawing.Size(75, 23);
            this.btnDatLenh.TabIndex = 10;
            this.btnDatLenh.Text = "ĐẶT LỆNH";
            this.btnDatLenh.UseVisualStyleBackColor = true;
            this.btnDatLenh.Click += new System.EventHandler(this.btnDatLenh_Click);
            // 
            // lbGiaDat
            // 
            this.lbGiaDat.AutoSize = true;
            this.lbGiaDat.Location = new System.Drawing.Point(136, 253);
            this.lbGiaDat.Name = "lbGiaDat";
            this.lbGiaDat.Size = new System.Drawing.Size(63, 17);
            this.lbGiaDat.TabIndex = 9;
            this.lbGiaDat.Text = "GIÁ ĐẶT";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(136, 203);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(82, 17);
            this.lbSoLuong.TabIndex = 8;
            this.lbSoLuong.Text = "SỐ LƯỢNG";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(136, 155);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(47, 17);
            this.lbNgay.TabIndex = 7;
            this.lbNgay.Text = "NGÀY";
            // 
            // lbMACP
            // 
            this.lbMACP.AutoSize = true;
            this.lbMACP.Location = new System.Drawing.Point(136, 109);
            this.lbMACP.Name = "lbMACP";
            this.lbMACP.Size = new System.Drawing.Size(50, 17);
            this.lbMACP.TabIndex = 6;
            this.lbMACP.Text = "MÃ CP";
            // 
            // txtMaCP
            // 
            this.txtMaCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaCP.Location = new System.Drawing.Point(326, 109);
            this.txtMaCP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(200, 22);
            this.txtMaCP.TabIndex = 2;
            this.txtMaCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaCP_KeyPress);
            // 
            // radioBan
            // 
            this.radioBan.AutoSize = true;
            this.radioBan.Location = new System.Drawing.Point(326, 51);
            this.radioBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBan.Name = "radioBan";
            this.radioBan.Size = new System.Drawing.Size(57, 21);
            this.radioBan.TabIndex = 1;
            this.radioBan.Text = "BÁN";
            this.radioBan.UseVisualStyleBackColor = true;
            this.radioBan.CheckedChanged += new System.EventHandler(this.radioBan_CheckedChanged);
            // 
            // radioMua
            // 
            this.radioMua.AutoSize = true;
            this.radioMua.Location = new System.Drawing.Point(139, 51);
            this.radioMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMua.Name = "radioMua";
            this.radioMua.Size = new System.Drawing.Size(59, 21);
            this.radioMua.TabIndex = 0;
            this.radioMua.Text = "MUA";
            this.radioMua.UseVisualStyleBackColor = true;
            this.radioMua.CheckedChanged += new System.EventHandler(this.radioMua_CheckedChanged);
            // 
            // lENHDATTableAdapter
            // 
            this.lENHDATTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LENHDATTableAdapter = this.lENHDATTableAdapter;
            this.tableAdapterManager.LENHKHOPTableAdapter = null;
            this.tableAdapterManager.TRUCTUYENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DOAN_CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fmChungKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1793, 662);
            this.Controls.Add(this.groupBoxDatLenh);
            this.Controls.Add(this.groupBoxSoLenh);
            this.Controls.Add(this.groupBoxBGTT);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fmChungKhoan";
            this.Text = "Chứng khoán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxBGTT.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSoLenh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxDatLenh.ResumeLayout(false);
            this.groupBoxDatLenh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBGTT;
        private System.Windows.Forms.GroupBox groupBoxSoLenh;
        private System.Windows.Forms.GroupBox groupBoxDatLenh;
        private System.Windows.Forms.Label lbGiaDat;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbMACP;
        private System.Windows.Forms.TextBox txtMaCP;
        private System.Windows.Forms.RadioButton radioBan;
        private System.Windows.Forms.RadioButton radioMua;
        private System.Windows.Forms.Button btnDatLenh;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.ListBox listBoxThongTin;
        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
        private System.Windows.Forms.BindingSource lENHDATBindingSource;
        private CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter lENHDATTableAdapter;
        private CHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lENHDATGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaDat;
    }
}

