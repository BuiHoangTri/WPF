using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_TextBlock_Inlines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // phải ép kiểu t
            // var range = new TextRange(txbl1.Inlines.ElementAt(0).ContentStart, txbl1.Inlines.ElementAt(0).ContentEnd);
            // txbl2.Text = range.Text;

            // phải biết kiểu dữ liệu của mỗi element
            // lấy từng phần tử và phải ép kiểu đúng, xử lí khá phiền
            // var a = (Hyperlink)txbl1.Inlines.ElementAt(0);

            // Property: TextTrimming -> tạo dấu 3 chấm ở cuối nếu văn bản dài
            // Property: TextWrapping -> bao văn bản

            // tạo inline text ngay trong code
            txbl3.Inlines.Add(new Run("www.google.com") { FontSize = 30 });
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.ToString());
        }
    }
}
