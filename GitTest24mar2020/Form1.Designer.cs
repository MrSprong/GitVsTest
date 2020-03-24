namespace GitTest24mar2020
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
            this.btnGoTspr = new System.Windows.Forms.Button();
            this.btnGoTwoTspr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoTspr
            // 
            this.btnGoTspr.Location = new System.Drawing.Point(236, 95);
            this.btnGoTspr.Name = "btnGoTspr";
            this.btnGoTspr.Size = new System.Drawing.Size(75, 23);
            this.btnGoTspr.TabIndex = 0;
            this.btnGoTspr.Text = "Ok";
            this.btnGoTspr.UseVisualStyleBackColor = true;
            this.btnGoTspr.Click += new System.EventHandler(this.btnGoTspr_Click);
            // 
            // btnGoTwoTspr
            // 
            this.btnGoTwoTspr.Location = new System.Drawing.Point(376, 95);
            this.btnGoTwoTspr.Name = "btnGoTwoTspr";
            this.btnGoTwoTspr.Size = new System.Drawing.Size(75, 23);
            this.btnGoTwoTspr.TabIndex = 1;
            this.btnGoTwoTspr.Text = "Ok2";
            this.btnGoTwoTspr.UseVisualStyleBackColor = true;
            this.btnGoTwoTspr.Click += new System.EventHandler(this.btnGoTwoTspr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoTwoTspr);
            this.Controls.Add(this.btnGoTspr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoTspr;
        private System.Windows.Forms.Button btnGoTwoTspr;
    }
}

