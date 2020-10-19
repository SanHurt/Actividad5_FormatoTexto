using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace Actividad5_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }
        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            copyTextTextBox.FontWeight = FontWeights.Normal;
        }
        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            copyTextTextBox.FontWeight = FontWeights.Bold;
        }
        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            copyTextTextBox.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            copyTextTextBox.FontStyle = FontStyles.Normal;
        }
        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            copyTextTextBox.Foreground = Brushes.Blue;
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            copyTextTextBox.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            copyTextTextBox.Foreground = Brushes.Green;
        }

        private void escribirTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            copyTextTextBox.Text = escribirTextBox.Text;
        }

        
    }
}
