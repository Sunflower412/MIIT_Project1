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

namespace wefrwefw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AimWindow window = new AimWindow();
            window.Title = "Цель и назначение";
            window.Show();
            this.Close();   
        }

        private void ButtonTasks_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow window = new TaskWindow();
            window.Title = "Решаемые задачи";
            window.Show();
            this.Close();
        }

        private void ButonHistory_Click(object sender, RoutedEventArgs e)
        {
            HistoryWindow window = new HistoryWindow();
            window.Title = "История развития";
            window.Show();
            this.Close();
        }

        private void ButtonArchitectory_Click(object sender, RoutedEventArgs e)
        {
            ArchitectoryWindow window = new ArchitectoryWindow();
            window.Title = "Архитектура и структура системы";
            window.Show();
            this.Close();
        }

        private void ButtonStack_Click(object sender, RoutedEventArgs e)
        {
            StackWindow window = new StackWindow();
            window.Title = "Используемые технические средства";
            window.Show();  
            this.Close();
        }

        private void ButtonCommunication_Click(object sender, RoutedEventArgs e)
        {
            CommunicationWindow window = new CommunicationWindow();
            window.Title = "Взаимодействия с внешними системами";
            window.Show();
            this.Close();
        }
    }
}
