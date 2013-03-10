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
            Profile profile = new Profile();
            profile.Show();
            //profile.Owner = this;
        }

        private void expander1_Expanded(object sender, RoutedEventArgs e)
        {
            this.Height += expander1.Height;
        }

        private void expander1_Collapsed(object sender, RoutedEventArgs e)
        {
            this.Height -= expander1.Height;
        }
    }
}
