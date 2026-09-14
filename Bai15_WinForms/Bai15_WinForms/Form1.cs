namespace Bai15_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown dudColor = (DomainUpDown)sender;
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudSize = (NumericUpDown)sender;
            lblSampleText.Font = new Font(label1.Font.FontFamily, (float)nudSize.Value);
        }
    }
}
