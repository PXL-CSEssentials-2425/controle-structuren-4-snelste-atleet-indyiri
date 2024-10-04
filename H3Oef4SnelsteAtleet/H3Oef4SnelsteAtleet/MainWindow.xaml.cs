using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H3Oef4SnelsteAtleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string nameFastest;
        int timeFastest = 0;

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            int timeCurrent;
            bool isValidNumber = int.TryParse(timeTextBox.Text, out timeCurrent);

            if (isValidNumber == true)
            //of 'if (isValidNumber)' is eigenlijk al genoeg 
            {
                if ( timeFastest == 0 || timeCurrent < timeFastest)
                {
                    timeFastest = timeCurrent;
                    nameFastest = nameTextBox.Text;
                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = string.Empty;
            timeTextBox.Text = string.Empty;
            resultTextBox.Text = string.Empty;
        }

        private void fastestButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = $"De snelste atleet is {nameFastest} \n\rTotaal aantal seconden: {timeFastest}\n\r\n\rAantal uren: \n\rAantal minuten: \n\rAantal seconden";
            
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}