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

namespace PizzaWindow
{
    /// <summary>
    /// Interaction logic for PizzaBestellen.xaml
    /// </summary>
    public partial class PizzaBestellen : Window
    {
        public PizzaBestellen()
        {
            InitializeComponent();
        }
        private void meer_Click(object sender, RoutedEventArgs e)
        {
            int aantal = Convert.ToInt16(aantalLabel.Content);
            if (aantal < 10)
                aantal++;
            aantalLabel.Content = aantal.ToString();
        }
        private void minder_Click(object sender, RoutedEventArgs e)
        {
            int aantal = Convert.ToInt16(aantalLabel.Content);
            if (aantal > 1)
                aantal--;
            aantalLabel.Content = aantal.ToString();
        }
        private void bestellen_Click(object sender, RoutedEventArgs e)
        {
            string tekst = " U heeft " + aantalLabel.Content + " ";
            string ingredienten = string.Empty;
            foreach (FrameworkElement kind in boxen.Children)
            {
                if (kind is RadioButton)
                {
                    if (((RadioButton)kind).IsChecked == true)
                        tekst += kind.Name + @" pizza('s) besteld met: ";
                }
                if (kind is CheckBox)
                    if (((CheckBox)kind).IsChecked == true)
                        ingredienten += kind.Name + ", ";
            }
            ingredienten = ingredienten.Substring(0, ingredienten.Length - 2);
            int k = ingredienten.LastIndexOf(",");
            ingredienten = ingredienten.Substring(0, k) + " en " +
            ingredienten.Substring(k + 2);
            tekst += ingredienten + "\n";
            if (extrakorst.IsChecked == true)
                tekst += " met een extra dikke korst \n";
            if (extrakaas.IsChecked == true)
                tekst += " overstrooid met extra kaas";
            bestelling.Content = tekst;
        }

    }
}
