namespace bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.grbPhepTinh = new System.Windows.Forms.GroupBox();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.grbPhepTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(288, 111);
            this.txtSo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(696, 30);
            this.txtSo1.TabIndex = 2;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(288, 172);
            this.txtSo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(696, 30);
            this.txtSo2.TabIndex = 3;
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo2_TextChanged);
            // 
            // grbPhepTinh
            // 
            this.grbPhepTinh.Controls.Add(this.radCong);
            this.grbPhepTinh.Controls.Add(this.radTru);
            this.grbPhepTinh.Controls.Add(this.radChia);
            this.grbPhepTinh.Controls.Add(this.radNhan);
            this.grbPhepTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPhepTinh.Location = new System.Drawing.Point(152, 246);
            this.grbPhepTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbPhepTinh.Name = "grbPhepTinh";
            this.grbPhepTinh.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbPhepTinh.Size = new System.Drawing.Size(832, 144);
            this.grbPhepTinh.TabIndex = 4;
            this.grbPhepTinh.TabStop = false;
            this.grbPhepTinh.Text = "Phép tính";
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Location = new System.Drawing.Point(26, 59);
            this.radCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(112, 39);
            this.radCong.TabIndex = 0;
            this.radCong.TabStop = true;
            this.radCong.Text = "Cộng";
            this.radCong.UseVisualStyleBackColor = true;
            this.radCong.CheckedChanged += new System.EventHandler(this.radCong_CheckedChanged);
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Location = new System.Drawing.Point(216, 59);
            this.radTru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(94, 39);
            this.radTru.TabIndex = 5;
            this.radTru.TabStop = true;
            this.radTru.Text = "Trừ";
            this.radTru.UseVisualStyleBackColor = true;
            this.radTru.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Location = new System.Drawing.Point(422, 59);
            this.radNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(112, 39);
            this.radNhan.TabIndex = 6;
            this.radNhan.TabStop = true;
            this.radNhan.Text = "Nhân";
            this.radNhan.UseVisualStyleBackColor = true;
            this.radNhan.CheckedChanged += new System.EventHandler(this.radNhan_CheckedChanged);
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Location = new System.Drawing.Point(652, 59);
            this.radChia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(105, 39);
            this.radChia.TabIndex = 7;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            this.radChia.CheckedChanged += new System.EventHandler(this.radChia_CheckedChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(288, 447);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(696, 30);
            this.txtKetQua.TabIndex = 9;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(142, 439);
            this.btnKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(138, 45);
            this.btnKetQua.TabIndex = 10;
            this.btnKetQua.Text = "Kết quả:";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 647);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.grbPhepTinh);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Phép tính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPhepTinh.ResumeLayout(false);
            this.grbPhepTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox grbPhepTinh;
        private System.Windows.Forms.RadioButton radCong;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radNhan;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnKetQua;
    }
}

