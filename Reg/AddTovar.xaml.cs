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
    /// Interaction logic for AddTovar.xaml
    /// </summary>
    public partial class AddTovar : Window
    {

        private MainWindow mainWindow;
      
        public AddTovar(MainWindow mainWWindow)
        {
            InitializeComponent();
            DataContext = this;
            mainWindow = mainWWindow;
        }

        private void addProd_Click(object sender, RoutedEventArgs e)
        {
            var newProd = new Base.Product();
            newProd.ProductArticleNumber = article.Text;
            newProd.ProductName = name.Text;
            newProd.ProductDescription = description.Text;
            newProd.ProductCategory = category.Text;
            newProd.ProductManufacturer = manufacturer.Text;
            newProd.ProductCost = Convert.ToDecimal(cost.Text);
            newProd.ProductQuantityInStock = Convert.ToByte(amount.Text);
            newProd.ProductStatus = status.Text;
            SourceCore.MyBase.Product.Add(newProd);
            SourceCore.MyBase.SaveChanges();
            mainWindow.UpdateList(null);
            mainWindow.phonesList.SelectedItem = newProd;
            mainWindow.phonesList.UpdateLayout();
            mainWindow.phonesList.ScrollIntoView(mainWindow.phonesList.SelectedItem);
            Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
