
using FlowerShop.Pages.Clients;
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

namespace FlowerShop
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(bool isAdmin)
        {
            InitializeComponent();
            IsAdmin = isAdmin;
            Nav.MainFrame = MainFrame;
        }
        public bool IsAdmin;
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsAdmin)
            {
                int index = ListViewMenuAdmin.SelectedIndex;
                MoveCursorMenu(index);

                switch (index)
                {
                    case 0:
                        Go(new MainClientPage());
                        break;
                    case 1:
                        Go(new AddEditClientPage());
                        break;
                    default:
                        break;
                }
            }
            else
            {
                
            }
            
        }
        private void Go(Page p)
        {
            MainFrame.Navigate(p);
        }
        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }
    }
}
