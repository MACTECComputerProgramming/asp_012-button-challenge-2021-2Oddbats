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

namespace Button_Challenge_2021
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

        private void buttonAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonPen.IsChecked == true)
            {
                labelResponse.Content = "Pen. Unerasable, but useful.";
            }

            else if (radioButtonPencil.IsChecked == true)

            {
                labelResponse.Content = "Pencil. A classic.";
            }
            else if (radioButtonPhone.IsChecked == true)
            {
                labelResponse.Content = "Phone. Of course...";
            }
            else if (radioButtonTablet.IsChecked == true)
            {
                labelResponse.Content = "Tablet? Do people really use those?";
            }
            else
            {
                labelResponse.Content = "CHOOSE ONE!!";
            }
        }
    } 
}
