namespace Stack
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
            this.arrayTypedStackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrayTypedStackBtn
            // 
            this.arrayTypedStackBtn.Location = new System.Drawing.Point(192, 151);
            this.arrayTypedStackBtn.Name = "arrayTypedStackBtn";
            this.arrayTypedStackBtn.Size = new System.Drawing.Size(185, 66);
            this.arrayTypedStackBtn.TabIndex = 0;
            this.arrayTypedStackBtn.Text = "Array Typed Stack Test!";
            this.arrayTypedStackBtn.UseVisualStyleBackColor = true;
            this.arrayTypedStackBtn.Click += new System.EventHandler(this.arrayTypedStackBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 425);
            this.Controls.Add(this.arrayTypedStackBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button arrayTypedStackBtn;
    }
}

