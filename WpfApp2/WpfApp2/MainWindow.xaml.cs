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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string name = " ";
            string gioitinh = "";
            string ngoaingu = "";
            name = txtHodem.Text + " " + txtTen.Text;
            if (rNam.IsChecked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nu";
            if (chkEnglish.IsChecked == true)
                ngoaingu = "Tieng Anh";
            if (chkChingChong.IsChecked == true)
                ngoaingu = ngoaingu + "Chinh Chong";
            MessageBox.Show("HO Ten: " + name + "\n" + "gioi tinh: " + gioitinh + "\n" + "ngon ngu: " + ngoaingu);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtHodem.Text = " ";
            txtTen.Text = " ";
        }
    }
}
