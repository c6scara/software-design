namespace Task3._2Week2
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
            panel1 = new Panel();
            btnCalculate = new Button();
            txtBaseInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtExponentInput = new TextBox();
            lblResult = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtExponentInput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBaseInput);
            panel1.Controls.Add(btnCalculate);
            panel1.Location = new Point(37, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 378);
            panel1.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(62, 277);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(184, 37);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate Recursive Power";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(62, 107);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(184, 23);
            txtBaseInput.TabIndex = 1;
            txtBaseInput.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 70);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 2;
            label1.Text = "Input base numbers here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(508, 70);
            label2.Name = "label2";
            label2.Size = new Size(327, 37);
            label2.TabIndex = 3;
            label2.Text = "Results will be shown here";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 159);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 5;
            label3.Text = "Input exponents here";
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(62, 196);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(184, 23);
            txtExponentInput.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(620, 142);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(77, 37);
            lblResult.TabIndex = 6;
            lblResult.Text = "0000";
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Grief_New;
            ClientSize = new Size(984, 461);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task 3-2 Recursive Power Calculation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBaseInput;
        private Button btnCalculate;
        private Label label1;
        private Label label3;
        private TextBox txtExponentInput;
        private Label label2;
        private Label lblResult;
    }
}
