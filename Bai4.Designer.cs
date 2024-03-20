namespace LAB1._1
{
    partial class Bai4
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
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cbbTenphim = new System.Windows.Forms.ComboBox();
            this.cbbLoaive = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbPhongphim = new System.Windows.Forms.ComboBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phim";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(265, 98);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(220, 31);
            this.txtHoten.TabIndex = 2;
            // 
            // cbbTenphim
            // 
            this.cbbTenphim.FormattingEnabled = true;
            this.cbbTenphim.Location = new System.Drawing.Point(265, 163);
            this.cbbTenphim.Name = "cbbTenphim";
            this.cbbTenphim.Size = new System.Drawing.Size(220, 33);
            this.cbbTenphim.TabIndex = 3;
            // 
            // cbbLoaive
            // 
            this.cbbLoaive.FormattingEnabled = true;
            this.cbbLoaive.Location = new System.Drawing.Point(265, 245);
            this.cbbLoaive.Name = "cbbLoaive";
            this.cbbLoaive.Size = new System.Drawing.Size(220, 33);
            this.cbbLoaive.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại vé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phòng phim";
            // 
            // cbbPhongphim
            // 
            this.cbbPhongphim.FormattingEnabled = true;
            this.cbbPhongphim.Location = new System.Drawing.Point(265, 340);
            this.cbbPhongphim.Name = "cbbPhongphim";
            this.cbbPhongphim.Size = new System.Drawing.Size(220, 33);
            this.cbbPhongphim.TabIndex = 7;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(114, 459);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "Tính tiền";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 880);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.cbbPhongphim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbLoaive);
            this.Controls.Add(this.cbbTenphim);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cbbTenphim;
        private System.Windows.Forms.ComboBox cbbLoaive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbPhongphim;
        private System.Windows.Forms.Button btnTinh;
    }
}