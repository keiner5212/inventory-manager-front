using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inventory_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OPA(Object sender, RoutedEventArgs e)
        {
            contador++;
            Debug.WriteLine("Contador: ",contador);
            Contador.Content="Opa: "+contador;

        }
    }
}