namespace Lab_1.ui.image
{
    partial class Flip
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
            this.verticalButton = new System.Windows.Forms.Button();
            this.horizontalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verticalButton
            // 
            this.verticalButton.Location = new System.Drawing.Point(12, 12);
            this.verticalButton.Name = "verticalButton";
            this.verticalButton.Size = new System.Drawing.Size(260, 40);
            this.verticalButton.TabIndex = 0;
            this.verticalButton.Text = "Vertical";
            this.verticalButton.UseVisualStyleBackColor = true;
            this.verticalButton.Click += new System.EventHandler(this.verticalButton_Click);
            // 
            // horizontalButton
            // 
            this.horizontalButton.Location = new System.Drawing.Point(12, 70);
            this.horizontalButton.Name = "horizontalButton";
            this.horizontalButton.Size = new System.Drawing.Size(260, 40);
            this.horizontalButton.TabIndex = 1;
            this.horizontalButton.Text = "Horizontal";
            this.horizontalButton.UseVisualStyleBackColor = true;
            this.horizontalButton.Click += new System.EventHandler(this.horizontalButton_Click);
            // 
            // Flip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.horizontalButton);
            this.Controls.Add(this.verticalButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Flip";
            this.Text = "Flip";
            this.Load += new System.EventHandler(this.Flip_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button verticalButton;
        private System.Windows.Forms.Button horizontalButton;
    }
}