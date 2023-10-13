namespace WinFormsAppAPI_QLSV
{
    partial class Form2
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
            this.tbTimId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvHienSV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMVAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCLUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienSV)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTimId
            // 
            this.tbTimId.Location = new System.Drawing.Point(534, 175);
            this.tbTimId.Name = "tbTimId";
            this.tbTimId.Size = new System.Drawing.Size(245, 27);
            this.tbTimId.TabIndex = 0;
            this.tbTimId.TextChanged += new System.EventHandler(this.tbTimId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(480, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(348, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm Id Sinh Viên";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTim.Location = new System.Drawing.Point(831, 165);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 40);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvHienSV
            // 
            this.dgvHienSV.AllowUserToAddRows = false;
            this.dgvHienSV.AllowUserToDeleteRows = false;
            this.dgvHienSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienSV.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TEN,
            this.GIOITINH,
            this.TUOI,
            this.DIEMTOAN,
            this.DIEMVAN,
            this.DIEMANH,
            this.DIEMTB,
            this.HOCLUC});
            this.dgvHienSV.Location = new System.Drawing.Point(47, 308);
            this.dgvHienSV.Name = "dgvHienSV";
            this.dgvHienSV.ReadOnly = true;
            this.dgvHienSV.RowHeadersWidth = 51;
            this.dgvHienSV.RowTemplate.Height = 29;
            this.dgvHienSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienSV.Size = new System.Drawing.Size(1172, 353);
            this.dgvHienSV.TabIndex = 4;
            this.dgvHienSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienSV_CellClick);
            this.dgvHienSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienSV_CellContentClick);
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
            this.DIEMVAN.HeaderText = "Điểm Văn";
            this.DIEMVAN.MinimumWidth = 6;
            this.DIEMVAN.Name = "DIEMVAN";
            this.DIEMVAN.ReadOnly = true;
            // 
            // DIEMANH
            // 
            this.DIEMANH.DataPropertyName = "DIEMANH";
            this.DIEMANH.HeaderText = "Điểm Anh";
            this.DIEMANH.MinimumWidth = 6;
            this.DIEMANH.Name = "DIEMANH";
            this.DIEMANH.ReadOnly = true;
            // 
            // DIEMTB
            // 
            this.DIEMTB.DataPropertyName = "DIEMTB";
            this.DIEMTB.HeaderText = "Điểm Trung Bình";
            this.DIEMTB.MinimumWidth = 6;
            this.DIEMTB.Name = "DIEMTB";
            this.DIEMTB.ReadOnly = true;
            // 
            // HOCLUC
            // 
            this.HOCLUC.DataPropertyName = "HOCLUC";
            this.HOCLUC.HeaderText = "Học Lực";
            this.HOCLUC.MinimumWidth = 6;
            this.HOCLUC.Name = "HOCLUC";
            this.HOCLUC.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 787);
            this.Controls.Add(this.dgvHienSV);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimId);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTimId;
        private Label label1;
        private Label label2;
        private Button btnTim;
        private DataGridView dgvHienSV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TEN;
        private DataGridViewTextBoxColumn GIOITINH;
        private DataGridViewTextBoxColumn TUOI;
        private DataGridViewTextBoxColumn DIEMTOAN;
        private DataGridViewTextBoxColumn DIEMVAN;
        private DataGridViewTextBoxColumn DIEMANH;
        private DataGridViewTextBoxColumn DIEMTB;
        private DataGridViewTextBoxColumn HOCLUC;
    }
}