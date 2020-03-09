using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            DataContext = new Osoba();
        }
        public bool unesi;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //unesi = false;
            this.Close();
            this.DialogResult = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //unesi = true;
            this.BindingGroup.CommitEdit();
            this.Close();
            this.DialogResult = true;
        }
    }
}
