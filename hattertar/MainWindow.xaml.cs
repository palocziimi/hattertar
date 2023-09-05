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

namespace hattertar
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

        private void btnEval_Click(object sender, RoutedEventArgs e)
        {
            long mennyiseg = Convert.ToInt64(kapac.Text);
            switch (kapaclist.SelectedIndex)
            {
                case 1:
                    mennyiseg *= 1000;
                    break;
                case 2:
                    mennyiseg *= 1000000;
                    break;
                default:
                    break;
            }

            long sebesseg = Convert.ToInt64(sliAtv.Value);
            switch (atvlist.SelectedIndex)
            {
                case 0:
                    sebesseg /= 8;
                    break;
                case 1:
                    sebesseg /= 1000;
                    break;
                case 3:
                    sebesseg *= 1000;
                    break;
                default:
                    break;
            }

            lblResult.Content = $"{Convert.ToDouble(mennyiseg)/sebesseg} sec";

        }

        private void sliAtv_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            aktVal.Content = sliAtv.Value;
            aktVal.Margin = new Thickness((sliAtv.Value-10)*0.0565, 0, 0, 0);
        }
    }
}
