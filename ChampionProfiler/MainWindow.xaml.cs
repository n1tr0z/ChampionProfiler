using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChampionProfiler
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

        private void load_Champion(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Shit is Working");
            this.ChampionSelect.Visibility = Visibility.Collapsed; // Hides the main window
            this.ChampionProfile.Visibility = Visibility.Visible;  // Shows the profile window

            string champName = (string)((Button)sender).Tag; // Get the Champion name from the button Tag
            
            string imgSrc = "/ChampionProfiler;component/Images/" + champName + "Square.png"; // Creates the image source
            this.ChampImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(imgSrc, UriKind.Relative)); // Set the image
            this.ChampLabel.Content = champName; // Set the label content of the champion name

            var champKeys = new keyConfig();
            champKeys.getKeysfor("default");
        }

        private void load_mainwindow(object sender, RoutedEventArgs e)
        {
            this.ChampionProfile.Visibility = Visibility.Collapsed;
            this.ChampionSelect.Visibility = Visibility.Visible;
        }

        private void change_Key(object sender, RoutedEventArgs e)
        {

        }
    }
}
