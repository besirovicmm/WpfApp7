using System;
using System.Collections.ObjectModel;
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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Osoba> Osobe = new ObservableCollection<Osoba>();

        public MainWindow()
        {
            InitializeComponent();
            Osobe.Add(new Osoba("Muhammed", "Besirovic"));

            Osobe.Add(new Osoba("Muhammed2", "Besirovic2"));

            Osobe.Add(new Osoba("Muhammed3", "Besirovic3"));
            DG1.ItemsSource = Osobe;
        }

        private void BT1_Click(object sender, RoutedEventArgs e)
        {
           if(DG1.SelectedItem != null)
            {
                Osobe.Remove(DG1.SelectedItem as Osoba);
            }
          
        }

        private void BT2_Click(object sender, RoutedEventArgs e)
        {
            Window2 noviProzor = new Window2();
            //noviProzor.Visibility = Visibility.Visible;
            noviProzor.Owner = this;
            noviProzor.ShowDialog();//Zamrzava Kod dok je prozor aktivan

            if (noviProzor.ShowDialog() == true)
                Osobe.Add(noviProzor.DataContext as Osoba);
        }
    }

    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string a, string b)
        {
            Ime = a;
            Prezime = b;

        }
        public Osoba()
        {

        }
    }
}
