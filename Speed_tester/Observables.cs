using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_tester
{
    class ChangeNotifier<T>: INotifyPropertyChanged
    {
        private T _observedProperty;
        public T observedProperty
        {
            get
            {
                return _observedProperty;
            }
            set
            {
                if (!value.Equals(_observedProperty))
                {
                    _observedProperty = value;
                    NotifyPropertyChanged("ObservedProperty");
                }
            }
        }
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
    class Subscriber<T>
    {
        public static TextBox txtbox;
        private ChangeNotifier<T> _changeNotifier;
        public void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ObservedProperty":
                    txtboxUpdate(_changeNotifier.observedProperty);
                    break;

            }
            
        }
        private void txtboxUpdate(T value)
        {
            
        }
    }
}
