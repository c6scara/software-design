namespace Task1W2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial of {number} is {result}";    
        }
    }
}
