using System;
using System.Windows;
using System.Windows.Input;

namespace CoffeeShopSimulator
{
    public partial class ResultsWindow : Window
    {
        public ResultsWindow(GameRecord record)
        {
            InitializeComponent();

            // Set the values of the game record text blocks
            NicknameText.Text += record.Nickname;
            DateText.Text += record.Date.ToShortDateString();
            EndingText.Text += record.Ending;
            MoneyText.Text += record.Money.ToString() + "$";

            // Add event handler for key press
            this.KeyDown += ResultsWindow_KeyDown;
        }

        // Navigate to the game menu when the "Enter" key is pressed
        private void ResultsWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Close(); // Close the current results window

                // Make the main window visible again
                var mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow.Show();
            }
        }
    }
}
