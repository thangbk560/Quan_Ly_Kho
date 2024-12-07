namespace QuanLyKhoHang.view
{
    partial class DangKy
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
            btnDangKy = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label4 = new Label();
            chkHienThiMatKhau = new CheckBox();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.Location = new Point(354, 260);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(125, 45);
            btnDangKy.TabIndex = 17;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(103, 260);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(125, 45);
            btnDangNhap.TabIndex = 16;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(246, 156);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(233, 27);
            txtMatKhau.TabIndex = 14;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(246, 123);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(233, 27);
            txtTenDangNhap.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 159);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 12;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 126);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 11;
            label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 39);
            label1.Name = "label1";
            label1.Size = new Size(126, 38);
            label1.TabIndex = 10;
            label1.Text = "Đăng ký";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(246, 190);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(233, 27);
            txtXacNhanMatKhau.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 193);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 19;
            label4.Text = "Xác nhận mật khẩu:";
            // 
            // chkHienThiMatKhau
            // 
            chkHienThiMatKhau.AutoSize = true;
            chkHienThiMatKhau.Location = new Point(246, 223);
            chkHienThiMatKhau.Name = "chkHienThiMatKhau";
            chkHienThiMatKhau.Size = new Size(148, 24);
            chkHienThiMatKhau.TabIndex = 20;
            chkHienThiMatKhau.Text = "Hiển thị mật khẩu";
            chkHienThiMatKhau.UseVisualStyleBackColor = true;
            chkHienThiMatKhau.CheckedChanged += chkHienThiMatKhau_CheckedChanged;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 338);
            Controls.Add(chkHienThiMatKhau);
            Controls.Add(label4);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangKy";
            Text = "Đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangKy;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtXacNhanMatKhau;
        private Label label4;
        private CheckBox chkHienThiMatKhau;
    }
}