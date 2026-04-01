using System;
using System.Linq;
using System.Windows.Forms;


namespace Task5part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            btnSort = new Button();
            btnGenerate = new Button();
            lblStatus = new Label();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(154, 113);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort ";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(154, 184);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(343, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status -";
            lblStatus.Click += label1_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(332, 180);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(100, 23);
            txtOutput.TabIndex = 3;
            txtOutput.TextChanged += txtOutput_TextChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(665, 396);
            Controls.Add(txtOutput);
            Controls.Add(lblStatus);
            Controls.Add(btnGenerate);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Task 5 - 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnSort;
        private Button btnGenerate;
        private Label lblStatus;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private TextBox txtOutput;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }
    }
}