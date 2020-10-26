using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Ejercicio5_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            colorAzul.IsChecked = true;
        }

        private void TextoNegrita_Checked(object sender, RoutedEventArgs e)
        {
            if (textoNegrita.IsChecked == true)
                textoDefinitivo.FontWeight = FontWeights.Bold;
            else
                textoDefinitivo.FontWeight = FontWeights.Normal;
        }

        private void TextoCursiva_Checked(object sender, RoutedEventArgs e)
        {
            if (textoCursiva.IsChecked == true)
                textoDefinitivo.FontStyle = FontStyles.Italic;
            else
                textoDefinitivo.FontStyle = FontStyles.Normal;
        }

        private void ColorAzul_Checked(object sender, RoutedEventArgs e)
        {
            textoDefinitivo.Foreground = Brushes.Blue;
        }

        private void ColorRojo_Checked(object sender, RoutedEventArgs e)
        {
            textoDefinitivo.Foreground = Brushes.Red;
        }

        private void ColorVerde_Checked(object sender, RoutedEventArgs e)
        {
            textoDefinitivo.Foreground = Brushes.Green;
        }

        private void CuadroTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoDefinitivo.Text = cuadroTexto.Text;
        }
    }
}
