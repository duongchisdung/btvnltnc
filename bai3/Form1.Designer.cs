namespace bai3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSo);
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // cboSo
            // 
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(15, 117);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(259, 24);
            this.cboSo.TabIndex = 2;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(15, 52);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(138, 22);
            this.txtSo.TabIndex = 0;
            this.txtSo.TextChanged += new System.EventHandler(this.txtSo_TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCapNhat.Location = new System.Drawing.Point(179, 42);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 43);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTong.Location = new System.Drawing.Point(360, 225);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(325, 56);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tổng các ước số";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnChan
            // 
            this.btnChan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnChan.Location = new System.Drawing.Point(360, 299);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(325, 59);
            this.btnChan.TabIndex = 3;
            this.btnChan.Text = "Số lượng các ước số chẵn";
            this.btnChan.UseVisualStyleBackColor = false;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnNguyenTo
            // 
            this.btnNguyenTo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNguyenTo.Location = new System.Drawing.Point(360, 364);
            this.btnNguyenTo.Name = "btnNguyenTo";
            this.btnNguyenTo.Size = new System.Drawing.Size(325, 59);
            this.btnNguyenTo.TabIndex = 4;
            this.btnNguyenTo.Text = "Số lượng các ước số nguyên tổ";
            this.btnNguyenTo.UseVisualStyleBackColor = false;
            this.btnNguyenTo.Click += new System.EventHandler(this.btnNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThoat.Location = new System.Drawing.Point(203, 364);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 59);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstUocSo
            // 
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 16;
            this.lstUocSo.Location = new System.Drawing.Point(61, 34);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(217, 116);
            this.lstUocSo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstUocSo);
            this.groupBox2.Location = new System.Drawing.Point(360, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Các Ước Số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNguyenTo);
            this.Controls.Add(this.btnChan);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Combobox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnNguyenTo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

