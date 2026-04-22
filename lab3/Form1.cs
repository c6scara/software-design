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
            public string Title { get; set; } = "Unknown Title";
            public string Author { get; set; } = "Uknown Author";
            public virtual string GetInfo()
            {
                return $"BOOK - Title: {Title}, Author: {Author}";

            }

        }

        public class Ebook : Book
        {
            public string Format { get; set; } = "Unknown Format";
            public double FileSize { get; set; } = 0.0; // in MB
            public override string GetInfo()
            {
                return $"EBOOK - Title: {Title}, Author: {Author}, Format: {Format}, File Size: {FileSize} MB";
            }
        }
        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; } = "Unknown Narrator";
            public override string GetInfo()
            {
                return $"AUDIOBOOK - Title: {Title}, Author: {Author}, Duration: {Duration} hours";
            }
        }
        public class Textbook : Book
        {
            public string Subject { get; set; } = "General";

            public override string GetInfo()
            {
                return $"TEXTBOOK - Title: {Title}, Author: {Author}, Subject: {Subject}";
            }
        }
        public class Magazine : Book
        {
            public int IssueNumber { get; set; } = 1;

            public override string GetInfo()
            {
                return $"MAGAZINE - Title: {Title} -  Issue Number: {IssueNumber}";
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
                    },
               new Magazine 
               {
                   Title = "National Geographic",
                   IssueNumber = 10
               },
                new Textbook
                {
                    Title = "Introduction to Computer Science",
                    Author = "John Doe",
                    Subject = "Computer Science"
                },
                 new AudioBook
                 {
                     Title = "The Great Gatsby",
                     Author = "F. Scott Fitzgerald",
                     Duration = 5.5,
                     Narrator = "Jane Smith"
                 }


            };
            //display polymorphic method call here
            ProcessBooksPoly(books, listBoxInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
