namespace Bai17_WinForm
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
            lblTen = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            btnPhai1 = new Button();
            btnTrai1 = new Button();
            btnPhaiAll = new Button();
            btnTraiAll = new Button();
            lstLopB = new ListBox();
            btnXoaA = new Button();
            btnKetThuc = new Button();
            btnXoaB = new Button();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpAToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsLớpSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsLớpSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpAToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpBToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            kếtThúcToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen.Location = new Point(144, 85);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(74, 25);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(224, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(300, 27);
            txtTen.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = SystemColors.AppWorkspace;
            btnCapNhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(534, 80);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(139, 36);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += button1_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(144, 139);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(145, 184);
            lstLopA.TabIndex = 3;
            lstLopA.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnPhai1
            // 
            btnPhai1.BackColor = SystemColors.AppWorkspace;
            btnPhai1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhai1.Location = new Point(345, 139);
            btnPhai1.Name = "btnPhai1";
            btnPhai1.Size = new Size(94, 29);
            btnPhai1.TabIndex = 4;
            btnPhai1.Text = ">";
            btnPhai1.UseVisualStyleBackColor = false;
            btnPhai1.Click += btnPhai1_Click;
            // 
            // btnTrai1
            // 
            btnTrai1.BackColor = SystemColors.AppWorkspace;
            btnTrai1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrai1.Location = new Point(345, 192);
            btnTrai1.Name = "btnTrai1";
            btnTrai1.Size = new Size(94, 29);
            btnTrai1.TabIndex = 5;
            btnTrai1.Text = "<";
            btnTrai1.UseVisualStyleBackColor = false;
            btnTrai1.Click += btnTrai1_Click;
            // 
            // btnPhaiAll
            // 
            btnPhaiAll.BackColor = SystemColors.AppWorkspace;
            btnPhaiAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhaiAll.Location = new Point(345, 243);
            btnPhaiAll.Name = "btnPhaiAll";
            btnPhaiAll.Size = new Size(94, 29);
            btnPhaiAll.TabIndex = 6;
            btnPhaiAll.Text = ">>";
            btnPhaiAll.UseVisualStyleBackColor = false;
            btnPhaiAll.Click += btnPhaiAll_Click;
            // 
            // btnTraiAll
            // 
            btnTraiAll.BackColor = SystemColors.AppWorkspace;
            btnTraiAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraiAll.Location = new Point(345, 294);
            btnTraiAll.Name = "btnTraiAll";
            btnTraiAll.Size = new Size(94, 29);
            btnTraiAll.TabIndex = 7;
            btnTraiAll.Text = "<<";
            btnTraiAll.UseVisualStyleBackColor = false;
            btnTraiAll.Click += btnTraiAll_Click;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(497, 139);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(168, 184);
            lstLopB.TabIndex = 8;
            // 
            // btnXoaA
            // 
            btnXoaA.BackColor = SystemColors.AppWorkspace;
            btnXoaA.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaA.Location = new Point(156, 353);
            btnXoaA.Name = "btnXoaA";
            btnXoaA.Size = new Size(123, 40);
            btnXoaA.TabIndex = 9;
            btnXoaA.Text = "Xóa lớp A";
            btnXoaA.UseVisualStyleBackColor = false;
            btnXoaA.Click += btnXoaA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = SystemColors.AppWorkspace;
            btnKetThuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKetThuc.Location = new Point(333, 353);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(123, 40);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = false;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaB
            // 
            btnXoaB.BackColor = SystemColors.AppWorkspace;
            btnXoaB.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaB.Location = new Point(519, 353);
            btnXoaB.Name = "btnXoaB";
            btnXoaB.Size = new Size(123, 40);
            btnXoaB.TabIndex = 11;
            btnXoaB.Text = "Xóa lớp B";
            btnXoaB.UseVisualStyleBackColor = false;
            btnXoaB.Click += btnXoaB_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cyan;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtLớpAToolStripMenuItem, cậpNhậtLớpBToolStripMenuItem, chuyểnPhầnTửToolStripMenuItem, chuyểnPhầnTửChọnSangLớpBToolStripMenuItem, chuyểnHếtDsLớpSangLớpAToolStripMenuItem, chuyểnHếtDsLớpSangLớpBToolStripMenuItem, xóaDanhSáchLớpAToolStripMenuItem, xóaDanhSáchLớpBToolStripMenuItem });
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(85, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            cậpNhậtToolStripMenuItem.Click += cậpNhậtToolStripMenuItem_Click;
            // 
            // cậpNhậtLớpAToolStripMenuItem
            // 
            cậpNhậtLớpAToolStripMenuItem.Name = "cậpNhậtLớpAToolStripMenuItem";
            cậpNhậtLớpAToolStripMenuItem.Size = new Size(306, 26);
            cậpNhậtLớpAToolStripMenuItem.Text = "Cập Nhật Lớp A";
            cậpNhậtLớpAToolStripMenuItem.Click += cậpNhậtLớpAToolStripMenuItem_Click;
            // 
            // cậpNhậtLớpBToolStripMenuItem
            // 
            cậpNhậtLớpBToolStripMenuItem.Name = "cậpNhậtLớpBToolStripMenuItem";
            cậpNhậtLớpBToolStripMenuItem.Size = new Size(306, 26);
            cậpNhậtLớpBToolStripMenuItem.Text = "Cập Nhật Lớp B";
            cậpNhậtLớpBToolStripMenuItem.Click += cậpNhậtLớpBToolStripMenuItem_Click;
            // 
            // chuyểnPhầnTửToolStripMenuItem
            // 
            chuyểnPhầnTửToolStripMenuItem.Name = "chuyểnPhầnTửToolStripMenuItem";
            chuyểnPhầnTửToolStripMenuItem.Size = new Size(306, 26);
            chuyểnPhầnTửToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp A";
            chuyểnPhầnTửToolStripMenuItem.Click += chuyểnPhầnTửToolStripMenuItem_Click;
            // 
            // chuyểnPhầnTửChọnSangLớpBToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpBToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Size = new Size(306, 26);
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp B";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click;
            // 
            // chuyểnHếtDsLớpSangLớpAToolStripMenuItem
            // 
            chuyểnHếtDsLớpSangLớpAToolStripMenuItem.Name = "chuyểnHếtDsLớpSangLớpAToolStripMenuItem";
            chuyểnHếtDsLớpSangLớpAToolStripMenuItem.Size = new Size(306, 26);
            chuyểnHếtDsLớpSangLớpAToolStripMenuItem.Text = "Chuyển hết ds lớp sang lớp A";
            chuyểnHếtDsLớpSangLớpAToolStripMenuItem.Click += chuyểnHếtDsLớpSangLớpAToolStripMenuItem_Click;
            // 
            // chuyểnHếtDsLớpSangLớpBToolStripMenuItem
            // 
            chuyểnHếtDsLớpSangLớpBToolStripMenuItem.Name = "chuyểnHếtDsLớpSangLớpBToolStripMenuItem";
            chuyểnHếtDsLớpSangLớpBToolStripMenuItem.Size = new Size(306, 26);
            chuyểnHếtDsLớpSangLớpBToolStripMenuItem.Text = "Chuyển hết ds lớp sang lớp B";
            chuyểnHếtDsLớpSangLớpBToolStripMenuItem.Click += chuyểnHếtDsLớpSangLớpBToolStripMenuItem_Click;
            // 
            // xóaDanhSáchLớpAToolStripMenuItem
            // 
            xóaDanhSáchLớpAToolStripMenuItem.Name = "xóaDanhSáchLớpAToolStripMenuItem";
            xóaDanhSáchLớpAToolStripMenuItem.Size = new Size(306, 26);
            xóaDanhSáchLớpAToolStripMenuItem.Text = "Xóa danh sách lớp A";
            xóaDanhSáchLớpAToolStripMenuItem.Click += xóaDanhSáchLớpAToolStripMenuItem_Click;
            // 
            // xóaDanhSáchLớpBToolStripMenuItem
            // 
            xóaDanhSáchLớpBToolStripMenuItem.Name = "xóaDanhSáchLớpBToolStripMenuItem";
            xóaDanhSáchLớpBToolStripMenuItem.Size = new Size(306, 26);
            xóaDanhSáchLớpBToolStripMenuItem.Text = "Xóa danh sách lớp B";
            xóaDanhSáchLớpBToolStripMenuItem.Click += xóaDanhSáchLớpBToolStripMenuItem_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, kếtThúcToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(224, 26);
            thôngTinToolStripMenuItem.Text = "Thông Tin";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click;
            // 
            // kếtThúcToolStripMenuItem
            // 
            kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            kếtThúcToolStripMenuItem.Size = new Size(224, 26);
            kếtThúcToolStripMenuItem.Text = "Kết Thúc";
            kếtThúcToolStripMenuItem.Click += kếtThúcToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoaB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaA);
            Controls.Add(lstLopB);
            Controls.Add(btnTraiAll);
            Controls.Add(btnPhaiAll);
            Controls.Add(btnTrai1);
            Controls.Add(btnPhai1);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private TextBox txtTen;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private Button btnPhai1;
        private Button btnTrai1;
        private Button btnPhaiAll;
        private Button btnTraiAll;
        private ListBox lstLopB;
        private Button btnXoaA;
        private Button btnKetThuc;
        private Button btnXoaB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpAToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsLớpSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsLớpSangLớpBToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpAToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpBToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem kếtThúcToolStripMenuItem;
    }
}
