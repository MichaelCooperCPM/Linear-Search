namespace Linear_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array; // class level array so all methods/functions can access it

        private void GenerateArrayButton_Click(object sender, EventArgs e)
        {
            array = GenerateArray(); // array is set to result of GenerateArray Function
            DisplayArray(array); // call DisplayArray method, pass it the array
        }

        private void LinearSearchButton_Click(object sender, EventArgs e)
        {
            int searchedValue = GetSearchedValue(); // searched value is equal to the value returned by GetSearchValue function
            bool found = LinearSearch(array, searchedValue); // found is equal to returned value from LinearSearch, passed the array and searched value
            DisplayResult(found); // Call DisplayRessult, pass it found variable
        }

        int[] GenerateArray()
        {
            SearchResultLabel.Text = "Search not yet run"; // reset result label
            int arraySize = Convert.ToInt32(ArraySizeTextbox.Text); // use value from textbox for array length and max value
            int[] array = new int[arraySize]; // create array with a length of the value entered by user

            Random rand = new Random(); // create a new random number generator called rand

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, arraySize); // set each value in the array to a random number between 0 and the length of the array
            }

            return array; // return the array to where it was called in GenerateArrayButton_Click method
        }

        void DisplayArray(int[] array)
        {
            DisplayArrayListbox.Items.Clear(); // clear the listbox
            if (array.Length <= 10000) // only display the array if it has a length less than 10000 (Listbox is slow otherwise)
            {
                foreach (int value in array)
                {
                    DisplayArrayListbox.Items.Add(value); // add values from the array to the listbox
                }
            }
            else
            {
                DisplayArrayListbox.Items.Add("Array >10000 values"); // message to display if array length is > 10000
            }

        }

        // Linear search algorithm, returns true or false depending if value passed value is found in passed array
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
            // return valye from the textbox to where the function was called
            return Convert.ToInt32(SearchedValueTextbox.Text);
        }

        void DisplayResult(bool found)
        {
            // display the result of the serach, based on the value of found
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
