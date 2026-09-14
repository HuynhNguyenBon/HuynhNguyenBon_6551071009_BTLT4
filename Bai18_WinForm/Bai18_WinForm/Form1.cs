namespace Bai18_WinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mởFormConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formcon f = new Formcon();
            f.MdiParent = this;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
