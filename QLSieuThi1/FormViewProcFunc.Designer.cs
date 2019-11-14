namespace QLSieuThi1
{
    partial class FormViewProcFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txbKiemTra = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbListDB = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txb2 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbOutPut4 = new System.Windows.Forms.TextBox();
            this.txbValue4 = new System.Windows.Forms.TextBox();
            this.txbDeclare4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbOutPut3 = new System.Windows.Forms.TextBox();
            this.txbValue3 = new System.Windows.Forms.TextBox();
            this.txbDeclare3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheckProc = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txbKetQua = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbOutPut2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbOutPut1 = new System.Windows.Forms.TextBox();
            this.txbValue2 = new System.Windows.Forms.TextBox();
            this.txbDeclare2 = new System.Windows.Forms.TextBox();
            this.txbValue1 = new System.Windows.Forms.TextBox();
            this.txbDeclare1 = new System.Windows.Forms.TextBox();
            this.txbProcName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(6, 19);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(266, 100);
            this.txb1.TabIndex = 0;
            this.txb1.Text = "";
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.txb1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Truy Vấn View , Function";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txbKiemTra);
            this.groupBox7.Location = new System.Drawing.Point(6, 125);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(266, 97);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kiểm Tra";
            // 
            // txbKiemTra
            // 
            this.txbKiemTra.Location = new System.Drawing.Point(3, 15);
            this.txbKiemTra.Name = "txbKiemTra";
            this.txbKiemTra.ReadOnly = true;
            this.txbKiemTra.Size = new System.Drawing.Size(257, 76);
            this.txbKiemTra.TabIndex = 0;
            this.txbKiemTra.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbListDB);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txb2);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create SQL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Database";
            // 
            // cbListDB
            // 
            this.cbListDB.FormattingEnabled = true;
            this.cbListDB.Location = new System.Drawing.Point(65, 201);
            this.cbListDB.Name = "cbListDB";
            this.cbListDB.Size = new System.Drawing.Size(121, 21);
            this.cbListDB.TabIndex = 2;
            this.cbListDB.SelectedIndexChanged += new System.EventHandler(this.cbListDB_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(197, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Execute";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(6, 19);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(266, 174);
            this.txb2.TabIndex = 0;
            this.txb2.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHienThi);
            this.groupBox3.Location = new System.Drawing.Point(296, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 232);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị bảng";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(3, 16);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(553, 206);
            this.dgvHienThi.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txbOutPut4);
            this.groupBox5.Controls.Add(this.txbValue4);
            this.groupBox5.Controls.Add(this.txbDeclare4);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txbOutPut3);
            this.groupBox5.Controls.Add(this.txbValue3);
            this.groupBox5.Controls.Add(this.txbDeclare3);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btnCheckProc);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txbOutPut2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txbOutPut1);
            this.groupBox5.Controls.Add(this.txbValue2);
            this.groupBox5.Controls.Add(this.txbDeclare2);
            this.groupBox5.Controls.Add(this.txbValue1);
            this.groupBox5.Controls.Add(this.txbDeclare1);
            this.groupBox5.Controls.Add(this.txbProcName);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(299, 250);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(559, 199);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Procedure";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "INPUT4 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "OUTPUT4 :";
            // 
            // txbOutPut4
            // 
            this.txbOutPut4.Location = new System.Drawing.Point(467, 110);
            this.txbOutPut4.Name = "txbOutPut4";
            this.txbOutPut4.Size = new System.Drawing.Size(80, 20);
            this.txbOutPut4.TabIndex = 26;
            // 
            // txbValue4
            // 
            this.txbValue4.Location = new System.Drawing.Point(280, 110);
            this.txbValue4.Name = "txbValue4";
            this.txbValue4.Size = new System.Drawing.Size(80, 20);
            this.txbValue4.TabIndex = 25;
            // 
            // txbDeclare4
            // 
            this.txbDeclare4.Location = new System.Drawing.Point(188, 110);
            this.txbDeclare4.Name = "txbDeclare4";
            this.txbDeclare4.Size = new System.Drawing.Size(80, 20);
            this.txbDeclare4.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "INPUT3 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "OUTPUT3 :";
            // 
            // txbOutPut3
            // 
            this.txbOutPut3.Location = new System.Drawing.Point(467, 84);
            this.txbOutPut3.Name = "txbOutPut3";
            this.txbOutPut3.Size = new System.Drawing.Size(80, 20);
            this.txbOutPut3.TabIndex = 21;
            // 
            // txbValue3
            // 
            this.txbValue3.Location = new System.Drawing.Point(280, 84);
            this.txbValue3.Name = "txbValue3";
            this.txbValue3.Size = new System.Drawing.Size(80, 20);
            this.txbValue3.TabIndex = 20;
            // 
            // txbDeclare3
            // 
            this.txbDeclare3.Location = new System.Drawing.Point(188, 84);
            this.txbDeclare3.Name = "txbDeclare3";
            this.txbDeclare3.Size = new System.Drawing.Size(80, 20);
            this.txbDeclare3.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "INPUT2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "INPUT1 :";
            // 
            // btnCheckProc
            // 
            this.btnCheckProc.Location = new System.Drawing.Point(467, 146);
            this.btnCheckProc.Name = "btnCheckProc";
            this.btnCheckProc.Size = new System.Drawing.Size(80, 23);
            this.btnCheckProc.TabIndex = 7;
            this.btnCheckProc.Text = "Check Proc";
            this.btnCheckProc.UseVisualStyleBackColor = true;
            this.btnCheckProc.Click += new System.EventHandler(this.BtnCheckProc_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txbKetQua);
            this.groupBox6.Location = new System.Drawing.Point(6, 136);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(455, 57);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hiển thị";
            // 
            // txbKetQua
            // 
            this.txbKetQua.Location = new System.Drawing.Point(6, 12);
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.Size = new System.Drawing.Size(443, 45);
            this.txbKetQua.TabIndex = 0;
            this.txbKetQua.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "OUTPUT2 :";
            // 
            // txbOutPut2
            // 
            this.txbOutPut2.Location = new System.Drawing.Point(467, 58);
            this.txbOutPut2.Name = "txbOutPut2";
            this.txbOutPut2.Size = new System.Drawing.Size(80, 20);
            this.txbOutPut2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "OUTPUT1 :";
            // 
            // txbOutPut1
            // 
            this.txbOutPut1.Location = new System.Drawing.Point(467, 32);
            this.txbOutPut1.Name = "txbOutPut1";
            this.txbOutPut1.Size = new System.Drawing.Size(80, 20);
            this.txbOutPut1.TabIndex = 10;
            // 
            // txbValue2
            // 
            this.txbValue2.Location = new System.Drawing.Point(280, 58);
            this.txbValue2.Name = "txbValue2";
            this.txbValue2.Size = new System.Drawing.Size(80, 20);
            this.txbValue2.TabIndex = 9;
            // 
            // txbDeclare2
            // 
            this.txbDeclare2.Location = new System.Drawing.Point(188, 58);
            this.txbDeclare2.Name = "txbDeclare2";
            this.txbDeclare2.Size = new System.Drawing.Size(80, 20);
            this.txbDeclare2.TabIndex = 8;
            // 
            // txbValue1
            // 
            this.txbValue1.Location = new System.Drawing.Point(280, 32);
            this.txbValue1.Name = "txbValue1";
            this.txbValue1.Size = new System.Drawing.Size(80, 20);
            this.txbValue1.TabIndex = 6;
            // 
            // txbDeclare1
            // 
            this.txbDeclare1.Location = new System.Drawing.Point(188, 32);
            this.txbDeclare1.Name = "txbDeclare1";
            this.txbDeclare1.Size = new System.Drawing.Size(80, 20);
            this.txbDeclare1.TabIndex = 5;
            // 
            // txbProcName
            // 
            this.txbProcName.Location = new System.Drawing.Point(6, 32);
            this.txbProcName.Name = "txbProcName";
            this.txbProcName.Size = new System.Drawing.Size(95, 20);
            this.txbProcName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Declare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proc Name";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(580, 449);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(278, 23);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(296, 449);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(278, 23);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.BtnLamLai_Click);
            // 
            // FormViewProcFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 476);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormViewProcFunc";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormViewProcFunc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txb2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txbValue1;
        private System.Windows.Forms.TextBox txbDeclare1;
        private System.Windows.Forms.TextBox txbProcName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbOutPut1;
        private System.Windows.Forms.TextBox txbValue2;
        private System.Windows.Forms.TextBox txbDeclare2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCheckProc;
        private System.Windows.Forms.RichTextBox txbKetQua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbOutPut2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbListDB;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox txbKiemTra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbOutPut4;
        private System.Windows.Forms.TextBox txbValue4;
        private System.Windows.Forms.TextBox txbDeclare4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbOutPut3;
        private System.Windows.Forms.TextBox txbValue3;
        private System.Windows.Forms.TextBox txbDeclare3;
    }
}