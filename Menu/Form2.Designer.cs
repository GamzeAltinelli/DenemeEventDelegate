namespace Menu
{
    partial class Form2
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
            this.lbxTumSiparis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxTumSiparis
            // 
            this.lbxTumSiparis.FormattingEnabled = true;
            this.lbxTumSiparis.ItemHeight = 16;
            this.lbxTumSiparis.Location = new System.Drawing.Point(30, 22);
            this.lbxTumSiparis.Name = "lbxTumSiparis";
            this.lbxTumSiparis.Size = new System.Drawing.Size(382, 404);
            this.lbxTumSiparis.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.lbxTumSiparis);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTumSiparis;
    }
}