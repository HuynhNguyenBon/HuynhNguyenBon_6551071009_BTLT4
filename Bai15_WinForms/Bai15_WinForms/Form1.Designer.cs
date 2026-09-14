namespace Bai15_WinForms
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
            dudColor = new DomainUpDown();
            nudSize = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            lblSampleText = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // dudColor
            // 
            dudColor.Items.Add("Black");
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Blue");
            dudColor.Location = new Point(344, 110);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(150, 27);
            dudColor.TabIndex = 0;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // nudSize
            // 
            nudSize.Location = new Point(344, 209);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(150, 27);
            nudSize.TabIndex = 1;
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 112);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 2;
            label1.Text = "Color";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 209);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Size";
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSampleText.Location = new Point(319, 319);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(175, 40);
            lblSampleText.TabIndex = 4;
            lblSampleText.Text = "Sample Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSampleText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudSize);
            Controls.Add(dudColor);
            Name = "Form1";
            Text = "StepByStep2_12";
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown dudColor;
        private NumericUpDown nudSize;
        private Label label1;
        private Label label2;
        private Label lblSampleText;
    }
}
