namespace OnlineMarketPlaceMangmentSystem
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.numbers_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2020 By Error Team";
            // 
            // numbers_txt
            // 
            this.numbers_txt.AutoSize = true;
            this.numbers_txt.Font = new System.Drawing.Font("Tahoma", 25F);
            this.numbers_txt.Location = new System.Drawing.Point(443, 136);
            this.numbers_txt.Name = "numbers_txt";
            this.numbers_txt.Size = new System.Drawing.Size(46, 51);
            this.numbers_txt.TabIndex = 1;
            this.numbers_txt.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label3.Location = new System.Drawing.Point(142, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loading...";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numbers_txt);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "Loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numbers_txt;
        private System.Windows.Forms.Label label3;
    }
}

