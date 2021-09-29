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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int i = 3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            i += 1;
            cb_selection.Items.Add($"Test{i}");
        }

        private void btn_Show_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (string) cb_selection.SelectedItem;
            MessageBox.Show($"Your Selection is: {selectedItem}");
        }

        private void cb_selection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e.AddedItems[0];
            if(selectedItem != null)
            {
                MessageBox.Show($"Your Selection is: {selectedItem}");
            }
        }
    }
}
