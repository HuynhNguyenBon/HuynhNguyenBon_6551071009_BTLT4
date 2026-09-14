namespace Bai16_WinForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            frmFile = new ToolStripMenuItem();
            frmNew = new ToolStripMenuItem();
            frmOpen = new ToolStripMenuItem();
            frmSave = new ToolStripMenuItem();
            frmExit = new ToolStripMenuItem();
            forToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            frmCut = new ToolStripMenuItem();
            frmCopy = new ToolStripMenuItem();
            frmPaste = new ToolStripMenuItem();
            txtNoiDung = new RichTextBox();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { frmFile, forToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // frmFile
            // 
            frmFile.DropDownItems.AddRange(new ToolStripItem[] { frmNew, frmOpen, frmSave, frmExit });
            frmFile.Name = "frmFile";
            frmFile.Size = new Size(46, 24);
            frmFile.Text = "&File";
            // 
            // frmNew
            // 
            frmNew.Name = "frmNew";
            frmNew.Size = new Size(224, 26);
            frmNew.Text = "&New";
            frmNew.Click += frmNew_Click;
            // 
            // frmOpen
            // 
            frmOpen.Name = "frmOpen";
            frmOpen.Size = new Size(224, 26);
            frmOpen.Text = "&Open";
            frmOpen.Click += frmOpen_Click;
            // 
            // frmSave
            // 
            frmSave.Name = "frmSave";
            frmSave.Size = new Size(224, 26);
            frmSave.Text = "&Save";
            frmSave.Click += frmSave_Click;
            // 
            // frmExit
            // 
            frmExit.Name = "frmExit";
            frmExit.Size = new Size(224, 26);
            frmExit.Text = "&Exit";
            frmExit.Click += frmExit_Click;
            // 
            // forToolStripMenuItem
            // 
            forToolStripMenuItem.Name = "forToolStripMenuItem";
            forToolStripMenuItem.Size = new Size(70, 24);
            forToolStripMenuItem.Text = "&Format";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { frmCut, frmCopy, frmPaste });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 76);
            // 
            // frmCut
            // 
            frmCut.Name = "frmCut";
            frmCut.Size = new Size(112, 24);
            frmCut.Text = "&Cut";
            frmCut.Click += frmCut_Click;
            // 
            // frmCopy
            // 
            frmCopy.Name = "frmCopy";
            frmCopy.Size = new Size(112, 24);
            frmCopy.Text = "&Copy";
            frmCopy.Click += frmCopy_Click;
            // 
            // frmPaste
            // 
            frmPaste.Name = "frmPaste";
            frmPaste.Size = new Size(112, 24);
            frmPaste.Text = "&Paste";
            frmPaste.Click += frmPaste_Click;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Dock = DockStyle.Fill;
            txtNoiDung.Location = new Point(0, 28);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(800, 422);
            txtNoiDung.TabIndex = 1;
            txtNoiDung.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(txtNoiDung);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem frmFile;
        private ToolStripMenuItem frmNew;
        private ToolStripMenuItem frmOpen;
        private ToolStripMenuItem frmSave;
        private ToolStripMenuItem frmExit;
        private ToolStripMenuItem forToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem frmCut;
        private ToolStripMenuItem frmCopy;
        private ToolStripMenuItem frmPaste;
        private RichTextBox txtNoiDung;
    }
}
