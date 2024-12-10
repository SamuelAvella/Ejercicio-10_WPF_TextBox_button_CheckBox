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

namespace Ejercicio5
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

        private void cb_TodosHaCambiado(object sender, RoutedEventArgs e)
        {
            bool nuevoValor = (cbTodos.IsChecked == true);

            cbDI.IsChecked = nuevoValor;
            cbSGE.IsChecked = nuevoValor;
            cbAD.IsChecked = nuevoValor;
        }
        private void cb_SimpleHaCambiado(object sender, RoutedEventArgs e)
        {
            cbTodos.IsChecked = null;
            if ((cbDI.IsChecked == true) && (cbSGE.IsChecked == true) && (cbAD.IsChecked == true))
            {
                cbTodos.IsChecked = true;
            }
            else if ((cbDI.IsChecked == false) && (cbSGE.IsChecked == false) && (cbAD.IsChecked == false))
            {
                cbTodos.IsChecked = false;
            }

        }
        }
    }
