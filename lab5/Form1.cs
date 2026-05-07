using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Author
        {
            public string Name { get; set; }

            public int AuthorID { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }
        public class Book
        {
            public string Title { get; set; }
            public int BookID { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }
        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
                return booksWithAuthors;
            }
        }
        public void UpdateBookAndAuthor(int bookId, string newAuthorName, string newTitle)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully!");
        }
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var bookToDelete = context.Books.FirstOrDefault(b => b.BookID == bookId);

                if (bookToDelete != null)
                {
                    context.Books.Remove(bookToDelete);
                    context.SaveChanges();
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully!");

                btnShowBooks_Click(sender, e);

                txtBookID.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Book ID to delete.");
            }
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchAuthor.Text;

            if (!string.IsNullOrWhiteSpace(searchName))
            {
                var filteredBooks = SearchBooksByAuthor(searchName);

                listBoxBooks.DataSource = filteredBooks;

                if (filteredBooks.Count == 0)
                {
                    MessageBox.Show("No books found for that author.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an author name to search.");
            }
        }
        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var searchResults = context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.Title} by {b.Author.Name} (ID: {b.BookID})")
                    .ToList();

                return searchResults;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;
            string bookTitle = txtBookTitle.Text;

            if (!string.IsNullOrWhiteSpace(authorName) && !string.IsNullOrWhiteSpace(bookTitle))
            {
                AddAuthorWithBook(authorName, bookTitle);

                MessageBox.Show("Book and Author saved to database!");

                txtAuthorName.Clear();
                txtBookTitle.Clear();
            }
            else
            {
                MessageBox.Show("Please enter both an author name and a book title.");
            }
        }
    }
}
