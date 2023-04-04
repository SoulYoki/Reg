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

namespace Reg
{
    /// <summary>
    /// Interaction logic for GhostWin.xaml
    /// </summary>
    public partial class GhostWin : Window
    {
        public GhostWin()
        {
           auto window = new auto();
            window.Show();
            InitializeComponent();
        }
        private void phonesList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
