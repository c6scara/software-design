using System;
using System.Linq;
using System.Windows.Forms;
namespace Task5Part2Final

{

    public partial class Form1 : Form
    {
        private int[] numbers = new int[] { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1Output.Text = "Click Generate then Sort Descending";
            label1Status.Text = "Ready";
        }

        private void button2Generate_Click(object sender, EventArgs e)
        {
            numbers = new int[] { 64, 34, 25, 12, 22, 11, 90 };
            textBox1Output.Text = "🔄 UNSORTED:\n" + string.Join(", ", numbers);
            label1Status.Text = "Ready to Sort DESC ";
            label1Status.ForeColor = System.Drawing.Color.Blue;
        }

        private void button1Sort_Click(object sender, EventArgs e)
        {
            if (numbers.Length == 0)
            {
                MessageBox.Show("Generate first!");
                return;
            }

            // OO QuickSort Descending
            QuickSort(numbers, 0, numbers.Length - 1);

            textBox1Output.Text = " BEFORE: \n" + string.Join(", ", new int[] { 64, 34, 25, 12, 22, 11, 90 }) +
                                 "\n\n  AFTER DESC SORT: \n" + string.Join(", ", numbers);

            label1Status.Text = "Sorted Descending!";
            label1Status.ForeColor = System.Drawing.Color.Green;
        }

        // Object-Oriented Algorithm (Descending)
        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] >= pivot) // DESCENDING ORDER
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Empty
        }

        private void textBox1Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2Generate_Click_1(object sender, EventArgs e)
        {

        }
    }
}