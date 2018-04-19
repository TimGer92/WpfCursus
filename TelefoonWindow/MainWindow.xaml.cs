using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace TelefoonWindow
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
        public List<Persoon> personen = new List<Persoon>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            personen.Add(new Persoon("kleine zus", "03 213 45 12", "Familie", new BitmapImage(new Uri(@"images\kleinezus.jpg", UriKind.Relative))));
            personen.Add(new Persoon("grote zus", " 03 213 45 12", "Familie", new BitmapImage(new Uri(@"images\grotezus.jpg", UriKind.Relative))));
            personen.Add(new Persoon("vader", "02 12 45 78", "Familie", new BitmapImage(new Uri(@"images\vader.jpg", UriKind.Relative))));
            personen.Add(new Persoon("tante non", "056 78 45 12", "Familie", new BitmapImage(new Uri(@"images\tantenon.jpg", UriKind.Relative))));
            personen.Add(new Persoon("collega 1", "014 45 16 98", "Werk", new BitmapImage(new Uri(@"images\collega1.jpg", UriKind.Relative))));
            personen.Add(new Persoon("collega 2", "03 86 54 79", "Werk", new BitmapImage(new Uri(@"images\collega2.jpg", UriKind.Relative))));
            personen.Add(new Persoon("collega 3", "045 12 45 23", "Werk", new BitmapImage(new Uri(@"images\collega3.jpg", UriKind.Relative))));
            personen.Add(new Persoon("bob", "012 45 37 58", "Vrienden", new BitmapImage(new Uri(@"images\bob.jpg", UriKind.Relative))));
            personen.Add(new Persoon("ed", "065 43 29 75", "Vrienden", new BitmapImage(new Uri(@"images\ed.jpg", UriKind.Relative))));
            personen.Add(new Persoon("anne", "065 43 29 76", "Vrienden", new BitmapImage(new Uri(@"images\anne.jpg", UriKind.Relative))));
            foreach (Persoon dePersoon in personen)
            {
                ListBoxPersonen.Items.Add(dePersoon);
            }
            ComboBoxGroep.Items.Add("Iedereen");
            ComboBoxGroep.Items.Add("Familie");
            ComboBoxGroep.Items.Add("Vrienden");
            ComboBoxGroep.Items.Add("Werk");
            ComboBoxGroep.SelectedIndex = 0;
        }

        private void ComboBoxGroep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxPersonen.Items.Clear();
            foreach (Persoon dePersoon in personen)
            {
                if (ComboBoxGroep.SelectedItem.ToString() == "Iedereen")
                {
                    ListBoxPersonen.Items.Add(dePersoon);
                }
                else
                {
                    if ((dePersoon.Groep ==
                    ComboBoxGroep.SelectedItem.ToString()))
                        ListBoxPersonen.Items.Add(dePersoon);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxPersonen.SelectedIndex >= 0)
            {
                Persoon beller = (Persoon)ListBoxPersonen.SelectedItem;
                if (MessageBox.Show("Wil je " + beller.Naam + " bellen \nop het nummer: " +
                beller.TelefoonNummer, "Telefoon", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
                {
                    SoundPlayer speler = new SoundPlayer("PHONE.wav");
                    speler.Play();
                }
            }
            else
            {
                MessageBox.Show("Je moet eerst iemand selecteren", "Niemand gekozen",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }
    }
}

