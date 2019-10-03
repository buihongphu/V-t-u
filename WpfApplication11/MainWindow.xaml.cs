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

namespace WpfApplication11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but_Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void typeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedType = (lbx_quoctich.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
                case "Viet Nam":
                 break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ten:" + txt_ten.Text + "\nSodt :" + txt_dt.Text) ;
        }

       

 
    }
}
