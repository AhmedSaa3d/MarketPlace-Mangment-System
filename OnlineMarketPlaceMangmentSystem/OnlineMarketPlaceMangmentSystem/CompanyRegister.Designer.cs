namespace OnlineMarketPlaceMangmentSystem
{
    partial class CompanyRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyRegister));
            this.register_btn = new System.Windows.Forms.Button();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_txt = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showhide_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Tahoma", 13F);
            this.register_btn.Location = new System.Drawing.Point(37, 342);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(404, 43);
            this.register_btn.TabIndex = 39;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // phone_txt
            // 
            this.phone_txt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.phone_txt.Location = new System.Drawing.Point(178, 266);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(263, 32);
            this.phone_txt.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImageKey = "(none)";
            this.label6.Location = new System.Drawing.Point(32, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phone :";
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.password_txt.Location = new System.Drawing.Point(178, 207);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(263, 32);
            this.password_txt.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImageKey = "(none)";
            this.label5.Location = new System.Drawing.Point(32, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Password : ";
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.email_txt.Location = new System.Drawing.Point(178, 150);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(263, 32);
            this.email_txt.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(32, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "E_mail : ";
            // 
            // Id_txt
            // 
            this.Id_txt.AutoSize = true;
            this.Id_txt.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Id_txt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Id_txt.ImageKey = "(none)";
            this.Id_txt.Location = new System.Drawing.Point(266, 47);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(78, 27);
            this.Id_txt.TabIndex = 26;
            this.Id_txt.Text = "xxxxxx";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.name_txt.Location = new System.Drawing.Point(178, 93);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(263, 32);
            this.name_txt.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageKey = "(none)";
            this.label4.Location = new System.Drawing.Point(32, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name :";
            // 
            // showhide_checkbox
            // 
            this.showhide_checkbox.AutoSize = true;
            this.showhide_checkbox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.showhide_checkbox.Location = new System.Drawing.Point(459, 218);
            this.showhide_checkbox.Name = "showhide_checkbox";
            this.showhide_checkbox.Size = new System.Drawing.Size(18, 17);
            this.showhide_checkbox.TabIndex = 40;
            this.showhide_checkbox.UseVisualStyleBackColor = true;
            this.showhide_checkbox.CheckedChanged += new System.EventHandler(this.showhide_checkbox_CheckedChanged);
            // 
            // CompanyRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 399);
            this.Controls.Add(this.showhide_checkbox);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "CompanyRegister";
            this.Text = "CompanyRegister";
            this.Load += new System.EventHandler(this.CompanyRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showhide_checkbox;
    }
}