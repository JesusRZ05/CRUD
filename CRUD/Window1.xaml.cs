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
using System.Windows.Shapes;

namespace CRUD
    {
    public partial class Window1 : Window
        {
        public Window1()
            {
            InitializeComponent();
            }
        private void Inicio_Click(object sender, RoutedEventArgs e)
            {
            MainFrame.Navigate(new Inicio());
            }

        private void Agregar_Click(object sender, RoutedEventArgs e)
            {
            MainFrame.Navigate(new Agregar());
            }

        private void Modificar_Click(object sender, RoutedEventArgs e)
            {
            MainFrame.Navigate(new Modificar());
            }

        private void Borrar_Click(object sender, RoutedEventArgs e)
            {
            MainFrame.Navigate(new Borrar());
            }
        }
    }
