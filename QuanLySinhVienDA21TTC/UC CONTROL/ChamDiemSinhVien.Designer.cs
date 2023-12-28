namespace QuanLySinhVienDA21TTC.UC_CONTROL
{
    partial class ChamDiemSinhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemquatrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
            this.dgvDiem.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoc,
            this.tenmonhoc,
            this.masinhvien,
            this.tensinhvien,
            this.diemquatrinh,
            this.diemthi,
            this.diemtongket});
            this.dgvDiem.Location = new System.Drawing.Point(21, 67);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(1087, 528);
            this.dgvDiem.TabIndex = 17;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            this.dgvDiem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDiem_CellFormatting);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(926, 15);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(138, 34);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTimkiem.Location = new System.Drawing.Point(564, 23);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 22);
            this.txtTimkiem.TabIndex = 18;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(782, 15);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(138, 34);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Tìm kiếm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "MÃ MÔN HỌC";
            this.mamonhoc.MinimumWidth = 6;
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.ReadOnly = true;
            this.mamonhoc.Width = 200;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "TÊN MÔN HỌC";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            this.tenmonhoc.Width = 250;
            // 
            // masinhvien
            // 
            this.masinhvien.DataPropertyName = "masinhvien";
            this.masinhvien.HeaderText = "MÃ SINH VIÊN";
            this.masinhvien.MinimumWidth = 6;
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.ReadOnly = true;
            this.masinhvien.Width = 200;
            // 
            // tensinhvien
            // 
            this.tensinhvien.DataPropertyName = "tensinhvien";
            this.tensinhvien.HeaderText = "TÊN SINH VIÊN";
            this.tensinhvien.MinimumWidth = 6;
            this.tensinhvien.Name = "tensinhvien";
            this.tensinhvien.ReadOnly = true;
            this.tensinhvien.Width = 250;
            // 
            // diemquatrinh
            // 
            this.diemquatrinh.DataPropertyName = "diemquatrinh";
            this.diemquatrinh.HeaderText = "ĐIỂM QUÁ TRÌNH";
            this.diemquatrinh.MinimumWidth = 6;
            this.diemquatrinh.Name = "diemquatrinh";
            this.diemquatrinh.ReadOnly = true;
            this.diemquatrinh.Width = 200;
            // 
            // diemthi
            // 
            this.diemthi.DataPropertyName = "diemthi";
            this.diemthi.HeaderText = "ĐIỂM THI";
            this.diemthi.MinimumWidth = 6;
            this.diemthi.Name = "diemthi";
            this.diemthi.ReadOnly = true;
            this.diemthi.Width = 200;
            // 
            // diemtongket
            // 
            this.diemtongket.DataPropertyName = "diemtongket";
            this.diemtongket.HeaderText = "ĐIỂM TỔNG KẾT";
            this.diemtongket.MinimumWidth = 6;
            this.diemtongket.Name = "diemtongket";
            this.diemtongket.ReadOnly = true;
            this.diemtongket.Width = 200;
            // 
            // ChamDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnthem);
            this.Name = "ChamDiemSinhVien";
            this.Size = new System.Drawing.Size(1131, 609);
            this.Load += new System.EventHandler(this.ChamDiemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnthem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemquatrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtongket;
    }
}
