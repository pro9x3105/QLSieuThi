using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThi1
{
    public partial class Form1 : Form
    {
        ProcessDataBase connv1 = new ProcessDataBase();
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Chào mừng";
            themComboBox();
        }
        private void themComboBox()
        {
            cbHienThi.Items.Add("Nhân Viên");
            cbHienThi.Items.Add("Hóa Đơn");
            cbHienThi.Items.Add("Phiếu Nhập");
            cbHienThi.Items.Add("Phiếu Kiểm Kê");
            cbHienThi.Items.Add("Khách Hàng");
            cbHienThi.Items.Add("Sản Phẩm");
        }
        
        private void CbHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbHienThi.SelectedItem.ToString()=="Nhân Viên")
            {
                groupbox1.Text = "Bảng nhân viên";
                dt = connv1.DocBang("SELECT * FROM NHANVIEN inner join CHUCVU on NHANVIEN.MaCV=CHUCVU.MaCV");
                dgvHienThi.DataSource = dt;
            }
            if (cbHienThi.SelectedItem.ToString() == "Hóa Đơn")
            {
                groupbox1.Text = "Bảng hóa đơn";
                dt = connv1.DocBang("SELECT * FROM HOADON inner join SP_B on HOADON.MaHD=SP_B.MaHD inner join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH");
                dgvHienThi.DataSource = dt;
            }
            if (cbHienThi.SelectedItem.ToString() == "Phiếu Nhập")
            {
                groupbox1.Text = "Bảng phiếu nhập";
                dt = connv1.DocBang("SELECT * FROM PHIEUNHAP inner join SP_N on PHIEUNHAP.MaPN=SP_N.MaPN inner join NCC on PHIEUNHAP.MaNCC=NCC.MaNCC");
                dgvHienThi.DataSource = dt;
            }
            if (cbHienThi.SelectedItem.ToString() == "Phiếu Kiểm Kê")
            {
                groupbox1.Text = "Bảng kiểm kê";
                dt = connv1.DocBang("SELECT * FROM PHIEUKIEMKE inner join CT_PKK on PHIEUKIEMKE.MaPKK=CT_PKK.MaPKK");
                dgvHienThi.DataSource = dt;
            }
            if (cbHienThi.SelectedItem.ToString() == "Khách Hàng")
            {
                groupbox1.Text = "Bảng khách hàng";
                dt = connv1.DocBang("SELECT * FROM KHACHHANG inner join HOADON on KHACHHANG.MaKH=HOADON.MaKH inner join SP_B on HOADON.MaHD=SP_B.MaHD");
                dgvHienThi.DataSource = dt;
            }
            if (cbHienThi.SelectedItem.ToString() == "Sản Phẩm")
            {
                groupbox1.Text = "Bảng sản phẩm";
                dt = connv1.DocBang("SELECT * FROM SANPHAM");
                dgvHienThi.DataSource = dt;
            }
        }

        

        private void NhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbHienThi.Text = "Nhân Viên";
        }

        private void HóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbHienThi.Text = "Hóa Đơn";
        }

        private void PhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbHienThi.Text = "Phiếu Nhập";
        }

        private void PhiếuKiểmKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbHienThi.Text = "Phiếu Kiểm Kê";
        }

        private void KháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbHienThi.Text = "Khách Hàng";
        }

        private void SảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbHienThi.Text = "Sản Phẩm";
        }

        private void ThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By :\n- Nguyễn Quang Anh : Làm CSDL và form\n- Trần Trọng Đức : Câu hỏi và câu lệnh\n- Vũ Trung Kiên : Báo cáo và chuẩn hóa dữ liệu");
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CodeTruyVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewProcFunc formViewProcFunc = new FormViewProcFunc();
            formViewProcFunc.Show();
        }

        private void CâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnCauHoi_Click(null, null);
        }

        private void BtnCauHoi_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
