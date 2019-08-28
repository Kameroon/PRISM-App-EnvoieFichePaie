using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleRalayCommand
{
    public class MainWindowViewModel
    {
        private ICommand hiButtonCommand;

        private ICommand toggleExecuteCommand { get; set; }

        private bool canExecute = true;               

        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                if (this.canExecute == value)
                {
                    return;
                }

                this.canExecute = value;
            }
        }

        public ICommand ToggleExecuteCommand
        {
            get
            {
                return toggleExecuteCommand ?? (
                       toggleExecuteCommand = new RelayCommand(ChangeCanExecute)
                    );
            }
            //set
            //{
            //    toggleExecuteCommand = value;
            //}
        }
        
        public ICommand HiButtonCommand
        {
            get
            {
                //return _command ?? (_command = new RelayCommand(
                //   x =>
                //   {
                //       ShowMessage(canExecute);
                //   }));

                return hiButtonCommand ?? (hiButtonCommand = new RelayCommand(
                        ShowMessage, param => this.canExecute
                    ));
            }
            set
            {
                hiButtonCommand = value;
            }
        }

        public MainWindowViewModel()
        {
            //HiButtonCommand = new RelayCommand(ShowMessage, param => this.canExecute);
            //toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        }

        public void ShowMessage(object obj)
        {
            System.Windows.MessageBox.Show(obj.ToString());
        }

        public void ChangeCanExecute(object obj)
        {
            canExecute = !canExecute;
            var val = obj;
        }
    }
}
