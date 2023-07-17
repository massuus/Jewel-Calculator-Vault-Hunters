using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vault_jewel_calculator
{
    public partial class MainForm : Form
    {
        private List<Jewel> jewels;
        private int maxToolSpace;
        private int nextJewelId;

        public MainForm()
        {
            InitializeComponent();
            jewels = new List<Jewel>();
            nextJewelId = 1;

            // Enable copying and pasting in the jewelListBox
            jewelListBox.SelectionMode = SelectionMode.MultiSimple;
            jewelListBox.KeyDown += JewelListBox_KeyDown;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Get jewel information from user input
            string name = nameTextBox.Text;
            int size;
            double value;

            if (!int.TryParse(sizeTextBox.Text, out size))
            {
                MessageBox.Show("Invalid size input. Please enter a valid integer value.");
                return;
            }

            if (!double.TryParse(valueTextBox.Text, out value))
            {
                MessageBox.Show("Invalid value input. Please enter a valid decimal value.");
                return;
            }

            // Create a new Jewel object with a unique ID
            Jewel jewel = new Jewel(nextJewelId, name, size, value);
            jewels.Add(jewel);

            // Increment the next jewel ID
            nextJewelId++;

            // Clear size and value input fields
            sizeTextBox.Clear();
            valueTextBox.Clear();

            // Update jewel list
            UpdateJewelList();
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (jewelListBox.SelectedItems.Count <= 0) return;
            // Get the selected jewels
            List<Jewel> selectedJewels = jewelListBox.SelectedItems.Cast<Jewel>().ToList();

            // Remove the selected jewels from the list
            foreach (Jewel jewel in selectedJewels)
            {
                jewels.Remove(jewel);
            }

            // Update jewel list
            UpdateJewelList();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (jewelListBox.SelectedItems.Count > 0)
            {
                // Create a string representation of the selected jewels
                List<Jewel> selectedJewels = jewelListBox.SelectedItems.Cast<Jewel>().ToList();
                string jewelData = string.Join(Environment.NewLine, selectedJewels.Select(j => j.ToString()));

                // Copy the jewel data to the clipboard
                Clipboard.SetText(jewelData);
            }
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            // Get the jewel data from the clipboard
            string jewelData = Clipboard.GetText();

            // Split the jewel data by newlines
            string[] jewelLines = jewelData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in jewelLines)
            {
                // Parse each line to extract the jewel information
                string[] parts = line.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    string nameSizeValue = parts[1];
                    string[] nameSizeValueParts = nameSizeValue.Split(new[] { " (Size: ", ", Value: " }, StringSplitOptions.RemoveEmptyEntries);
                    if (nameSizeValueParts.Length == 3)
                    {
                        int id = nextJewelId++; // Increment the next jewel ID
                        string name = nameSizeValueParts[0];
                        int size = int.Parse(nameSizeValueParts[1]);
                        double value = double.Parse(nameSizeValueParts[2].TrimEnd(')'));

                        // Create a new Jewel object and add it to the list
                        Jewel jewel = new Jewel(id, name, size, value);
                        jewels.Add(jewel);
                    }
                }
            }

            // Update jewel list
            UpdateJewelList();
        }



        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maxSpaceTextBox.Text, out maxToolSpace))
            {
                // Calculate the best jewels
                List<Jewel> bestJewels = CalculateBestJewels(jewels, maxToolSpace);

                // Display the best jewels
                bestJewelsTextBox.Text = string.Join(Environment.NewLine, bestJewels);
                totalValue.Text = bestJewels.Sum(jewel => jewel.Value).ToString();
                totalSize.Text = bestJewels.Sum(jewel => jewel.Size).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input for the maximum tool space.");
            }
        }

        private List<Jewel> CalculateBestJewels(List<Jewel> jewels, int remainingSpace)
        {
            List<Jewel> bestJewels = new List<Jewel>();
            List<Jewel> currentJewels = new List<Jewel>();

            // Find the best jewels using backtracking
            FindBestJewels(jewels.OrderByDescending(j => j.Goodness).ToList(), remainingSpace, 0, 0, currentJewels, ref bestJewels);

            return bestJewels;
        }

        private void FindBestJewels(List<Jewel> sortedJewels, int remainingSpace, int index, double currentValue, List<Jewel> currentJewels, ref List<Jewel> bestJewels)
        {
            if (index == sortedJewels.Count)
            {
                // Update the best jewels if a higher value combination is found
                if (currentValue > bestJewels.Sum(j => j.Value))
                {
                    bestJewels = new List<Jewel>(currentJewels);
                }
                return;
            }

            if (sortedJewels[index].Size <= remainingSpace)
            {
                // Include the current jewel in the combination
                currentJewels.Add(sortedJewels[index]);
                FindBestJewels(sortedJewels, remainingSpace - sortedJewels[index].Size, index + 1, currentValue + sortedJewels[index].Value, currentJewels, ref bestJewels);

                // Backtrack and exclude the current jewel from the combination
                currentJewels.RemoveAt(currentJewels.Count - 1);
            }

            // Skip the current jewel and move to the next one
            FindBestJewels(sortedJewels, remainingSpace, index + 1, currentValue, currentJewels, ref bestJewels);
        }

        private void UpdateJewelList()
        {
            jewelListBox.Items.Clear();
            foreach (Jewel jewel in jewels)
            {
                jewelListBox.Items.Add(jewel);
            }
        }

        private void JewelListBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Delete selected jewels when the Delete key is pressed
            if (e.KeyCode == Keys.Delete)
            {
                deleteButton.PerformClick();
            }
        }
    }

    public class Jewel
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Size { get; set; }
        public double Value { get; set; }
        public double Goodness { get; set; }

        public Jewel(int id, string name, int size, double value)
        {
            Id = id;
            Name = name;
            Size = size;
            Value = value;
            Goodness = Value / Size;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} (Size: {Size}, Value: {Value})";
        }
    }
}
