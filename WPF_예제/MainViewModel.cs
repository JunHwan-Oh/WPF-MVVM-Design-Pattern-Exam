using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_예제
{
    internal class MainViewModel
    {
        MainWindow main = null;
        MainModel model = null;

        public MainModel Model { get { return model; } }

        public MainViewModel(MainWindow _main)
        {
            this.main = _main;
            model = new MainModel(this.main);
        }

        internal void btnA_Click()
        {
            Model.TextValue = "A 버튼이 클릭되었습니다.";

            // 이곳에 버튼에 대한 추가적인 명령을 입력합니다.

        }

        internal void btnB_Click()
        {
            Model.TextValue = "B 버튼이 클릭되었습니다.";

            // 이곳에 버튼에 대한 추가적인 명령을 입력합니다.

        }
    }
}
