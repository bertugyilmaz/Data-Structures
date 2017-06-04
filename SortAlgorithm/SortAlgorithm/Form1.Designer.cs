namespace SortAlgorithm
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
            this.bubbleSortBtn = new System.Windows.Forms.Button();
            this.selectionSortBtn = new System.Windows.Forms.Button();
            this.insertionSortBtn = new System.Windows.Forms.Button();
            this.quickSortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bubbleSortBtn
            // 
            this.bubbleSortBtn.Location = new System.Drawing.Point(214, 47);
            this.bubbleSortBtn.Name = "bubbleSortBtn";
            this.bubbleSortBtn.Size = new System.Drawing.Size(150, 62);
            this.bubbleSortBtn.TabIndex = 0;
            this.bubbleSortBtn.Text = "Bubble Sort Test!";
            this.bubbleSortBtn.UseVisualStyleBackColor = true;
            this.bubbleSortBtn.Click += new System.EventHandler(this.bubbleSortBtn_Click);
            // 
            // selectionSortBtn
            // 
            this.selectionSortBtn.Location = new System.Drawing.Point(214, 125);
            this.selectionSortBtn.Name = "selectionSortBtn";
            this.selectionSortBtn.Size = new System.Drawing.Size(150, 62);
            this.selectionSortBtn.TabIndex = 0;
            this.selectionSortBtn.Text = "Selection Sort Test!";
            this.selectionSortBtn.UseVisualStyleBackColor = true;
            this.selectionSortBtn.Click += new System.EventHandler(this.selectionSortBtn_Click);
            // 
            // insertionSortBtn
            // 
            this.insertionSortBtn.Location = new System.Drawing.Point(214, 202);
            this.insertionSortBtn.Name = "insertionSortBtn";
            this.insertionSortBtn.Size = new System.Drawing.Size(150, 62);
            this.insertionSortBtn.TabIndex = 0;
            this.insertionSortBtn.Text = "Insertion Sort Test!";
            this.insertionSortBtn.UseVisualStyleBackColor = true;
            this.insertionSortBtn.Click += new System.EventHandler(this.insertionSortBtn_Click);
            // 
            // quickSortBtn
            // 
            this.quickSortBtn.Location = new System.Drawing.Point(214, 279);
            this.quickSortBtn.Name = "quickSortBtn";
            this.quickSortBtn.Size = new System.Drawing.Size(150, 62);
            this.quickSortBtn.TabIndex = 0;
            this.quickSortBtn.Text = "Quick Sort Test!";
            this.quickSortBtn.UseVisualStyleBackColor = true;
            this.quickSortBtn.Click += new System.EventHandler(this.quickSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 381);
            this.Controls.Add(this.quickSortBtn);
            this.Controls.Add(this.insertionSortBtn);
            this.Controls.Add(this.selectionSortBtn);
            this.Controls.Add(this.bubbleSortBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bubbleSortBtn;
        private System.Windows.Forms.Button selectionSortBtn;
        private System.Windows.Forms.Button insertionSortBtn;
        private System.Windows.Forms.Button quickSortBtn;
    }
}

