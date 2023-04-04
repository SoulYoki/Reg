using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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



namespace Reg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public static  Base.User User ;
        private Base.Product BTOV;
        private int Users = 2;
        public  MainWindow( int userID)
        {
            InitializeComponent();
            FIO();    
            DataContext = this;           
            phonesList.ItemsSource = SourceCore.MyBase.Product.ToList();
            if (userID != 1)
            {
                DocFunct.Visibility = Visibility.Hidden;
            }
            if (userID == 10)
            {
                FIOSlabel.Content += "Гость";
            }
            else
            {
                Base.User newUser = SourceCore.MyBase.User.SingleOrDefault(Q => Q.UserID == Users);
            }
            UpdateList(null);


        }
        private void SelectAuthWindow()
        {
            auto window = new auto();
            window.Show();
            Close();
        }
        private void FIO()
        {
            string fios = "Гость";
            fios = User.UserName + " " + User.UserSurname + " " + User.UserPatronymic + " ";
            FIOSlabel.Content = " Вы вошли : " + fios;
        }
        public void UpdateList(Base.Product Product)
        {
            if ((Product == null) && (phonesList.ItemsSource != null))
            {
                Product = (Base.Product)phonesList.SelectedItem;
            }

            ObservableCollection<Base.Product> Products =
            new ObservableCollection<Base.Product>(SourceCore.MyBase.Product.ToList());
           phonesList.ItemsSource = Products;
            phonesList.SelectedItem = Product;
        }

       

        private void phonesList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddTov_Click(object sender, RoutedEventArgs e)
        {
            AddTovar newWindow = new AddTovar(this);
            newWindow.ShowDialog();
        }

        private void DeleteTov_Click(object sender, RoutedEventArgs e)
        {
            BTOV = (Base.Product)phonesList.SelectedItem;
            if (MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                try
                {
                    SourceCore.MyBase.Product.Remove((Base.Product)phonesList.SelectedItem);
                    SourceCore.MyBase.SaveChanges();
                    UpdateList(null);
                }
                catch
                {
                    MessageBox.Show("Вы не можете удалить используемый товар!");
                }
            }
        }

        private void RedTov_Click(object sender, RoutedEventArgs e)
        {
            BTOV= (Base.Product)phonesList.SelectedItem;
           Redactorxaml newWindow = new Redactorxaml(BTOV, this);
            newWindow.ShowDialog();
        }

        private void Closes_Click(object sender, RoutedEventArgs e)
        {
            auto window = new auto();
            window.Show();
            Close();
        }
    }
    }

