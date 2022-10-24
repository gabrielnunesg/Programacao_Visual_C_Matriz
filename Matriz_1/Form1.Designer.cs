namespace Matriz_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMatriz = new System.Windows.Forms.ListBox();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMatriz
            // 
            this.lstMatriz.FormattingEnabled = true;
            this.lstMatriz.ItemHeight = 15;
            this.lstMatriz.Location = new System.Drawing.Point(22, 20);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(222, 259);
            this.lstMatriz.TabIndex = 0;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(22, 295);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(222, 25);
            this.btnMatriz.TabIndex = 1;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 341);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.lstMatriz);
            this.Name = "Form1";
            this.Text = "Matriz";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstMatriz;
        private Button btnMatriz;
    }
}