namespace ContactList
{
    partial class AddContactForm
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
            this.btnHoten = new System.Windows.Forms.TextBox();
            this.btnSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThongtinbosung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHoten
            // 
            this.btnHoten.Location = new System.Drawing.Point(177, 120);
            this.btnHoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoten.Name = "btnHoten";
            this.btnHoten.Size = new System.Drawing.Size(190, 22);
            this.btnHoten.TabIndex = 0;
            this.btnHoten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSDT
            // 
            this.btnSDT.Location = new System.Drawing.Point(177, 165);
            this.btnSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSDT.Name = "btnSDT";
            this.btnSDT.Size = new System.Drawing.Size(190, 22);
            this.btnSDT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SĐT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 289);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 56);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(177, 209);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thông tin bổ sung";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtThongtinbosung
            // 
            this.txtThongtinbosung.Location = new System.Drawing.Point(177, 252);
            this.txtThongtinbosung.Margin = new System.Windows.Forms.Padding(2);
            this.txtThongtinbosung.Name = "txtThongtinbosung";
            this.txtThongtinbosung.Size = new System.Drawing.Size(190, 22);
            this.txtThongtinbosung.TabIndex = 7;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThongtinbosung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSDT);
            this.Controls.Add(this.btnHoten);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btnHoten;
        private System.Windows.Forms.TextBox btnSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThongtinbosung;
    }
}