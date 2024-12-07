namespace QuanLyKhoHang.view
{
    partial class pnlNhanVien
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
            dgvNhanVien = new DataGridView();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDangXuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(3, 70);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(666, 527);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.ColumnHeaderMouseClick += dgvNhanVien_ColumnHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(82, 25);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(587, 27);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(711, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 45);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm nhân viên";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(711, 76);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 45);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa thông tin";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(711, 127);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 45);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa nhân viên";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.Location = new Point(711, 516);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 45);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // pnlNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDangXuat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvNhanVien);
            Name = "pnlNhanVien";
            Size = new Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhanVien;
        private Label label1;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDangXuat;
    }
}
