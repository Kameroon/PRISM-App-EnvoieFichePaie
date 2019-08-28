using DataTemplates.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplates.ViewModels
{
    public class Popin2ViewModel
    {
        public CommandBase QuitCommand { get; set; }

        public Action CloseHandler { get; set; }

        public Popin2ViewModel()
        {
            QuitCommand = new CommandBase(onQuit);
        }

        private void onQuit(object obj)
        {
            if (CloseHandler != null)
                CloseHandler();
        }
    }
}
