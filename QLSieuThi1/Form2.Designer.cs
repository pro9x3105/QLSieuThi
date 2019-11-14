namespace QLSieuThi1
{
    partial class Form2
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
            this.groupBoxCauHoi = new System.Windows.Forms.GroupBox();
            this.groupBoxHienThi = new System.Windows.Forms.GroupBox();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.txbHienThi = new System.Windows.Forms.RichTextBox();
            this.groupBoxCauLenh = new System.Windows.Forms.GroupBox();
            this.txbTruyVan = new System.Windows.Forms.RichTextBox();
            this.txbCauLenh = new System.Windows.Forms.RichTextBox();
            this.txbCauHoi = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.câuLệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dKDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCauHoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbTruyVan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBoxCauHoi.SuspendLayout();
            this.groupBoxHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.groupBoxCauLenh.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCauHoi
            // 
            this.groupBoxCauHoi.Controls.Add(this.groupBoxHienThi);
            this.groupBoxCauHoi.Controls.Add(this.groupBoxCauLenh);
            this.groupBoxCauHoi.Controls.Add(this.txbCauHoi);
            this.groupBoxCauHoi.Location = new System.Drawing.Point(223, 31);
            this.groupBoxCauHoi.Name = "groupBoxCauHoi";
            this.groupBoxCauHoi.Size = new System.Drawing.Size(749, 518);
            this.groupBoxCauHoi.TabIndex = 0;
            this.groupBoxCauHoi.TabStop = false;
            this.groupBoxCauHoi.Text = "Bảng hiển thị";
            // 
            // groupBoxHienThi
            // 
            this.groupBoxHienThi.Controls.Add(this.dgvHienThi);
            this.groupBoxHienThi.Controls.Add(this.txbHienThi);
            this.groupBoxHienThi.Location = new System.Drawing.Point(11, 252);
            this.groupBoxHienThi.Name = "groupBoxHienThi";
            this.groupBoxHienThi.Size = new System.Drawing.Size(732, 260);
            this.groupBoxHienThi.TabIndex = 2;
            this.groupBoxHienThi.TabStop = false;
            this.groupBoxHienThi.Text = "Hiển thị bảng";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(3, 16);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(723, 238);
            this.dgvHienThi.TabIndex = 0;
            // 
            // txbHienThi
            // 
            this.txbHienThi.Location = new System.Drawing.Point(3, 16);
            this.txbHienThi.Name = "txbHienThi";
            this.txbHienThi.Size = new System.Drawing.Size(723, 238);
            this.txbHienThi.TabIndex = 1;
            this.txbHienThi.Text = "";
            // 
            // groupBoxCauLenh
            // 
            this.groupBoxCauLenh.Controls.Add(this.txbTruyVan);
            this.groupBoxCauLenh.Controls.Add(this.txbCauLenh);
            this.groupBoxCauLenh.Location = new System.Drawing.Point(11, 24);
            this.groupBoxCauLenh.Name = "groupBoxCauLenh";
            this.groupBoxCauLenh.Size = new System.Drawing.Size(732, 222);
            this.groupBoxCauLenh.TabIndex = 1;
            this.groupBoxCauLenh.TabStop = false;
            this.groupBoxCauLenh.Text = "Câu hỏi";
            // 
            // txbTruyVan
            // 
            this.txbTruyVan.Location = new System.Drawing.Point(509, 19);
            this.txbTruyVan.Name = "txbTruyVan";
            this.txbTruyVan.Size = new System.Drawing.Size(217, 194);
            this.txbTruyVan.TabIndex = 1;
            this.txbTruyVan.Text = "";
            this.txbTruyVan.TextChanged += new System.EventHandler(this.TxbTruyVan_TextChanged);
            // 
            // txbCauLenh
            // 
            this.txbCauLenh.Location = new System.Drawing.Point(3, 19);
            this.txbCauLenh.Name = "txbCauLenh";
            this.txbCauLenh.Size = new System.Drawing.Size(500, 194);
            this.txbCauLenh.TabIndex = 0;
            this.txbCauLenh.Text = "";
            // 
            // txbCauHoi
            // 
            this.txbCauHoi.Location = new System.Drawing.Point(3, 16);
            this.txbCauHoi.Name = "txbCauHoi";
            this.txbCauHoi.Size = new System.Drawing.Size(740, 496);
            this.txbCauHoi.TabIndex = 0;
            this.txbCauHoi.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.câuLệnhToolStripMenuItem,
            this.câuHỏiToolStripMenuItem,
            this.codeToolStripMenuItem,
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // câuLệnhToolStripMenuItem
            // 
            this.câuLệnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.procedureToolStripMenuItem,
            this.triggerToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.dKDLToolStripMenuItem});
            this.câuLệnhToolStripMenuItem.Name = "câuLệnhToolStripMenuItem";
            this.câuLệnhToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.câuLệnhToolStripMenuItem.Text = "Truy vấn";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // procedureToolStripMenuItem
            // 
            this.procedureToolStripMenuItem.Name = "procedureToolStripMenuItem";
            this.procedureToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.procedureToolStripMenuItem.Text = "Procedure";
            this.procedureToolStripMenuItem.Click += new System.EventHandler(this.ProcedureToolStripMenuItem_Click);
            // 
            // triggerToolStripMenuItem
            // 
            this.triggerToolStripMenuItem.Name = "triggerToolStripMenuItem";
            this.triggerToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.triggerToolStripMenuItem.Text = "Trigger";
            this.triggerToolStripMenuItem.Click += new System.EventHandler(this.TriggerToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.functionToolStripMenuItem.Text = "Function";
            this.functionToolStripMenuItem.Click += new System.EventHandler(this.FunctionToolStripMenuItem_Click);
            // 
            // dKDLToolStripMenuItem
            // 
            this.dKDLToolStripMenuItem.Name = "dKDLToolStripMenuItem";
            this.dKDLToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dKDLToolStripMenuItem.Text = "DKDL";
            this.dKDLToolStripMenuItem.Click += new System.EventHandler(this.DKDLToolStripMenuItem_Click);
            // 
            // câuHỏiToolStripMenuItem
            // 
            this.câuHỏiToolStripMenuItem.Name = "câuHỏiToolStripMenuItem";
            this.câuHỏiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.câuHỏiToolStripMenuItem.Text = "Câu hỏi";
            this.câuHỏiToolStripMenuItem.Click += new System.EventHandler(this.CâuHỏiToolStripMenuItem_Click);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.codeToolStripMenuItem.Text = "Code truy vấn";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.CodeToolStripMenuItem_Click);
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quayLạiToolStripMenuItem.Text = "Quay lại";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.QuayLạiToolStripMenuItem_Click);
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.Location = new System.Drawing.Point(12, 50);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(205, 23);
            this.btnCauHoi.TabIndex = 2;
            this.btnCauHoi.Text = "Câu hỏi";
            this.btnCauHoi.UseVisualStyleBackColor = true;
            this.btnCauHoi.Click += new System.EventHandler(this.BtnCauHoi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Câu hỏi 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Câu hỏi 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Câu hỏi 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // cbTruyVan
            // 
            this.cbTruyVan.FormattingEnabled = true;
            this.cbTruyVan.Location = new System.Drawing.Point(67, 79);
            this.cbTruyVan.Name = "cbTruyVan";
            this.cbTruyVan.Size = new System.Drawing.Size(150, 21);
            this.cbTruyVan.TabIndex = 6;
            this.cbTruyVan.SelectedIndexChanged += new System.EventHandler(this.CbTruyVan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Truy vấn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Câu hỏi 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Câu hỏi 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 254);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Câu hỏi 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 283);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Câu hỏi 7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 312);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Câu hỏi 8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTruyVan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCauHoi);
            this.Controls.Add(this.groupBoxCauHoi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxCauHoi.ResumeLayout(false);
            this.groupBoxHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.groupBoxCauLenh.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCauHoi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox txbCauHoi;
        private System.Windows.Forms.Button btnCauHoi;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxHienThi;
        private System.Windows.Forms.RichTextBox txbHienThi;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.GroupBox groupBoxCauLenh;
        private System.Windows.Forms.RichTextBox txbCauLenh;
        private System.Windows.Forms.ToolStripMenuItem câuLệnhToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbTruyVan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dKDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câuHỏiToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txbTruyVan;
    }
}