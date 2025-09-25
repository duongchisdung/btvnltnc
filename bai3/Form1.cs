using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtSo.Text.Trim();

            // Kiểm tra có phải là số nguyên không
            if (!int.TryParse(input, out int so) || so <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.SelectAll();
                txtSo.Focus();
                return;
            }

            // Thêm vào ComboBox nếu chưa tồn tại
            if (!cboSo.Items.Contains(input))
            {
                cboSo.Items.Add(input);
            }

            // Đặt lại TextBox
            txtSo.Clear();
            txtSo.Focus();

        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUocSo.Items.Clear(); // Xóa danh sách cũ

            int so = int.Parse(cboSo.SelectedItem.ToString());

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    lstUocSo.Items.Add(i);
                }
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lstUocSo.Items.Count; i++)
            {
                tong += int.Parse(lstUocSo.Items[i].ToString());
            }

            MessageBox.Show("Tổng các ước số là: " + tong, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            int demChan = 0;
            for (int i = 0; i < lstUocSo.Items.Count; i++)
            {
                int so = int.Parse(lstUocSo.Items[i].ToString());
                if (so % 2 == 0)
                    demChan++;
            }

            MessageBox.Show("Số lượng các ước số chẵn: " + demChan, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            int demNguyenTo = 0;
            for (int i = 0; i < lstUocSo.Items.Count; i++)
            {
                int so = int.Parse(lstUocSo.Items[i].ToString());
                if (LaSoNguyenTo(so))
                    demNguyenTo++;
            }

            MessageBox.Show("Số lượng ước số nguyên tố: " + demNguyenTo, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnCapNhat;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
