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
using System.Windows.Shapes;

namespace Reg.Pages
{
    /// <summary>
    /// Interaction logic for Tires.xaml
    /// </summary>
    public partial class Tires : Window
    {
        public Tires()
        {
            InitializeComponent();
            DataContext = this;
            TiresPage.ItemsSource = SourceCore.MyBase.Product.ToList();
        }
    }
}
