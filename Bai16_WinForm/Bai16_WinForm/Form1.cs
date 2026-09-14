namespace Bai16_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNew_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
            txtNoiDung.Focus();
        }

        private void frmOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open");
        }

        private void frmSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save");
        }

        private void frmCut_Click(object sender, EventArgs e)
        {
            txtNoiDung.Cut();
        }

        private void frmCopy_Click(object sender, EventArgs e)
        {
            txtNoiDung.Copy();
        }

        private void frmPaste_Click(object sender, EventArgs e)
        {
            txtNoiDung.Paste();
        }
    }
}
