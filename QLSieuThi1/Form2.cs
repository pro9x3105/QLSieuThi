using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;   

namespace QLSieuThi1
{
    public partial class Form2 : Form
    {
        ProcessDataBase connv1 = new ProcessDataBase();
        public Form2()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(Application.StartupPath + "\\CauHoi\\CauHoi.txt", FileMode.Open);
            //StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            txbCauHoi.Text = connv1.file1("CauHoi\\CauHoi").ReadToEnd();
            themComboBox();
            //button
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            //HienThi
            txbCauHoi.Visible = true;
            groupBoxCauLenh.Visible = false;
            //txbCauLenh.Visible = false;
            //txbTruyVan.Visible = false;
            groupBoxHienThi.Visible = false;
            //txbHienThi.Visible = false;
            //dgvHienThi.Visible = false;

        }

        private void themComboBox()
        {
            cbTruyVan.Items.Add("View");
            cbTruyVan.Items.Add("Procedure");
            cbTruyVan.Items.Add("Trigger");
            cbTruyVan.Items.Add("Function");
            cbTruyVan.Items.Add("DKDL");
        }

        
        private void cleartxb()
        {
            txbCauLenh.Text = "";
            txbHienThi.Text = "";
            dgvHienThi.DataSource = new DataTable();
        }

        private void CodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewProcFunc formViewProcFunc = new FormViewProcFunc();
            formViewProcFunc.Show();
        }

        private void QuayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbTruyVan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleartxb();
            if (cbTruyVan.SelectedItem.ToString() == "View")
            {
                //button
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                //Hienthi
                txbCauHoi.Visible = false;
                groupBoxCauLenh.Visible = true;
                txbCauLenh.Visible = true;
                txbTruyVan.Visible = true;
                groupBoxHienThi.Visible = true;
                txbHienThi.Visible = false;
                dgvHienThi.Visible = true;
            }
            if (cbTruyVan.SelectedItem.ToString() == "Procedure")
            {
                //button
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                //Hienthi
                txbCauHoi.Visible = false;
                groupBoxCauLenh.Visible = true;
                txbTruyVan.Visible = true;
                txbCauLenh.Visible = true;
                groupBoxHienThi.Visible = true;
                txbHienThi.Visible = true;
                dgvHienThi.Visible = false;
            }
            if (cbTruyVan.SelectedItem.ToString() == "Trigger")
            {
                //button
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                //Hienthi
                txbCauHoi.Visible = false;
                groupBoxCauLenh.Visible = true;
                txbTruyVan.Visible = true;
                txbCauLenh.Visible = true;
                groupBoxHienThi.Visible = true;
                txbHienThi.Visible = false;
                dgvHienThi.Visible = true;
            }
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                //button
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                //Hienthi
                txbCauHoi.Visible = false;
                groupBoxCauLenh.Visible = true;
                txbTruyVan.Visible = true;
                txbCauLenh.Visible = true;
                groupBoxHienThi.Visible = true;
                txbHienThi.Visible = false;
                dgvHienThi.Visible = true;
            }
            if (cbTruyVan.SelectedItem.ToString() == "DKDL")
            {
                //button
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                //Hienthi
                txbCauHoi.Visible = false;
                groupBoxCauLenh.Visible = true;
                txbTruyVan.Visible = true;
                txbCauLenh.Visible = true;
                groupBoxHienThi.Visible = false;
                txbHienThi.Visible = false;
                dgvHienThi.Visible = false;
            }
            
        }

        private void BtnCauHoi_Click(object sender, EventArgs e)
        {
            cbTruyVan.Text = "";
            //button
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            //Hienthi
            txbCauHoi.Visible = true;
            groupBoxCauLenh.Visible = false;
            txbTruyVan.Visible = false;
            //txbCauLenh.Visible = false;
            groupBoxHienThi.Visible = false;
            //txbHienThi.Visible = false;
            //dgvHienThi.Visible = false;

        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbTruyVan.Text = "View";
        }

        private void ProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbTruyVan.Text = "Procedure";
        }

        private void TriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbTruyVan.Text = "Trigger";
        }

        private void FunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbTruyVan.Text = "Function";
        }

        private void DKDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbTruyVan.Text = "DKDL";
        }

        private void CâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnCauHoi_Click(null, null);
        }
        private void TxbTruyVan_TextChanged(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = new DataTable();
            try
            {
                dgvHienThi.DataSource = connv1.DocBang(txbTruyVan.Text);
            }
            catch
            {
                ;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cbTruyVan.SelectedItem.ToString() == "View")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh1.1").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh1.1").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Procedure")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh2.1").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh2.1").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Trigger")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh3.1").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh3.1").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh4.1").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh4.1").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "DKDL")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh5.1").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh5.1").ReadToEnd();
            }
        }
            
        private void Button2_Click(object sender, EventArgs e)
        {
            if (cbTruyVan.SelectedItem.ToString() == "View")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh1.2").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh1.2").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Procedure")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh2.2").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh2.2").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Trigger")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh3.2").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh3.2").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh4.2").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh4.2").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "DKDL")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh5.2").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh5.2").ReadToEnd();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (cbTruyVan.SelectedItem.ToString() == "View")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh1.3").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh1.3").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Procedure")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh2.3").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh2.3").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Trigger")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh3.3").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh3.3").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh4.3").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh4.3").ReadToEnd();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (cbTruyVan.SelectedItem.ToString() == "View")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh1.4").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh1.4").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Procedure")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh2.4").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh2.4").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Trigger")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh3.4").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh3.4").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh4.4").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh4.4").ReadToEnd();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (cbTruyVan.SelectedItem.ToString() == "View")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh1.5").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh1.5").ReadToEnd();
            }
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh4.5").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh4.5").ReadToEnd();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh4.6").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh4.6").ReadToEnd();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh4.7").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh4.7").ReadToEnd();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (cbTruyVan.SelectedItem.ToString() == "Function")
            {
                txbCauLenh.Text = connv1.file1("CauLenh\\CauLenh4.8").ReadToEnd();
                txbTruyVan.Text = connv1.file1("TruyVan\\CauLenh4.8").ReadToEnd();
            }
        }

    }
}
