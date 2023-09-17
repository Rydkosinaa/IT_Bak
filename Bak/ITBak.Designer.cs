namespace Bak
{
    partial class ITBak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITBak));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HighLevel = new System.Windows.Forms.Label();
            this.LowLevel = new System.Windows.Forms.Label();
            this.pumpe = new System.Windows.Forms.Label();
            this.BakVolume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HighLevel
            // 
            this.HighLevel.AutoSize = true;
            this.HighLevel.Location = new System.Drawing.Point(154, 171);
            this.HighLevel.Name = "HighLevel";
            this.HighLevel.Size = new System.Drawing.Size(0, 16);
            this.HighLevel.TabIndex = 1;
            // 
            // LowLevel
            // 
            this.LowLevel.AutoSize = true;
            this.LowLevel.Location = new System.Drawing.Point(154, 269);
            this.LowLevel.Name = "LowLevel";
            this.LowLevel.Size = new System.Drawing.Size(0, 16);
            this.LowLevel.TabIndex = 2;
            // 
            // pumpe
            // 
            this.pumpe.AutoSize = true;
            this.pumpe.Location = new System.Drawing.Point(688, 279);
            this.pumpe.Name = "pumpe";
            this.pumpe.Size = new System.Drawing.Size(0, 16);
            this.pumpe.TabIndex = 4;
            // 
            // BakVolume
            // 
            this.BakVolume.AutoSize = true;
            this.BakVolume.Location = new System.Drawing.Point(374, 342);
            this.BakVolume.Name = "BakVolume";
            this.BakVolume.Size = new System.Drawing.Size(0, 16);
            this.BakVolume.TabIndex = 5;
            // 
            // ITBak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BakVolume);
            this.Controls.Add(this.pumpe);
            this.Controls.Add(this.LowLevel);
            this.Controls.Add(this.HighLevel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ITBak";
            this.Text = "IT Bak";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HighLevel;
        private System.Windows.Forms.Label LowLevel;
        private System.Windows.Forms.Label pumpe;
        private System.Windows.Forms.Label BakVolume;
    }
}

