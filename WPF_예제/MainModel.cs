using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_예제
{
    internal class MainModel : INotifyPropertyChanged
    {
        MainWindow main = null;

        public MainModel(MainWindow _main)
        {
            this.main = _main;
        }

        string textvalue;

        public string TextValue { get { return textvalue; } set { this.textvalue = value; OnPropertyChanged("TextValue"); } }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
