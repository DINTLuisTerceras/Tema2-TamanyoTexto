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

namespace UD2_ej7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                mediumRadioButton.IsChecked = true;
        }

        private void sizesRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            String a = (sender as RadioButton).Tag.ToString();
            titleTextBlock.FontSize = double.Parse(a);
        }
    }
}
