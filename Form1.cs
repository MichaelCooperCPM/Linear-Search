namespace Linear_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateArrayButton_Click(object sender, EventArgs e)
        {
            int[] array = GenerateArray();
            DisplayArray(array);
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
            foreach (int i in array)
            {
                DisplayArrayListbox.Items.Add(i);
            }
        }
    }
}
