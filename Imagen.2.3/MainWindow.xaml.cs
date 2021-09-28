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

namespace Imagen._2._3
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

        private void OpacidadAltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            MuestraImage.Opacity = 1.0;
        }

        private void OpacidadMediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MuestraImage.Opacity = 0.5;
        }

        private void OpacidadBajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MuestraImage.Opacity = 0.2;
        }

        private void AjusteFillRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            MuestraImage.Stretch = Stretch.Fill;

        }
        private void AjusteUniformRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MuestraImage.Stretch = Stretch.Uniform;
        }

        private void AjusteUniformToTillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MuestraImage.Stretch = Stretch.UniformToFill;
        }

        private void AjusteNoneRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MuestraImage.Stretch = Stretch.None;
        }
    }
}
