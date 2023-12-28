namespace QuanLySinhVienDA21TTC
{
    partial class frmGiaoVien
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
            this.dvggiaovien = new System.Windows.Forms.DataGridView();
            this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvggiaovien)).BeginInit();
            this.SuspendLayout();
            // 
            // dvggiaovien
            // 
            this.dvggiaovien.AllowUserToAddRows = false;
            this.dvggiaovien.AllowUserToDeleteRows = false;
            this.dvggiaovien.BackgroundColor = System.Drawing.Color.Azure;
            this.dvggiaovien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvggiaovien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvien,
            this.tensinhvien,
            this.ngaysinh,
            this.sodienthoai,
            this.email});
            this.dvggiaovien.Location = new System.Drawing.Point(0, 82);
            this.dvggiaovien.Name = "dvggiaovien";
            this.dvggiaovien.ReadOnly = true;
            this.dvggiaovien.RowHeadersWidth = 51;
            this.dvggiaovien.RowTemplate.Height = 24;
            this.dvggiaovien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvggiaovien.Size = new System.Drawing.Size(1104, 521);
            this.dvggiaovien.TabIndex = 4;
            this.dvggiaovien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvggiaovien_CellClick);
            // 
            // masinhvien
            // 
            this.masinhvien.DataPropertyName = "magiaovien";
            this.masinhvien.HeaderText = "MÃ GIÁO VIÊN";
            this.masinhvien.MinimumWidth = 6;
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.ReadOnly = true;
            this.masinhvien.Width = 150;
            // 
            // tensinhvien
            // 
            this.tensinhvien.DataPropertyName = "tengiaovien";
            this.tensinhvien.HeaderText = "TÊN GIÁO VIÊN";
            this.tensinhvien.MinimumWidth = 6;
            this.tensinhvien.Name = "tensinhvien";
            this.tensinhvien.ReadOnly = true;
            this.tensinhvien.Width = 250;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "chuyennganh";
            this.ngaysinh.HeaderText = "CHUYÊN NGÀNH";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 200;
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "SỐ ĐIỆN THOẠI";
            this.sodienthoai.MinimumWidth = 6;
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.ReadOnly = true;
            this.sodienthoai.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 250;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(717, 30);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 22);
            this.txtTimkiem.TabIndex = 5;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(935, 22);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(138, 34);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Tìm kiếm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1103, 595);
            this.Controls.Add(this.dvggiaovien);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnthem);
            this.Name = "frmGiaoVien";
            this.Text = "DANH SÁCH GIÁO VIÊN";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvggiaovien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvggiaovien;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}