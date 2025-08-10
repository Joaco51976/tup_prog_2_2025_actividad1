namespace Actividad1
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btnPruebaClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(29, 26);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(451, 396);
            this.tb1.TabIndex = 0;
            // 
            // btnPruebaClick
            // 
            this.btnPruebaClick.Location = new System.Drawing.Point(586, 168);
            this.btnPruebaClick.Name = "btnPruebaClick";
            this.btnPruebaClick.Size = new System.Drawing.Size(75, 23);
            this.btnPruebaClick.TabIndex = 1;
            this.btnPruebaClick.Text = "Instanci";
            this.btnPruebaClick.UseVisualStyleBackColor = true;
            this.btnPruebaClick.Click += new System.EventHandler(this.btnPruebaClick_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPruebaClick);
            this.Controls.Add(this.tb1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btnPruebaClick;
    }
}