using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SortTextBoxNumbers()
        {
            try
            {
                // Get numbers from TextBox (split by spaces, commas, or newlines)
                string input = textBox1.Text.Trim(); // Replace 'textBox1' with your TextBox name

                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Please enter numbers in the TextBox!", "No Input",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse numbers (handles spaces, commas, newlines)
                string[] parts = input.Replace("\n", " ").Replace(",", " ").Split(new char[] { ' ', '\t' },
                                                                                 StringSplitOptions.RemoveEmptyEntries);

                int[] numbers = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(parts[i]);
                }

                // Apply bubble sort
                BubbleSortArray(numbers);

                // Display sorted results in ListBox
                listBox1.Items.Clear(); // Replace 'listBox1' with your ListBox name
                foreach (int num in numbers)
                {
                    listBox1.Items.Add(num);
                }

                // Optional: Show sorted result in another TextBox or Label
                //textBox2.Text = string.Join(", ", numbers); // Optional output TextBox
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers only!", "Invalid Input",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BubbleSortArray(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortTextBoxNumbers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add sample instruction
            textBox1.Text = "64 34 25 12 22 11 90"; // Sample input
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}