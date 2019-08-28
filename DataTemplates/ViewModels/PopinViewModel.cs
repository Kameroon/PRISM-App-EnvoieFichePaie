using DataTemplates.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplates.ViewModels
{
    public class PopinViewModel : BaseViewModel
    {
        public CommandBase QuitCommand { get; set; }

        public CommandBase OpenCommand { get; set; }

        public Action CloseHandler { get; set; }

        public Action OpenHandler { get; set; }

        public PopinViewModel()
        {
            QuitCommand = new CommandBase(onQuit);
            OpenCommand = new CommandBase(onOpen);
        }

        private void onOpen(object obj)
        {
            if (OpenHandler != null)
                OpenHandler();
        }

        private void onQuit(object obj)
        {
            if (CloseHandler != null)
                CloseHandler();
        }
    }
}