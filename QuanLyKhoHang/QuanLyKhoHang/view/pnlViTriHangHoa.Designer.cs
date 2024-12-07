namespace QuanLyKhoHang.view
{
    partial class pnlViTriHangHoa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaHangHoa = new TextBox();
            txtMaKe = new TextBox();
            txtTenKe = new TextBox();
            txtTang = new TextBox();
            txtNgan = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDangXuat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 124);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hàng hóa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 183);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã kệ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 216);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên kệ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 249);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Tầng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 282);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Ngăn:";
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Location = new Point(389, 124);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.Size = new Size(227, 27);
            txtMaHangHoa.TabIndex = 5;
            txtMaHangHoa.TextChanged += txtMaHangHoa_TextChanged;
            // 
            // txtMaKe
            // 
            txtMaKe.Location = new Point(364, 180);
            txtMaKe.Name = "txtMaKe";
            txtMaKe.Size = new Size(252, 27);
            txtMaKe.TabIndex = 6;
            // 
            // txtTenKe
            // 
            txtTenKe.Location = new Point(364, 213);
            txtTenKe.Name = "txtTenKe";
            txtTenKe.Size = new Size(252, 27);
            txtTenKe.TabIndex = 7;
            // 
            // txtTang
            // 
            txtTang.Location = new Point(364, 246);
            txtTang.Name = "txtTang";
            txtTang.Size = new Size(252, 27);
            txtTang.TabIndex = 8;
            // 
            // txtNgan
            // 
            txtNgan.Location = new Point(364, 279);
            txtNgan.Name = "txtNgan";
            txtNgan.Size = new Size(252, 27);
            txtNgan.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(284, 353);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 45);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm vị trí";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(400, 353);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 45);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa vị trí";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(516, 353);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 45);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa vị trí";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.Location = new Point(284, 516);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(332, 45);
            btnDangXuat.TabIndex = 13;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // pnlViTriHangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDangXuat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtNgan);
            Controls.Add(txtTang);
            Controls.Add(txtTenKe);
            Controls.Add(txtMaKe);
            Controls.Add(txtMaHangHoa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "pnlViTriHangHoa";
            Size = new Size(900, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaHangHoa;
        private TextBox txtMaKe;
        private TextBox txtTenKe;
        private TextBox txtTang;
        private TextBox txtNgan;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDangXuat;
    }
}
