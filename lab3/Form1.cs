namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"Title: {Title}, Author: {Author}";

            }

        }

        public class Ebook : Book
        {
            public string Format { get; set; }
            public double FileSize { get; set; }
            public override string GetInfo()
            {
                return $"Title: {Title}, Author: {Author}, Format: {Format}, File Size: {FileSize} MB";
            }
        }
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"Title: {Title} -  Issue Number: {IssueNumber}";
            }
        }
        private void ProcessBooksPoly(Book[] books, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (Book book in books)
            {
                string info = book.GetInfo();
                listBox.Items.Add(info);
            }
        }
        private void btnShowInfo_Click(object sender, EventArgs e) //task 2 number 2 diria
        {
            Book[] books = new Book[]
            {
               new Book
               {
                   Title = "The Great Gatsby",
                     Author = "F. Scott Fitzgerald"
               },
                new Ebook
                {
                     Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Format = "PDF",
                        FileSize = 2.5
                },
                    new Magazine
                    {
                        Title = "The Great Gatsby",
                        IssueNumber = 5
                    }
                   
            };
            //display polymorphic method call here
            ProcessBooksPoly(books, listBoxInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PolymorphicMethod(Book[] books, ListBox listBox)
        {
            listBox.Items.Clear(); 
            foreach (Book book in books)
            {
                string info = book.GetInfo();
                listBox.Items.Add(info);
            }
        }

        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
