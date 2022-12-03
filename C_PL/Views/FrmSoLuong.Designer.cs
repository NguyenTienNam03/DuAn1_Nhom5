namespace C_PL.Views
{
    partial class FrmSoLuong
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
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.txt_nhapsoluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_idsp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xacnhan.Location = new System.Drawing.Point(144, 126);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(99, 32);
            this.btn_xacnhan.TabIndex = 5;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // txt_nhapsoluong
            // 
            this.txt_nhapsoluong.Location = new System.Drawing.Point(29, 77);
            this.txt_nhapsoluong.Name = "txt_nhapsoluong";
            this.txt_nhapsoluong.Size = new System.Drawing.Size(377, 27);
            this.txt_nhapsoluong.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mời bạn nhập số lượng :";
            // 
            // lb_idsp
            // 
            this.lb_idsp.AutoSize = true;
            this.lb_idsp.Location = new System.Drawing.Point(27, 15);
            this.lb_idsp.Name = "lb_idsp";
            this.lb_idsp.Size = new System.Drawing.Size(50, 20);
            this.lb_idsp.TabIndex = 6;
            this.lb_idsp.Text = "label2";
            // 
            // FrmSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 187);
            this.Controls.Add(this.lb_idsp);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.txt_nhapsoluong);
            this.Controls.Add(this.label1);
            this.Name = "FrmSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSoLuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_xacnhan;
        private TextBox txt_nhapsoluong;
        private Label label1;
        private Label lb_idsp;
    }
}