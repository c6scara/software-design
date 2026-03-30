namespace Task4
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
            btnSortt = new Button();
            listBoxResultss = new ListBox();
            SuspendLayout();
            // 
            // btnSortt
            // 
            btnSortt.Location = new Point(301, 232);
            btnSortt.Name = "btnSortt";
            btnSortt.Size = new Size(75, 23);
            btnSortt.TabIndex = 0;
            btnSortt.Text = "sort";
            btnSortt.UseVisualStyleBackColor = true;
            btnSortt.Click += btnSort_Click;
            // 
            // listBoxResultss
            // 
            listBoxResultss.FormattingEnabled = true;
            listBoxResultss.Location = new Point(214, 76);
            listBoxResultss.Name = "listBoxResultss";
            listBoxResultss.Size = new Size(286, 94);
            listBoxResultss.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResultss);
            Controls.Add(btnSortt);
            Name = "Form1";
            Text = "Task 4";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSortt;
        private ListBox listBoxResultss;
    }
}
