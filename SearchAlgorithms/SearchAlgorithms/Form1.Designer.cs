namespace SearchAlgorithms
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
            this.linearSearchBtn = new System.Windows.Forms.Button();
            this.binarySearchBtn = new System.Windows.Forms.Button();
            this.txtArananSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linearSearchBtn
            // 
            this.linearSearchBtn.Location = new System.Drawing.Point(158, 100);
            this.linearSearchBtn.Name = "linearSearchBtn";
            this.linearSearchBtn.Size = new System.Drawing.Size(183, 63);
            this.linearSearchBtn.TabIndex = 0;
            this.linearSearchBtn.Text = "Linear Search Test!";
            this.linearSearchBtn.UseVisualStyleBackColor = true;
            this.linearSearchBtn.Click += new System.EventHandler(this.linearSearchBtn_Click);
            // 
            // binarySearchBtn
            // 
            this.binarySearchBtn.Location = new System.Drawing.Point(158, 188);
            this.binarySearchBtn.Name = "binarySearchBtn";
            this.binarySearchBtn.Size = new System.Drawing.Size(183, 63);
            this.binarySearchBtn.TabIndex = 0;
            this.binarySearchBtn.Text = "Binary Search Test!";
            this.binarySearchBtn.UseVisualStyleBackColor = true;
            this.binarySearchBtn.Click += new System.EventHandler(this.binarySearchBtn_Click);
            // 
            // txtArananSayi
            // 
            this.txtArananSayi.Location = new System.Drawing.Point(158, 48);
            this.txtArananSayi.Name = "txtArananSayi";
            this.txtArananSayi.Size = new System.Drawing.Size(183, 26);
            this.txtArananSayi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 363);
            this.Controls.Add(this.txtArananSayi);
            this.Controls.Add(this.binarySearchBtn);
            this.Controls.Add(this.linearSearchBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button linearSearchBtn;
        private System.Windows.Forms.Button binarySearchBtn;
        private System.Windows.Forms.TextBox txtArananSayi;
    }
}

