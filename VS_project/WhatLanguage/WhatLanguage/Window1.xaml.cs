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

        /// <summary>
        /// Initializing Data
        /// </summary>
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
        int i = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //    var queryLanhIdChecker = (from b in context.Ide where b.id_lang == 2 && b.id == i select b);
            //while (queryLanhIdChecker != null)
            //{
            //    //if (ideViewSource.View.IsCurrentAfterLast)
            //    //{
            //    //    ideViewSource.View.MoveCurrentToFirst();
            //    //        i = 1;
            //    //    queryLanhIdChecker = (from b in context.Ide where b.id_lang == 2 && b.id == i select b);
            //    //    while (queryLanhIdChecker != null)
            //    //        {
            //    //        ideViewSource.View.MoveCurrentToNext();
            //    //        i++;

            //    //        }
            //    //}

            //    ideViewSource.View.MoveCurrentToNext();
            //    i++;
            //    queryLanhIdChecker = (from b in context.Ide where b.id_lang == 2 && b.id == i select b);
            //}


            ideViewSource.View.MoveCurrentToNext();
            if (ideViewSource.View.IsCurrentAfterLast == true)
                ideViewSource.View.MoveCurrentToFirst();


            frameworkViewSource.View.MoveCurrentToNext();
            if (frameworkViewSource.View.IsCurrentAfterLast == true)
                frameworkViewSource.View.MoveCurrentToFirst();
        }
    }
}
