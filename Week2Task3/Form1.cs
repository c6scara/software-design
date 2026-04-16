namespace Week2Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private long Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int n) && n >= 0 && n <= 46)
            {
                try
                {
                    long result = Fibonacci(n);
                    lblResult.Text = $"F({n}) = {result:N0}";
                    lblResult.ForeColor = Color.DarkGreen;
                }
                catch (OverflowException)
                {
                    lblResult.Text = $"F({n}) = TOO LARGE (Overflow!)";
                    
                }
            }
            else
            {
                lblResult.Text = "Enter valid number (0-46 only)";
                lblResult.ForeColor = Color.Red;
            }
        }
    }
}
