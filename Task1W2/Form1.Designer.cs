namespace Task1W2
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
            txtInput = new TextBox();
            btnCalculateFactorial = new Button();
            lblResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(77, 167);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(86, 234);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(75, 23);
            btnCalculateFactorial.TabIndex = 1;
            btnCalculateFactorial.Text = "Calculate";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(248, 192);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(449, 65);
            lblResult.TabIndex = 2;
            lblResult.Text = "will be shown here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 143);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 3;
            label1.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1064, 761);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Recursive Factorial Tester";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCalculateFactorial;
        private Label lblResult;
        private Label label1;
    }
}
