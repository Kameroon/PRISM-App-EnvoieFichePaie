using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_LoginAuthentication.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        public ViewModelBase()
        {

        }
        

        #region INotifyPropertyChanged Methods

        public void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, args);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
