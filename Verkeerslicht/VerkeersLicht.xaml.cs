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

namespace Verkeerslicht
{
    /// <summary>
    /// Interaction logic for VerkeersLicht.xaml
    /// </summary>
    public partial class VerkeersLicht : Window
    {
        public VerkeersLicht()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            OranjeLicht.Opacity = 0;
            GroenLicht.Opacity = 1;
            OpgeletButton.IsEnabled = true;
            GoButton.IsEnabled = false;
        }

        private void OpgeletButton_Click(object sender, RoutedEventArgs e)
        {
            if (GroenLicht.Opacity == 1)
            {
                StopButton.IsEnabled = true;
                GroenLicht.Opacity = 0;
            }
            else
            {
                GoButton.IsEnabled = true;
                RoodLicht.Opacity = 0;
            }
            OranjeLicht.Opacity = 1;
            OpgeletButton.IsEnabled = false;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            OranjeLicht.Opacity = 0;
            RoodLicht.Opacity = 1;
            OpgeletButton.IsEnabled = true;
            StopButton.IsEnabled = false;
        }
    }
}
