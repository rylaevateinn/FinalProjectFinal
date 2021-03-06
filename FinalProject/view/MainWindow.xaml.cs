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

namespace FinalProject.view
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

        private void menuKeranjang_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new view.KeranjangPage());
        }

        private void menuHome_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new view.HomePage());
        }

        private void menuHistory_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new view.HistoryPage());
        }

        private void menuSetting_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new view.SettingPage());
        }
    }
}
