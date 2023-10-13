namespace WinFormsAppAPI_QLSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMVAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCLUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDiemAnh = new System.Windows.Forms.TextBox();
            this.tbDiemTB = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbDiemToan = new System.Windows.Forms.TextBox();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.tbHocLuc = new System.Windows.Forms.TextBox();
            this.tbTuoi = new System.Windows.Forms.TextBox();
            this.tbDiemVan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AllowUserToAddRows = false;
            this.dgvDSSV.AllowUserToDeleteRows = false;
            this.dgvDSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TEN,
            this.GIOITINH,
            this.TUOI,
            this.DIEMTOAN,
            this.DIEMVAN,
            this.DIEMANH,
            this.DIEMTB,
            this.HOCLUC});
            this.dgvDSSV.Location = new System.Drawing.Point(21, 127);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.ReadOnly = true;
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 29;
            this.dgvDSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSV.Size = new System.Drawing.Size(983, 458);
            this.dgvDSSV.TabIndex = 0;
            this.dgvDSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_CellClick);
            this.dgvDSSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.MinimumWidth = 6;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // TUOI
            // 
            this.TUOI.DataPropertyName = "TUOI";
            this.TUOI.HeaderText = "Tuổi";
            this.TUOI.MinimumWidth = 6;
            this.TUOI.Name = "TUOI";
            this.TUOI.ReadOnly = true;
            // 
            // DIEMTOAN
            // 
            this.DIEMTOAN.DataPropertyName = "DIEMTOAN";
            this.DIEMTOAN.HeaderText = "Điểm toán";
            this.DIEMTOAN.MinimumWidth = 6;
            this.DIEMTOAN.Name = "DIEMTOAN";
            this.DIEMTOAN.ReadOnly = true;
            // 
            // DIEMVAN
            // 
            this.DIEMVAN.DataPropertyName = "DIEMVAN";
            this.DIEMVAN.HeaderText = "Điểm văn";
            this.DIEMVAN.MinimumWidth = 6;
            this.DIEMVAN.Name = "DIEMVAN";
            this.DIEMVAN.ReadOnly = true;
            // 
            // DIEMANH
            // 
            this.DIEMANH.DataPropertyName = "DIEMANH";
            this.DIEMANH.HeaderText = "Điểm anh";
            this.DIEMANH.MinimumWidth = 6;
            this.DIEMANH.Name = "DIEMANH";
            this.DIEMANH.ReadOnly = true;
            // 
            // DIEMTB
            // 
            this.DIEMTB.DataPropertyName = "DIEMTB";
            this.DIEMTB.HeaderText = "Điểm trung bình";
            this.DIEMTB.MinimumWidth = 6;
            this.DIEMTB.Name = "DIEMTB";
            this.DIEMTB.ReadOnly = true;
            // 
            // HOCLUC
            // 
            this.HOCLUC.DataPropertyName = "HOCLUC";
            this.HOCLUC.HeaderText = "Học lực";
            this.HOCLUC.MinimumWidth = 6;
            this.HOCLUC.Name = "HOCLUC";
            this.HOCLUC.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(680, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1050, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1050, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1050, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1050, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tuổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1050, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điểm Toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1050, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Điểm Văn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1050, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Điểm Anh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1050, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "Điểm Trung bình";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1050, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 28);
            this.label10.TabIndex = 10;
            this.label10.Text = "Học lực";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(1223, 132);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(324, 27);
            this.tbId.TabIndex = 11;
            // 
            // tbDiemAnh
            // 
            this.tbDiemAnh.Location = new System.Drawing.Point(1223, 455);
            this.tbDiemAnh.Name = "tbDiemAnh";
            this.tbDiemAnh.Size = new System.Drawing.Size(324, 27);
            this.tbDiemAnh.TabIndex = 12;
            // 
            // tbDiemTB
            // 
            this.tbDiemTB.Location = new System.Drawing.Point(1223, 505);
            this.tbDiemTB.Name = "tbDiemTB";
            this.tbDiemTB.Size = new System.Drawing.Size(324, 27);
            this.tbDiemTB.TabIndex = 13;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(1223, 185);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(324, 27);
            this.tbTen.TabIndex = 14;
            // 
            // tbDiemToan
            // 
            this.tbDiemToan.Location = new System.Drawing.Point(1223, 350);
            this.tbDiemToan.Name = "tbDiemToan";
            this.tbDiemToan.Size = new System.Drawing.Size(324, 27);
            this.tbDiemToan.TabIndex = 15;
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(1223, 235);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(324, 27);
            this.tbGioiTinh.TabIndex = 16;
            // 
            // tbHocLuc
            // 
            this.tbHocLuc.Location = new System.Drawing.Point(1223, 554);
            this.tbHocLuc.Name = "tbHocLuc";
            this.tbHocLuc.Size = new System.Drawing.Size(324, 27);
            this.tbHocLuc.TabIndex = 17;
            // 
            // tbTuoi
            // 
            this.tbTuoi.Location = new System.Drawing.Point(1223, 292);
            this.tbTuoi.Name = "tbTuoi";
            this.tbTuoi.Size = new System.Drawing.Size(324, 27);
            this.tbTuoi.TabIndex = 18;
            // 
            // tbDiemVan
            // 
            this.tbDiemVan.Location = new System.Drawing.Point(1223, 401);
            this.tbDiemVan.Name = "tbDiemVan";
            this.tbDiemVan.Size = new System.Drawing.Size(324, 27);
            this.tbDiemVan.TabIndex = 19;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(1034, 647);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 60);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_ClickAsync);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(1180, 647);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 60);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(1319, 647);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 60);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTim.Location = new System.Drawing.Point(1462, 647);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 60);
            this.btnTim.TabIndex = 23;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 824);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbDiemVan);
            this.Controls.Add(this.tbTuoi);
            this.Controls.Add(this.tbHocLuc);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.tbDiemToan);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbDiemTB);
            this.Controls.Add(this.tbDiemAnh);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDSSV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TEN;
        private DataGridViewTextBoxColumn GIOITINH;
        private DataGridViewTextBoxColumn TUOI;
        private DataGridViewTextBoxColumn DIEMTOAN;
        private DataGridViewTextBoxColumn DIEMVAN;
        private DataGridViewTextBoxColumn DIEMANH;
        private DataGridViewTextBoxColumn DIEMTB;
        private DataGridViewTextBoxColumn HOCLUC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox tbId;
        private TextBox tbDiemAnh;
        private TextBox tbDiemTB;
        private TextBox tbTen;
        private TextBox tbDiemToan;
        private TextBox tbGioiTinh;
        private TextBox tbHocLuc;
        private TextBox tbTuoi;
        private TextBox tbDiemVan;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTim;
    }
}