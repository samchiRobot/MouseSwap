using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace MouseSwap
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int nBtnPriority = 0;
        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);

        public MainWindow()
        {
            InitializeComponent();
            SwapMouseButton(0);
        }

        private void BtnSwap_Click(object sender, RoutedEventArgs e)
        {
            ++nBtnPriority;
            nBtnPriority %= 2;
            SwapMouseButton(nBtnPriority);
            if(nBtnPriority%2==0)
                BtnSwap.Content = "Left";
            else
                BtnSwap.Content = "Right";

        }
    }
}
