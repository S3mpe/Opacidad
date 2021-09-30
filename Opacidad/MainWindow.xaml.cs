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

namespace Opacidad
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

        private void PrimeraImagenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            PrimeraImagenImage.Opacity = 1;       
        }

        private void SegundaImagenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            SegundaImagenImage.Opacity = 1;
        }

        private void TerceraImagenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            TerceraImagenImage.Opacity = 1;
        }

        private void TerceraImagenImage_MouseLeave(object sender, MouseEventArgs e)
        {
            TerceraImagenImage.Opacity = 0.5;
        }

        private void SegundaImagenImage_MouseLeave(object sender, MouseEventArgs e)
        {
            SegundaImagenImage.Opacity = 0.5;
        }

        private void PrimeraImagenImage_MouseLeave(object sender, MouseEventArgs e)
        {
            PrimeraImagenImage.Opacity = 0.5;
        }
    }
}
