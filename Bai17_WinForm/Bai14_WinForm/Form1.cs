namespace Bai17_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show(
                    "Bạn ko được phép nhập dữ liệu rỗng!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text;

                lstLopA.Items.Add(strDuLieu);

                txtTen.Clear();
                txtTen.Focus();
            }
        }

        // Forwarding handler for the "Cập nhật" button (menu item calls this)
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Reuse the existing button1_Click logic
            button1_Click(sender, e);
        }

        // Backward-compatible forwarding for any references to old btnTrai Click handler
        private void btnTrai_Click(object sender, EventArgs e)
        {
            btnTrai1_Click(sender, e);
        }

        // Backward-compatible forwarding for any references to old btnPhai Click handler
        private void btnPhai_Click(object sender, EventArgs e)
        {
            btnPhai1_Click(sender, e);
        }

        // Chuyển các mục đang chọn
        private void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;

            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();

                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        // Chuyển toàn bộ
        private void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count > 0)
            {
                string stDuLieu = lst1.Items[0].ToString();

                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        // Xóa các mục đang chọn
        private void xoaNhieuPtu(ListBox lst)
        {
            int i = 0;

            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTrai1_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiChuyen;

                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn ko?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show(
                    "Danh sách hiện đang rỗng!",
                    "Chú ý");
            }
        }

        private void btnPhai1_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiChuyen;

                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn ko?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show(
                    "Danh sách hiện đang rỗng!",
                    "Chú ý");
            }
        }

        private void btnPhaiAll_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiChuyen;

                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển toàn bộ dữ liệu ko?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show(
                    "Danh sách hiện đang rỗng!",
                    "Chú ý");
            }
        }

        private void btnTraiAll_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiChuyen;

                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển toàn bộ dữ liệu ko?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show(
                    "Danh sách hiện đang rỗng!",
                    "Chú ý");
            }

        }

        private void btnXoaA_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiXoa;

                hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaNhieuPtu(lstLopA);
                }
            }
            else
            {
                MessageBox.Show(
                    "Hiện danh sách đang rỗng!",
                    "Chú ý");
            }
        }

        private void btnXoaB_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiXoa;

                hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaNhieuPtu(lstLopB);
                }
            }
            else
            {
                MessageBox.Show(
                    "Hiện danh sách đang rỗng!",
                    "Chú ý");
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cậpNhậtLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCapNhat_Click(sender, e);
        }

        private void cậpNhậtLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCapNhat_Click(sender, e);
        }

        private void chuyểnPhầnTửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTrai_Click(sender, e);
        }

        private void chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPhai_Click(sender, e);
        }

        private void chuyểnHếtDsLớpSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTraiAll_Click(sender, e);
        }

        private void chuyểnHếtDsLớpSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPhaiAll_Click(sender, e);
        }

        private void xóaDanhSáchLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaA_Click(sender, e);
        }

        private void xóaDanhSáchLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaB_Click(sender, e);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sinh viên thực hiện chương trình:\nNguyễn Thanh Huy\nLớp: CNTT",
                "Thông tin",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKetThuc_Click(sender, e);
        }
    }
}
