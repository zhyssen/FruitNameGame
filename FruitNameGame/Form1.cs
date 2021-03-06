using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FruitNameGame
{
    public partial class FruitNameGameForm : Form
    {
        public FruitNameGameForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                string fruitName;           // Holds the name of the fruit to find
                const int SIZE = 10;        // Holds the size of the array

                // Create a string array to hold the text file
                string[] nameArray = new string[SIZE];

                // Counter variable for the loop
                int index = 0;

                // A StreamReader variable
                StreamReader inputFile;

                // Open the file and get an object
                inputFile = File.OpenText("FruitList.txt");

                // Read the file into the array
                while (index < nameArray.Length && !inputFile.EndOfStream)
                {
                    nameArray[index] = inputFile.ReadLine();
                    index++;
                }

                // Close the file
                inputFile.Close();
               
                // Display the array elements in the test list box to verify if read correctly
                foreach (string name in nameArray)
                {
                    testListBox.Items.Add(name);
                }

                // Create a new random object
                Random random = new Random();
                nameArray = nameArray.OrderBy(x => random.Next()).ToArray();

                // Display the randomized array elements in the test2 list box
                // to verify that list is randomized
                foreach (string name in nameArray)
                {
                    test2ListBox.Items.Add(name);
                }


                // Read and display the name of a fruit
                //fruitName = inputFile.ReadLine();
                //wordLabel.Text = fruitName;
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            // End the game
            // maybe change to restart and start button to begin?
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
