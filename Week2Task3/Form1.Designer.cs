namespace Week2Task3
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
            panel1 = new Panel();
            btnCalculate = new Button();
            lblResult = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(79, 111);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(159, 42);
            txtInput.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCalculate);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtInput);
            panel1.Location = new Point(107, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 421);
            panel1.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(100, 196);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calulate Fibonacci";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(454, 165);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(23, 26);
            lblResult.TabIndex = 5;
            lblResult.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 111);
            label2.Name = "label2";
            label2.Size = new Size(219, 26);
            label2.TabIndex = 4;
            label2.Text = "Results will show here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 69);
            label1.Name = "label1";
            label1.Size = new Size(204, 26);
            label1.TabIndex = 3;
            label1.Text = "Input numbers Here ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.Tidal_Wave;
            ClientSize = new Size(984, 461);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task 3.1 - Recursive Fibonacci Sequence";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtInput;
        private Panel panel1;
        private Label label1;
        private Label lblResult;
        private Label label2;
        private Button btnCalculate;
    }
}
