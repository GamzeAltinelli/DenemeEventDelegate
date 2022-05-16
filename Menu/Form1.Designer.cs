namespace Menu
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbxSiparis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Köfte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "Patates";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ayran";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 97);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ödeme Yap";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbxSiparis
            // 
            this.lbxSiparis.FormattingEnabled = true;
            this.lbxSiparis.ItemHeight = 16;
            this.lbxSiparis.Location = new System.Drawing.Point(233, 26);
            this.lbxSiparis.Name = "lbxSiparis";
            this.lbxSiparis.Size = new System.Drawing.Size(386, 356);
            this.lbxSiparis.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 465);
            this.Controls.Add(this.lbxSiparis);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbxSiparis;
    }
}

