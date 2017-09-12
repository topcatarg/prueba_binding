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

namespace ejemplo_binding
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private datos Personas;

        public MainWindow()
        {
            InitializeComponent();
            Personas = new datos();
            DatosPuros dp = new DatosPuros();
            dp.nombre = "segundo";
            dp.edad = 23;
            dp.altura = 167;
            Personas.ColeccionDatos.Add(dp);
            dp = new DatosPuros();
            dp.nombre = "tercero";
            dp.edad = 29;
            dp.altura = 176;
            Personas.ColeccionDatos.Add(dp);
            dp = new DatosPuros();
            dp.nombre = "cuarto";
            dp.edad = 34;
            dp.altura = 201;
            Personas.ColeccionDatos.Add(dp);
            dataGrid.ItemsSource = Personas.ColeccionDatos;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ventanadatos vd = new ventanadatos();
            vd.LlenarDatos((DatosPuros) dataGrid.SelectedItem);
            vd.ShowDialog();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(dataGrid.SelectedItem.ToString());
        }
    }
}
