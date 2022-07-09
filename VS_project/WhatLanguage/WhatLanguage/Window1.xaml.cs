﻿using System;
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
        public Window1()
        {
            InitializeComponent();
            frameworkViewSource = (frameworkViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frameworkViewSource"))));
            DataContext = this;
        }
        private void BackToMain(object sender, RoutedEventArgs e)
        {
            MainWindow objMW = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMW.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.Framework.Load();
            frameworkViewSource.Source = context.Framework.Local;
            //System.Windows.Data.CollectionViewSource frameworkViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frameworkViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // frameworkViewSource.Source = [generic data source]
        }
    }
}
