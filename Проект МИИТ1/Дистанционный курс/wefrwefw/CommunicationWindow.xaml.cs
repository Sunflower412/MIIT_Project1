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

namespace wefrwefw
{
    /// <summary>
    /// Логика взаимодействия для CommunicationWindow.xaml
    /// </summary>
    public partial class CommunicationWindow : Window
    {
        public CommunicationWindow()
        {
            InitializeComponent();
        }

     

        private void ButtonBack5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
