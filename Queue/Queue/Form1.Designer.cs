namespace Queue
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
            this.simpleQueueBtn = new System.Windows.Forms.Button();
            this.circularQueueBtn = new System.Windows.Forms.Button();
            this.priorityQueueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simpleQueueBtn
            // 
            this.simpleQueueBtn.Location = new System.Drawing.Point(194, 61);
            this.simpleQueueBtn.Name = "simpleQueueBtn";
            this.simpleQueueBtn.Size = new System.Drawing.Size(224, 82);
            this.simpleQueueBtn.TabIndex = 0;
            this.simpleQueueBtn.Text = "Simple Array Typed Queue Test!";
            this.simpleQueueBtn.UseVisualStyleBackColor = true;
            this.simpleQueueBtn.Click += new System.EventHandler(this.simpleQueueBtn_Click);
            // 
            // circularQueueBtn
            // 
            this.circularQueueBtn.Location = new System.Drawing.Point(194, 167);
            this.circularQueueBtn.Name = "circularQueueBtn";
            this.circularQueueBtn.Size = new System.Drawing.Size(224, 82);
            this.circularQueueBtn.TabIndex = 0;
            this.circularQueueBtn.Text = "Circular Array Typed Queue Test!";
            this.circularQueueBtn.UseVisualStyleBackColor = true;
            this.circularQueueBtn.Click += new System.EventHandler(this.circularQueueBtn_Click);
            // 
            // priorityQueueBtn
            // 
            this.priorityQueueBtn.Location = new System.Drawing.Point(194, 268);
            this.priorityQueueBtn.Name = "priorityQueueBtn";
            this.priorityQueueBtn.Size = new System.Drawing.Size(224, 82);
            this.priorityQueueBtn.TabIndex = 0;
            this.priorityQueueBtn.Text = "Priority Array Typed Queue Test!";
            this.priorityQueueBtn.UseVisualStyleBackColor = true;
            this.priorityQueueBtn.Click += new System.EventHandler(this.priorityQueueBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 440);
            this.Controls.Add(this.priorityQueueBtn);
            this.Controls.Add(this.circularQueueBtn);
            this.Controls.Add(this.simpleQueueBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button simpleQueueBtn;
        private System.Windows.Forms.Button circularQueueBtn;
        private System.Windows.Forms.Button priorityQueueBtn;
    }
}

