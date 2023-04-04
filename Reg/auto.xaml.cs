﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for auto.xaml
    /// </summary>
    /// 
  
    public partial class auto : Window
    {
        //private Base.tovarEntities DataBase;
        private bool CaptchaFlag = true;
        private int i = 0;
        private readonly object _userActivityLocker = new object();
        public auto()
        {
            InitializeComponent();
            //try
            //{
            //    DataBase = new Base.tovarEntities();
            //}
            //catch
            //{
            //    MessageBox.Show("НЕ получилось");
            //}
        }

      

        private void GenerateCP()
        {
            String allowchar = " ";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            //разделитель
            char[] a = { ',' };
            //расщепление массива по разделителю
            String[] ar = allowchar.Split(a);
            String pwd = " ";
            string temp = " ";
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }
            CaptchaTextBox.Text = pwd;
        }
        private void SelectGhostWin()
        {
          GhostWin window = new GhostWin();
            window.Show();
            Close();
        }
        private void GuestButton_Click(object sender, RoutedEventArgs e)
        {
          SelectGhostWin();
        }
        private bool CheckCAPTCHA(bool captcha)
        {
            if ((CaptchaCheckTextBox.Text == CaptchaTextBox.Text) && (CaptchaTextBox.Text != ""))
            {
                captcha = true;
                return captcha;
            }
            else
            {
                captcha = false;
                return captcha;
            }
        }
  
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Base.User User = SourceCore.MyBase.User.SingleOrDefault(U => U.UserLogin == LoginTB.Text && U.UserPassword == PasswordTB.Text);
            if (User != null)
            {
                if (CheckCAPTCHA(CaptchaFlag) || i == 0)
                {
                    MainWindow.User = User;
                    MainWindow window = new MainWindow(User.UserRole);
                    window.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("CAPTCHA не введена, либо введена неверно! \n Вход заблокирован на 10 секунд!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    AutorizationDataSP.IsEnabled = false;
                    ButtonsSP.IsEnabled = false;
                    if (System.Threading.Monitor.TryEnter(_userActivityLocker))
                    {
                        //note that any sub clicks will be ignored while we are here
                        try
                        {
                            DateTime dt = DateTime.Now;
                            Thread.Sleep(2000);
                            Debug.Print("FirstClick {0} Second Click {1}", dt.ToLongTimeString(), DateTime.Now.ToLongTimeString());
                            //here it is safe to call the save and you can disable the btn

                        }
                        finally
                        {
                            System.Threading.Monitor.Exit(_userActivityLocker);
                            //re-enable the btn if you disable it.
                            AutorizationDataSP.IsEnabled = true;
                            ButtonsSP.IsEnabled = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверно указан логин и/или пароль!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                CaptchaDP.Visibility = Visibility.Visible;
                i++;
               GenerateCP();
            }
        }
    }
    }

