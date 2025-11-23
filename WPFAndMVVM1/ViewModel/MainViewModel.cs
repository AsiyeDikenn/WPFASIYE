using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFAndMVVM1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private string _myLabelText = "Text not set yet";
        public string MyLabelText
        {
            get => _myLabelText;
            set
            {
                if (_myLabelText == value) return;
                _myLabelText = value;
                OnPropertyChanged(nameof(MyLabelText));
            }
        }

        private string _myTextBoxText = "Text not set yet";
        public string MyTextBoxText
        {
            get => _myTextBoxText;
            set
            {
                if (_myTextBoxText == value) return;
                _myTextBoxText = value;
                OnPropertyChanged(nameof(MyTextBoxText));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)

        {

            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;

            if (propertyChanged != null)

            {

                propertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }

        }

    }
}
