using System.Windows;
using System.Windows.Controls;
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

        private void opacidadRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = double.Parse((sender as RadioButton).Tag.ToString());
        }
        private void ajusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            switch((sender as RadioButton).Tag.ToString()){
                case "1":
                    imagenImage.Stretch = Stretch.Fill;
                    break;
                case "2":
                    imagenImage.Stretch = Stretch.Uniform;
                    break;
                case "3":
                    imagenImage.Stretch = Stretch.UniformToFill;
                    break;
                case "4":
                    imagenImage.Stretch = imagenImage.Stretch = Stretch.None;
                    break;
                default:
                    break;
            }
        }
    }
}
