namespace Task3._2Week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
        public long Power(int baseNum, int exponent)
        {
            // Base case: anything^0 = 1
            if (exponent == 0) return 1;

            // Base case: negative exponents not supported
            if (exponent < 0)
                throw new ArgumentException("Exponent must be ? 0");

            // Recursive case: x^n = x * x^(n-1)
            return baseNum * Power(baseNum, exponent - 1);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNum = int.Parse(txtBaseInput.Text);
                int exponent = int.Parse(txtExponentInput.Text);

                long result = Power(baseNum, exponent);

                lblResult.Text = $"{baseNum}^{exponent} = {result:N0}";
                lblResult.ForeColor = Color.DarkBlue;
                lblResult.BackColor = Color.LightYellow;
            }
            catch (OverflowException)
            {
                lblResult.Text = "? Result too large (Overflow!)";
                lblResult.ForeColor = Color.Red;
                lblResult.BackColor = Color.LightPink;
            }
            catch (FormatException)
            {
                lblResult.Text = "? Enter valid integers!";
                lblResult.ForeColor = Color.Red;
                lblResult.BackColor = Color.LightPink;
            }
            catch (ArgumentException ex)
            {
                lblResult.Text = $"? {ex.Message}";
                lblResult.ForeColor = Color.Red;
                lblResult.BackColor = Color.LightPink;
            }
        }
    }
}
