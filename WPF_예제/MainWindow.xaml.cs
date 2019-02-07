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

namespace WPF_예제
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(this);
            Init();
        }

        private void Init()
        {
            ((MainViewModel)this.DataContext).Model.TextValue = "버튼을 클릭하세요.";
        }

        private void Btna_Click(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)this.DataContext).btnA_Click();
        }

        private void Btnb_Click(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)this.DataContext).btnB_Click();
        }
    }
}
