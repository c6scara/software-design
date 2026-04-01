namespace Task5Part2Final
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
            this.button2Generate = new System.Windows.Forms.Button();
            this.button1Sort = new System.Windows.Forms.Button();
            this.textBox1Output = new System.Windows.Forms.TextBox();
            this.label1Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2Generate
            // 
            this.button2Generate.Location = new System.Drawing.Point(12, 12);
            this.button2Generate.Name = "button2Generate";
            this.button2Generate.Size = new System.Drawing.Size(100, 30);
            this.button2Generate.TabIndex = 0;
            this.button2Generate.Text = "Generate";
            this.button2Generate.UseVisualStyleBackColor = true;
            this.button2Generate.Click += new System.EventHandler(this.button2Generate_Click);
            // 
            // button1Sort
            // 
            this.button1Sort.Location = new System.Drawing.Point(120, 12);
            this.button1Sort.Name = "button1Sort";
            this.button1Sort.Size = new System.Drawing.Size(100, 30);
            this.button1Sort.TabIndex = 1;
            this.button1Sort.Text = "Sort DESC";
            this.button1Sort.UseVisualStyleBackColor = true;
            this.button1Sort.Click += new System.EventHandler(this.button1Sort_Click);
            // 
            // textBox1Output
            // 
            this.textBox1Output.Location = new System.Drawing.Point(12, 50);
            this.textBox1Output.Multiline = true;
            this.textBox1Output.Name = "textBox1Output";
            this.textBox1Output.ReadOnly = true;
            this.textBox1Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1Output.Size = new System.Drawing.Size(760, 300);
            this.textBox1Output.TabIndex = 2;
            this.textBox1Output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1Status
            // 
            this.label1Status.AutoSize = true;
            this.label1Status.Location = new System.Drawing.Point(12, 360);
            this.label1Status.Name = "label1Status";
            this.label1Status.Size = new System.Drawing.Size(37, 15);
            this.label1Status.TabIndex = 3;
            this.label1Status.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.label1Status);
            this.Controls.Add(this.textBox1Output);
            this.Controls.Add(this.button1Sort);
            this.Controls.Add(this.button2Generate);
            this.Name = "Form1";
            this.Text = "QuickSort DESC Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1Sort;
        private Button button2Generate;
        private TextBox textBox1Output;
        private Label label1Status;
    }
}
