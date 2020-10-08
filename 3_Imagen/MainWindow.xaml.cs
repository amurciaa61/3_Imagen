using System.Windows;
using System.Windows.Media;

namespace _3_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void altaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 1;
        }

        private void mediaRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.6;
        }

        private void bajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.3;
        }

        private void rellenoFillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Fill;
        }

        private void uniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.UniformToFill;
        }

        private void sinajusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.None;
        }
    }
}
