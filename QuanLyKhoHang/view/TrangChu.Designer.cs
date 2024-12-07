namespace QuanLyKhoHang.view
{
    partial class TrangChu
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
            menuStrip1 = new MenuStrip();
            tsmiNhanVien = new ToolStripMenuItem();
            tsmiHangHoa = new ToolStripMenuItem();
            tsmiPhieuNhap = new ToolStripMenuItem();
            tsmiPhieuXuat = new ToolStripMenuItem();
            tsmiViTriHangHoa = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiNhanVien, tsmiHangHoa, tsmiPhieuNhap, tsmiPhieuXuat, tsmiViTriHangHoa });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(901, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiNhanVien
            // 
            tsmiNhanVien.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tsmiNhanVien.Name = "tsmiNhanVien";
            tsmiNhanVien.Size = new Size(105, 27);
            tsmiNhanVien.Text = "Nhân Viên";
            tsmiNhanVien.Click += tsmiNhanVien_Click;
            // 
            // tsmiHangHoa
            // 
            tsmiHangHoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tsmiHangHoa.Name = "tsmiHangHoa";
            tsmiHangHoa.Size = new Size(103, 27);
            tsmiHangHoa.Text = "Hàng Hóa";
            tsmiHangHoa.Click += tsmiHangHoa_Click;
            // 
            // tsmiPhieuNhap
            // 
            tsmiPhieuNhap.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tsmiPhieuNhap.Name = "tsmiPhieuNhap";
            tsmiPhieuNhap.Size = new Size(114, 27);
            tsmiPhieuNhap.Text = "Phiếu Nhập";
            tsmiPhieuNhap.Click += tsmiPhieuNhap_Click;
            // 
            // tsmiPhieuXuat
            // 
            tsmiPhieuXuat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tsmiPhieuXuat.Name = "tsmiPhieuXuat";
            tsmiPhieuXuat.Size = new Size(108, 27);
            tsmiPhieuXuat.Text = "Phiếu Xuất";
            tsmiPhieuXuat.Click += tsmiPhieuXuat_Click;
            // 
            // tsmiViTriHangHoa
            // 
            tsmiViTriHangHoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tsmiViTriHangHoa.Name = "tsmiViTriHangHoa";
            tsmiViTriHangHoa.Size = new Size(146, 27);
            tsmiViTriHangHoa.Text = "Vị Trí Hàng Hóa";
            tsmiViTriHangHoa.Click += tsmiViTriHangHoa_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 600);
            panel1.TabIndex = 1;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 623);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TrangChu";
            Text = "Trang chủ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiNhanVien;
        private ToolStripMenuItem tsmiHangHoa;
        private ToolStripMenuItem tsmiPhieuNhap;
        private ToolStripMenuItem tsmiPhieuXuat;
        private ToolStripMenuItem tsmiViTriHangHoa;
        private Panel panel1;
    }
}