namespace QuanLySinhVienDA21TTC.UC_CONTROL
{
    partial class TraCuuDiem
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dvgTraCuu = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemquatrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(818, 27);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(138, 34);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTimkiem.Location = new System.Drawing.Point(456, 35);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 22);
            this.txtTimkiem.TabIndex = 14;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(674, 27);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(138, 34);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Tra Cứu";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // dvgTraCuu
            // 
            this.dvgTraCuu.AllowUserToAddRows = false;
            this.dvgTraCuu.AllowUserToDeleteRows = false;
            this.dvgTraCuu.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dvgTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoc,
            this.tenmonhoc,
            this.tensinhvien,
            this.diemquatrinh,
            this.diemthi});
            this.dvgTraCuu.Location = new System.Drawing.Point(12, 83);
            this.dvgTraCuu.Name = "dvgTraCuu";
            this.dvgTraCuu.ReadOnly = true;
            this.dvgTraCuu.RowHeadersWidth = 51;
            this.dvgTraCuu.RowTemplate.Height = 24;
            this.dvgTraCuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgTraCuu.Size = new System.Drawing.Size(1087, 528);
            this.dvgTraCuu.TabIndex = 18;
            this.dvgTraCuu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDiem_CellFormatting);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(961, 27);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(138, 34);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.button1_Click);
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
            // TraCuuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dvgTraCuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnthem);
            this.Name = "TraCuuDiem";
            this.Size = new System.Drawing.Size(1123, 614);
            this.Load += new System.EventHandler(this.TraCuuDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnthem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView dvgTraCuu;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemquatrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthi;
    }
}
