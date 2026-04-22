namespace lab3
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
            btnShowInfo = new Button();
            listBoxInfo = new ListBox();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(62, 231);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(153, 23);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Information";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // listBoxInfo
            // 
            listBoxInfo.FormattingEnabled = true;
            listBoxInfo.ItemHeight = 15;
            listBoxInfo.Location = new Point(301, 95);
            listBoxInfo.Name = "listBoxInfo";
            listBoxInfo.Size = new Size(600, 319);
            listBoxInfo.TabIndex = 1;
            listBoxInfo.SelectedIndexChanged += listBoxInfo_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1024px_Aeternus;
            ClientSize = new Size(984, 561);
            Controls.Add(listBoxInfo);
            Controls.Add(btnShowInfo);
            Name = "Form1";
            Text = "Library - Lab 3 By: Maniego";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox listBoxInfo;
    }
}
