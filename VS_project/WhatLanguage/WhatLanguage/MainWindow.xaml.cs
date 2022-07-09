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

            // Load data by setting the CollectionViewSource.Source property:
            // langViewSource1.Source = [generic data source]
        }
    }
}
