using System.ComponentModel;

namespace DataBindingInGauge
{
    public class ValueViewModel : INotifyPropertyChanged
    {
        private double _value = 60;
        public double Value
        {
            get { return _value; }
            set { _value = value; Notifypropertychanged("Value"); }
        }

        // Creating event handler.
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// To notify while property get changed.
        /// </summary>
        /// <param name="propertyname">The property name</param>
        private void Notifypropertychanged(string propertyname)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
