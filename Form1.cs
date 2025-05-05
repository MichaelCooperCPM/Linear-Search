namespace Linear_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array;

        private void GenerateArrayButton_Click(object sender, EventArgs e)
        {
            array = GenerateArray();
            DisplayArray(array);
        }

        private void LinearSearchButton_Click(object sender, EventArgs e)
        {
            int searchedValue = GetSearchedValue();
            bool found = LinearSearch(array, searchedValue);
            DisplayResult(found);
        }

        int[] GenerateArray()
        {
            int arraySize = Convert.ToInt32(ArraySizeTextbox.Text);
            int[] array = new int[arraySize];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, arraySize);
            }

            return array;
        }

        void DisplayArray(int[] array)
        {
            DisplayArrayListbox.Items.Clear();
            foreach (int i in array)
            {
                DisplayArrayListbox.Items.Add(i);
            }
        }

        bool LinearSearch(int[] array, int searchedValue)
        {
            foreach (int i in array)
            {
                if (i == searchedValue)
                {
                    return true;
                }
            }
            return false;
        }

        int GetSearchedValue()
        {
            return Convert.ToInt32(SearchedValueTextbox.Text);
        }

        void DisplayResult(bool found)
        {
            if (found == true)
            {
                SearchResultLabel.Text = "Value found";
            }
            else
            {
                SearchResultLabel.Text = "Value not found";
            }
        }
    }
}
