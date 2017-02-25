namespace Lab_1.ui.image
{
    partial class Pixelate
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
            this.pixelSize = new System.Windows.Forms.NumericUpDown();
            this.pixelateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pixelSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pixelSize
            // 
            this.pixelSize.Location = new System.Drawing.Point(91, 9);
            this.pixelSize.Name = "pixelSize";
            this.pixelSize.Size = new System.Drawing.Size(120, 20);
            this.pixelSize.TabIndex = 0;
            // 
            // pixelateButton
            // 
            this.pixelateButton.Location = new System.Drawing.Point(12, 35);
            this.pixelateButton.Name = "pixelateButton";
            this.pixelateButton.Size = new System.Drawing.Size(199, 38);
            this.pixelateButton.TabIndex = 1;
            this.pixelateButton.Text = "Pixelate";
            this.pixelateButton.UseVisualStyleBackColor = true;
            this.pixelateButton.Click += new System.EventHandler(this.pixelateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pixel size";
            // 
            // Pixelate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 83);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pixelateButton);
            this.Controls.Add(this.pixelSize);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(241, 122);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(241, 122);
            this.Name = "Pixelate";
            this.Text = "Pixelate";
            this.Load += new System.EventHandler(this.Pixelate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pixelSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pixelSize;
        private System.Windows.Forms.Button pixelateButton;
        private System.Windows.Forms.Label label1;
    }
}