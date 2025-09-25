using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool LayDuLieuNhap(out double so1, out double so2)
        {
            bool hopLe1 = double.TryParse(txtSo1.Text.Trim(), out so1);
            bool hopLe2 = double.TryParse(txtSo2.Text.Trim(), out so2);

            if (!hopLe1 || !hopLe2)
            {
                MessageBox.Show("Vui lòng nhập đúng 2 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        private string LayPhepTinh()
        {
            if (radCong.Checked) return "+";
            if (radTru.Checked) return "-";
            if (radNhan.Checked) return "*";
            if (radChia.Checked) return "/";
            return null;
        }




        private double TinhKetQua(double so1, double so2, string phepTinh)
        {
            switch (phepTinh)
            {
                case "+": return so1 + so2;
                case "-": return so1 - so2;
                case "*": return so1 * so2;
                case "/":
                    if (so2 == 0)
                        throw new DivideByZeroException("Không thể chia cho 0.");
                    return so1 / so2;
                default:
                    throw new InvalidOperationException("Phép tính không hợp lệ.");
            }
        }



        private void HienThiKetQua(double ketQua)
        {
            txtKetQua.Text = ketQua.ToString();
        }

        // Xử lý khi click nút "Kết quả"
        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (!LayDuLieuNhap(out double so1, out double so2))
                return;

            string phepTinh = LayPhepTinh();
            if (phepTinh == null)
            {
                MessageBox.Show("Vui lòng chọn phép tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                double ketQua = TinhKetQua(so1, so2, phepTinh);
                HienThiKetQua(ketQua);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi chia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
