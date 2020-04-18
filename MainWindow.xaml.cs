/*
 * Oliver Byl
 * April 17, 2020
 * Unit 2 Summative (Problem J1)
 */
using System;
using System.Windows;
using System.IO;

namespace Unit2J1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                StreamReader reader = new StreamReader("input.txt");

                // Fetch 6 ints from input:
                int.TryParse(reader.ReadLine(), out int aThrees);
                int.TryParse(reader.ReadLine(), out int aTwos);
                int.TryParse(reader.ReadLine(), out int aOnes);

                int.TryParse(reader.ReadLine(), out int bThrees);
                int.TryParse(reader.ReadLine(), out int bTwos);
                int.TryParse(reader.ReadLine(), out int bOnes);

                // Calculate team scores:
                int aScore = aThrees * 3 + aTwos * 2 + aOnes;
                int bScore = bThrees * 3 + bTwos * 2 + bOnes;

                // Calculate and update output with match result:
                if (aScore > bScore)
                {
                    output.Content = "A";
                }
                else if (bScore > aScore)
                {
                    output.Content = "B";
                }
                else
                {
                    output.Content = "T";
                }

                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
