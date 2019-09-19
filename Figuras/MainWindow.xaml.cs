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

namespace Figuras
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

        private void CalcularR_Click(object sender, RoutedEventArgs e)
        {
            {
                double numero1 =
                    double.Parse(BaseR.Text);
                double numero2 =
                    double.Parse(AlturaR.Text);
                double resulatado =
                    numero1 * numero2;
                ResR.Text = resulatado.ToString();
            }

        }

        private void CalcularT_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                    double.Parse(BaseT.Text);
            double numero2 =
                double.Parse(AlturaT.Text);
            double resulatado =
                numero1 * numero2 / 2;
            ResT.Text = resulatado.ToString();

        }

        private void CalcularC_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                double.Parse(Radio.Text);
            double resulatado =
                numero1 * numero1 * 3.1416;
            ResC.Text = resulatado.ToString();

        }

        private void CalcularTrap_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                   double.Parse(BaseMa.Text);
            double numero2 =
                double.Parse(BaseMe.Text);
            double numero3 =
                double.Parse(AlturaTrap.Text);
            double resulatado =
                ((numero1+numero2)*numero3)/2;
            ResTrap.Text = resulatado.ToString();


        }
    }
}
