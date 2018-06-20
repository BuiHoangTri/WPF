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

namespace WPF_DockPanel
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

        //Grid: các trường hợp bth, các control nằm đè lên nhau
        //StackPanel: các control nằm theo 1 hướng nào đó
        //WrapPanel: cũng nằm théo 1 hướng nào đó nhưng khi không đủ chỗ sẽ tự động nhảy xuống
        //DockPanel: khi muốn các control dock (neo) theo 1 hướng nào đó
    }
}
