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
            btnDeleteBook = new Button();
            btnSearchBooks = new Button();
            label1 = new Label();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            txtSearchAuthor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddBook = new Button();
            SuspendLayout();
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(159, 351);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(130, 23);
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
            txtBookID.Size = new Size(130, 23);
            txtBookID.TabIndex = 2;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(39, 410);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(130, 23);
            btnUpdateBook.TabIndex = 3;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(159, 451);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(130, 23);
            btnDeleteBook.TabIndex = 4;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(675, 526);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(130, 23);
            btnSearchBooks.TabIndex = 5;
            btnSearchBooks.Text = "Search Book";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Location = new Point(102, 93);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "- Book ID - ";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(102, 195);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(130, 23);
            txtAuthorName.TabIndex = 7;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(102, 262);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(130, 23);
            txtBookTitle.TabIndex = 8;
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Location = new Point(675, 499);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.Size = new Size(130, 23);
            txtSearchAuthor.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.Location = new Point(102, 177);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 10;
            label2.Text = "- Author Name  - ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Bisque;
            label3.Location = new Point(531, 499);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 11;
            label3.Text = "- Search for a book - ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Bisque;
            label4.Location = new Point(102, 242);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 12;
            label4.Text = "- Book TItle - ";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(39, 301);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(130, 23);
            btnAddBook.TabIndex = 13;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Every_End;
            ClientSize = new Size(984, 561);
            Controls.Add(btnAddBook);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSearchAuthor);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(label1);
            Controls.Add(btnSearchBooks);
            Controls.Add(btnDeleteBook);
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
        private Button btnDeleteBook;
        private Button btnSearchBooks;
        private Label label1;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private TextBox txtSearchAuthor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddBook;
    }
}
