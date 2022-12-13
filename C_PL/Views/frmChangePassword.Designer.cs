namespace C_PL.Views
{
    partial class frmChangePassword
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
            this.lb_layid = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mkcu = new System.Windows.Forms.TextBox();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.txt_nhaplaimkmoi = new System.Windows.Forms.TextBox();
            this.check_pass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_layid
            // 
            this.lb_layid.AutoSize = true;
            this.lb_layid.Location = new System.Drawing.Point(73, 72);
            this.lb_layid.Name = "lb_layid";
            this.lb_layid.Size = new System.Drawing.Size(50, 20);
            this.lb_layid.TabIndex = 0;
            this.lb_layid.Text = "label1";
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xacnhan.Location = new System.Drawing.Point(430, 394);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(153, 63);
            this.btn_xacnhan.TabIndex = 1;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_huy.Location = new System.Drawing.Point(102, 394);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(153, 63);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mật khẩu cũ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập mật khẩu mới :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu mới :";
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.Location = new System.Drawing.Point(306, 152);
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.Size = new System.Drawing.Size(277, 27);
            this.txt_mkcu.TabIndex = 6;
            this.txt_mkcu.UseSystemPasswordChar = true;
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Location = new System.Drawing.Point(306, 208);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.Size = new System.Drawing.Size(277, 27);
            this.txt_mkmoi.TabIndex = 7;
            this.txt_mkmoi.UseSystemPasswordChar = true;
            // 
            // txt_nhaplaimkmoi
            // 
            this.txt_nhaplaimkmoi.Location = new System.Drawing.Point(306, 274);
            this.txt_nhaplaimkmoi.Name = "txt_nhaplaimkmoi";
            this.txt_nhaplaimkmoi.Size = new System.Drawing.Size(277, 27);
            this.txt_nhaplaimkmoi.TabIndex = 8;
            this.txt_nhaplaimkmoi.UseSystemPasswordChar = true;
            // 
            // check_pass
            // 
            this.check_pass.AutoSize = true;
            this.check_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_pass.Location = new System.Drawing.Point(306, 317);
            this.check_pass.Name = "check_pass";
            this.check_pass.Size = new System.Drawing.Size(159, 26);
            this.check_pass.TabIndex = 9;
            this.check_pass.Text = "Show password";
            this.check_pass.UseVisualStyleBackColor = true;
            this.check_pass.CheckedChanged += new System.EventHandler(this.check_pass_CheckedChanged);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 617);
            this.Controls.Add(this.check_pass);
            this.Controls.Add(this.txt_nhaplaimkmoi);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.txt_mkcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.lb_layid);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_layid;
        private Button btn_xacnhan;
        private Button btn_huy;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_mkcu;
        private TextBox txt_mkmoi;
        private TextBox txt_nhaplaimkmoi;
        private CheckBox check_pass;
    }
}