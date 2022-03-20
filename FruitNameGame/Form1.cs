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
                
                // A StreamReader variable
                StreamReader inputFile;

                // Open the file and get an object
                inputFile = File.OpenText("FruitList.txt");

                // Create a string array to hold the text file
                string[] nameArray = new string[SIZE];
                for (int index = 0; index < SIZE; index++)
                {
                    nameArray[index] = inputFile.ReadLine();
                }
               

                // var rand = new Random();
                List<string> nameList = nameArray.ToList();

                testListBox.Items.Add(nameList);
                // Read the file into a string list
                // List<string> nameList = new List<string>();
                

                // Read and display the name of a fruit
                //fruitName = inputFile.ReadLine();
                wordLabel.Text = fruitName;
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
