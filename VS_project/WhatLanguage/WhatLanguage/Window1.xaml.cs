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
using System.Data.Entity;

namespace WhatLanguage
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        OOProjectEntities context = new OOProjectEntities();
        CollectionViewSource frameworkViewSource;
        CollectionViewSource ideViewSource;
        public Window1()
        {
            InitializeComponent();
            frameworkViewSource = (frameworkViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frameworkViewSource"))));
            ideViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ideViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.Framework.Load();
            context.Ide.Load();
            frameworkViewSource.Source = context.Framework.Local;
            ideViewSource.Source = context.Ide.Local;
        }
        private void BackToMain(object sender, RoutedEventArgs e)
        {
            MainWindow objMW = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMW.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // var queryLangID = (from c in context.Tech where c.id_lang == 1 select c);
           // if (queryLangID != null)

                ideViewSource.View.MoveCurrentToNext();



                frameworkViewSource.View.MoveCurrentToNext();
        }
    }
}
