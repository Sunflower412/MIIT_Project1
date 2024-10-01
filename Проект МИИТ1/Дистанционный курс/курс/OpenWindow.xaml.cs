using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для OpenWindow.xaml
    /// </summary>
    public partial class OpenWindow : Window
    {
        public OpenWindow()
        {
            InitializeComponent();
        }
        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            window.Title = "ЭТО ОКНО НАЧАЛО КУРСА";
            this.Close();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
