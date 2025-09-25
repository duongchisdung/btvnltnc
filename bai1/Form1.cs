using System;
using System.Windows.Forms;

namespace bai1
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }

        // Xử lý nút Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao = "Tên đăng nhập là: " + txtUser.Text;
            thongbao += "\nMật khẩu là: " + txtPass.Text;

            if (chkNho.Checked)
            {
                thongbao += "\nBạn có ghi nhớ.";
            }

            MessageBox.Show(thongbao, "Thông báo");
        }

        // Xử lý nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.ResetText();
            txtPass.ResetText();
            txtUser.Focus();
        }

        // Xử lý nút Dừng
        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();  // thoát hẳn chương trình
        }

        private void chkNho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmBai1_1_Load(object sender, EventArgs e)
        {

        }
    }
}
