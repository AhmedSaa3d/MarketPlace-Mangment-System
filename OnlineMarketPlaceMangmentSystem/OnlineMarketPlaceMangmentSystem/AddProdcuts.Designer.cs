namespace OnlineMarketPlaceMangmentSystem
{
    partial class AddProdcuts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProdcuts));
            this.add_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.category_combox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uploadphoto_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.id_combox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Tahoma", 13F);
            this.add_btn.Location = new System.Drawing.Point(34, 393);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(244, 43);
            this.add_btn.TabIndex = 47;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImageKey = "(none)";
            this.label6.Location = new System.Drawing.Point(29, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 56;
            this.label6.Text = "Category :";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.quantity_txt.Location = new System.Drawing.Point(175, 231);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(177, 32);
            this.quantity_txt.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImageKey = "(none)";
            this.label5.Location = new System.Drawing.Point(29, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 27);
            this.label5.TabIndex = 54;
            this.label5.Text = "Quantity :";
            // 
            // price_txt
            // 
            this.price_txt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.price_txt.Location = new System.Drawing.Point(175, 174);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(177, 32);
            this.price_txt.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(29, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 52;
            this.label2.Text = "Price :";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.name_txt.Location = new System.Drawing.Point(175, 117);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(177, 32);
            this.name_txt.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageKey = "(none)";
            this.label4.Location = new System.Drawing.Point(29, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 49;
            this.label4.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 48;
            this.label3.Text = "Name :";
            // 
            // category_combox
            // 
            this.category_combox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.category_combox.FormattingEnabled = true;
            this.category_combox.Location = new System.Drawing.Point(175, 293);
            this.category_combox.Name = "category_combox";
            this.category_combox.Size = new System.Drawing.Size(177, 32);
            this.category_combox.TabIndex = 58;
            this.category_combox.Text = "SelectCategory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // uploadphoto_btn
            // 
            this.uploadphoto_btn.Font = new System.Drawing.Font("Tahoma", 13F);
            this.uploadphoto_btn.Location = new System.Drawing.Point(403, 293);
            this.uploadphoto_btn.Name = "uploadphoto_btn";
            this.uploadphoto_btn.Size = new System.Drawing.Size(353, 43);
            this.uploadphoto_btn.TabIndex = 60;
            this.uploadphoto_btn.Text = "UploadPhoto";
            this.uploadphoto_btn.UseVisualStyleBackColor = true;
            this.uploadphoto_btn.Click += new System.EventHandler(this.uploadphoto_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 13F);
            this.delete_btn.Location = new System.Drawing.Point(549, 393);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(207, 43);
            this.delete_btn.TabIndex = 61;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Tahoma", 13F);
            this.update_btn.Location = new System.Drawing.Point(302, 393);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(224, 43);
            this.update_btn.TabIndex = 62;
            this.update_btn.Text = "update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // id_combox
            // 
            this.id_combox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.id_combox.FormattingEnabled = true;
            this.id_combox.Location = new System.Drawing.Point(175, 66);
            this.id_combox.Name = "id_combox";
            this.id_combox.Size = new System.Drawing.Size(177, 32);
            this.id_combox.TabIndex = 63;
            this.id_combox.Text = "SelectId";
            this.id_combox.SelectedIndexChanged += new System.EventHandler(this.id_combox_SelectedIndexChanged);
            // 
            // AddProdcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 443);
            this.Controls.Add(this.id_combox);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.uploadphoto_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.category_combox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_btn);
            this.Name = "AddProdcuts";
            this.Text = "AddProdcuts";
            this.Load += new System.EventHandler(this.AddProdcuts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category_combox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uploadphoto_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ComboBox id_combox;
    }
}