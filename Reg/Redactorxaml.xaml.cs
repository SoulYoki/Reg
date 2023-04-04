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
    /// Interaction logic for Redactorxaml.xaml
    /// </summary>
    public partial class Redactorxaml : Window
        
    {
        private MainWindow mainWindow;
        private Base.Product REDPd;
        private Base.tovarEntities DataBase;
        public Redactorxaml( Base.Product redPD, MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = this;
            REDPd = redPD;
            DataBase = new Base.tovarEntities();
            loadInfo();
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
        public void loadInfo()
        {
            Base.Product setProduct = DataBase.Product.SingleOrDefault(U => U.ProductArticleNumber == REDPd.ProductArticleNumber);
            article.Text = setProduct.ProductArticleNumber;
            name.Text = setProduct.ProductName;
            description.Text = setProduct.ProductDescription;
            category.Text = setProduct.ProductCategory;
            manufacturer.Text = setProduct.ProductManufacturer;
            cost.Text = setProduct.ProductCost.ToString();
            amount.Text = setProduct.ProductQuantityInStock.ToString();
            status.Text = setProduct.ProductStatus;
        }
    }
    }

