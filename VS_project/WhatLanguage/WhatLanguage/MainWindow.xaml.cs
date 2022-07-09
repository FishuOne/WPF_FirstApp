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
using System.Data.Entity;

namespace WhatLanguage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OOProjectEntities context = new OOProjectEntities();
        CollectionViewSource langViewSource;
        /// <summary>
        /// Initializing Data
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            langViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("langViewSource1")));
            DataContext = this;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.Lang.Load();
            langViewSource.Source = context.Lang.Local;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void OpenWindow1(object sender, RoutedEventArgs e)
        {

            Window1 objWin1 = new Window1();
            this.Visibility = Visibility.Hidden;
            objWin1.Show();
        }

        private void OpenWindow2(object sender, RoutedEventArgs e)
        {
            Window2 objWin2 = new Window2();
            this.Visibility = Visibility.Hidden;
            objWin2.Show();
        }
    }
}
