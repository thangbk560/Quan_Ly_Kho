namespace QuanLyKhoHang.view
{
    partial class F_PN_Sua
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
            btnThoat = new Button();
            btnSua = new Button();
            btnDatLai = new Button();
            dtpNgayNhap = new DateTimePicker();
            txtMaHangHoa = new TextBox();
            txtNhaCungCap = new TextBox();
            txtMaNhanVien = new TextBox();
            txtMaPhieu = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            nudSoLuongNhap = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongNhap).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(314, 250);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 45);
            btnThoat.TabIndex = 51;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(191, 250);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 45);
            btnSua.TabIndex = 50;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnDatLai
            // 
            btnDatLai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatLai.Location = new Point(68, 250);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(100, 45);
            btnDatLai.TabIndex = 49;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.UseVisualStyleBackColor = true;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(178, 71);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(236, 27);
            dtpNgayNhap.TabIndex = 63;
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Location = new Point(178, 172);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.Size = new Size(236, 27);
            txtMaHangHoa.TabIndex = 61;
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Location = new Point(178, 139);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.Size = new Size(236, 27);
            txtNhaCungCap.TabIndex = 60;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(177, 106);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(236, 27);
            txtMaNhanVien.TabIndex = 59;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(178, 40);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(236, 27);
            txtMaPhieu.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 208);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 57;
            label7.Text = "Số lượng nhập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 175);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 56;
            label5.Text = "Mã hàng hóa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 142);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 55;
            label4.Text = "Nhà cung cấp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 109);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 54;
            label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 76);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 53;
            label2.Text = "Ngày nhập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 43);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 52;
            label6.Text = "Mã phiếu:";
            // 
            // nudSoLuongNhap
            // 
            nudSoLuongNhap.Location = new Point(178, 206);
            nudSoLuongNhap.Name = "nudSoLuongNhap";
            nudSoLuongNhap.Size = new Size(235, 27);
            nudSoLuongNhap.TabIndex = 64;
            // 
            // F_PN_Sua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 303);
            Controls.Add(nudSoLuongNhap);
            Controls.Add(dtpNgayNhap);
            Controls.Add(txtMaHangHoa);
            Controls.Add(txtNhaCungCap);
            Controls.Add(txtMaNhanVien);
            Controls.Add(txtMaPhieu);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnDatLai);
            Name = "F_PN_Sua";
            Text = "F_PN_Sua";
            ((System.ComponentModel.ISupportInitialize)nudSoLuongNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnSua;
        private Button btnDatLai;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtMaHangHoa;
        private TextBox txtNhaCungCap;
        private TextBox txtMaNhanVien;
        private TextBox txtMaPhieu;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private NumericUpDown nudSoLuongNhap;
    }
}