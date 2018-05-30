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

namespace WPF_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Button btn = new Button();
            //btn.Content = "www.google.com";
            //grd.Children.Add(btn);

            //TextBlock txbl = new TextBlock();
            //txbl.Text = "Free Education";
            //btn.Content = txbl; // -> textblock sẽ nằm trong button, content chỉ chấp nhận 1 element

            //TextBox txb = new TextBox();
            //txb.Width = 100;
            //txb.Height = 50;
            //btn.Content = txb;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("おはようございます。");
        }
    }
}
