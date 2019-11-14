using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSieuThi1
{
    public partial class FormViewProcFunc : Form
    {
        ProcessDataBase connv1 = new ProcessDataBase();
        public FormViewProcFunc()
        {
            InitializeComponent();
        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = new DataTable();
            try
            {
                dgvHienThi.DataSource = connv1.DocBang(txb1.Text);
            }
            catch (Exception check)
            {
                txbKiemTra.Text="Lỗi : \n"+check.Message;
            }
            if (dgvHienThi.Rows.Count > 1)
            {
                txbKiemTra.Text = "Thành công";
            }
            
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                connv1.CapNhapDuLieu(txb2.Text);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception k)
            {
                MessageBox.Show("Lỗi :\n" + k.Message);
            }
        }

        
        private void BtnCheckProc_Click(object sender, EventArgs e)
        {
            if (txbProcName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên thủ tục / Procdure Name");
            }
            else
            {
                try
                {
                    // B1.Tạo đối tượng Connection
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-CTJL81R;Initial Catalog="+cbListDB.SelectedItem.ToString()+";User ID=sa;Password=31051999";
                    conn.Open(); // mở kết nối  
                                 //B2. Tạo đối tượng Command
                    SqlCommand cmd = new SqlCommand();
                    //Thiết lập các thuộc tính cho đối tượng Command
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = txbProcName.Text;
                    cmd.Parameters.Clear();
                    //B3. Gắn các Parameter và giá trị cho đối tượng Command
                    if(txbDeclare1.Text!="" && txbValue1.Text != "")
                    {
                        cmd.Parameters.Add(new SqlParameter(txbDeclare1.Text, txbValue1.Text));
                    }
                    if(txbDeclare2.Text != "" && txbValue2.Text != "")
                    {
                        cmd.Parameters.Add(new SqlParameter(txbDeclare2.Text, txbValue2.Text));
                    }
                    if (txbDeclare3.Text != "" && txbValue3.Text != "")
                    {
                        cmd.Parameters.Add(new SqlParameter(txbDeclare2.Text, txbValue2.Text));
                    }
                    if (txbDeclare4.Text != "" && txbValue4.Text != "")
                    {
                        cmd.Parameters.Add(new SqlParameter(txbDeclare2.Text, txbValue2.Text));
                    }
                    if (txbOutPut1.Text != "")
                    {
                        SqlParameter ketqua1 = new SqlParameter();
                        ketqua1.ParameterName = txbOutPut1.Text;
                        ketqua1.DbType = DbType.Int32;
                        ketqua1.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(ketqua1);
                    }
                    if (txbOutPut2.Text != "")
                    {
                        SqlParameter ketqua2 = new SqlParameter();
                        ketqua2.ParameterName = txbOutPut2.Text;
                        ketqua2.DbType = DbType.Int32;
                        ketqua2.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(ketqua2);
                    }
                    if (txbOutPut3.Text != "")
                    {
                        SqlParameter ketqua3 = new SqlParameter();
                        ketqua3.ParameterName = txbOutPut3.Text;
                        ketqua3.DbType = DbType.Int32;
                        ketqua3.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(ketqua3);
                    }
                    if (txbOutPut4.Text != "")
                    {
                        SqlParameter ketqua4 = new SqlParameter();
                        ketqua4.ParameterName = txbOutPut4.Text;
                        ketqua4.DbType = DbType.Int32;
                        ketqua4.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(ketqua4);
                    }
                    cmd.ExecuteNonQuery();
                    string ketquachung = "";
                    if(txbOutPut1.Text != "")
                    {
                        ketquachung += "print " + txbOutPut1.Text + " : " + cmd.Parameters[txbOutPut1.Text].Value.ToString() + "\n";
                    }
                    if (txbOutPut2.Text != "")
                    {
                        ketquachung += "print " + txbOutPut2.Text + " : " + cmd.Parameters[txbOutPut2.Text].Value.ToString() + "\n";
                    }
                    if (txbOutPut3.Text != "")
                    {
                        ketquachung += "print " + txbOutPut3.Text + " : " + cmd.Parameters[txbOutPut3.Text].Value.ToString() + "\n";
                    }
                    if (txbOutPut4.Text != "")
                    {
                        ketquachung += "print " + txbOutPut4.Text + " : " + cmd.Parameters[txbOutPut4.Text].Value.ToString() + "\n";
                    }
                    txbKetQua.Text = ketquachung;
                }
                catch (Exception k)
                {
                    MessageBox.Show("Lỗi nhập proc : \n" + k.Message);
                }
            }
        }


        private void cbListDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessDataBase.sql = "Data Source=DESKTOP-CTJL81R;Initial Catalog="+cbListDB.SelectedItem.ToString()+";User ID=sa;Password=31051999";
        }

        private void FormViewProcFunc_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-CTJL81R;User ID=sa;Password=31051999";
                conn.Open(); // mở kết nối  
                SqlCommand cmd = new SqlCommand("Select name from sys.databases", conn);
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbListDB.Items.Add(dr[0].ToString());
                }
            }
            finally
            {
                cbListDB.Text = cbListDB.Items[cbListDB.Items.Count - 1].ToString();
            }
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            txb1.Clear();
            txb2.Clear();
            txbKiemTra.Clear();
            txbDeclare1.Clear();
            txbDeclare2.Clear();
            txbOutPut1.Clear();
            txbOutPut2.Clear();
            txbValue1.Clear();
            txbValue2.Clear();
            txbProcName.Clear();
            txbKetQua.Clear();
            dgvHienThi.DataSource = new DataTable();
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
