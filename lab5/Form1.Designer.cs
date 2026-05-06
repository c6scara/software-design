namespace lab5
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
            btnShowBooks = new Button();
            listBoxBooks = new ListBox();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            SuspendLayout();
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(102, 213);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(75, 23);
            btnShowBooks.TabIndex = 0;
            btnShowBooks.Text = "Show";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(295, 63);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(553, 409);
            listBoxBooks.TabIndex = 1;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(102, 125);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(100, 23);
            txtBookID.TabIndex = 2;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(102, 291);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(75, 23);
            btnUpdateBook.TabIndex = 3;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Every_End;
            ClientSize = new Size(984, 561);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(listBoxBooks);
            Controls.Add(btnShowBooks);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowBooks;
        private ListBox listBoxBooks;
        private TextBox txtBookID;
        private Button btnUpdateBook;
    }
}
