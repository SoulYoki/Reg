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
using Reg.Base;


namespace Reg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Base.User User = null;
        int id = 0;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            phonesList.ItemsSource = SourceCore.MyBase.Product.ToList();

        }
        private void SelectAuthWindow()
        {
            auto window = new auto();
            window.Show();
            Close();
        }


        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void phonesList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            Product p = (Product)phonesList.SelectedItem;
            Tires window = new Tires();
            window.Show();
        }
    }
}
