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

namespace WPF_Canvas
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
            int value = Canvas.GetZIndex(btn1);
            if (value == 0)
                Canvas.SetZIndex(btn1, 1);
            else
                Canvas.SetZIndex(btn1, 0);
        }

        //Canvas ít sử dụng margin, thường dùng top, left, right, bottom để xác định tọa độ
        //Panel.ZIndex: để có thể nổi lên trên, lớn hơn được ưu tiên nằm trên
        //Canvas.SetZIndex(): set zindex trong code, 2 tham số: cho element nào và giá trị zindex

        //Canvas có thể vẽ được các hình ellipse, rectangle
    }
}
