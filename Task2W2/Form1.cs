namespace Task2W2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
            public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);

        }
        public int RecursiveSum(int n)
        {
            if ((n & 1) == 0) { return 1; }
            return n * RecursiveSum(n - 1);
        }
        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return n + RecursiveSum(n - 1);
        }

        
private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblSumResult.Text = $"Factorial: {result}";
        }
    }


}
