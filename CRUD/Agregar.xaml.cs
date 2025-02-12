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

namespace CRUD
    {
    public partial class Agregar : UserControl
        {
        public Agregar()
            {
            InitializeComponent();
            }
        private void MinimizarClick(object sender, RoutedEventArgs e)
            {
                Window win1 = Window.GetWindow(this);
                win1.WindowState = WindowState.Minimized;
            }
        private void CerrarClick(object sender, RoutedEventArgs e)
            {
                Window win1 = Window.GetWindow(this);
                win1.Close();
            }
        }
    }
