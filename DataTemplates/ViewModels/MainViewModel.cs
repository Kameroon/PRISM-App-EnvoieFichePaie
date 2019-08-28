using DataTemplates.Commands;
using DataTemplates.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplates.ViewModels
{
    public class MainViewModel
    {
        // -- https://www.softfluent.fr/blog/expertise/Les-DataTemplate-WPF-Partie2

        public List<object> Elements { get; set; }

        public MainViewModel()
        {
            #region --  --
            Elements = new List<object>();
            Elements.Add(new Square());
            Elements.Add(new Square());
            Elements.Add(new Square());
            Elements.Add(new Square());
            Elements.Add(new Circle());
            #endregion

            PopinCommand = new CommandBase(onPopin);

            Popins = new ObservableCollection<Object>();
        }

        #region --  --
        public PopinViewModel Popin { get; set; }

        public ObservableCollection<Object> Popins { get; set; }

        public CommandBase PopinCommand { get; set; }


        //private void onPopin(object obj)
        //{
        //    if (Popin == null)
        //    {
        //        Popin = new PopinViewModel();
        //        Popin.CloseHandler = ClosePopin;
        //        Notify("Popin");
        //    }
        //}

        //private void ClosePopin()
        //{
        //    Popin = null;
        //    Notify("Popin");
        //}

        private void onPopin(object obj)
        {
            var p = new PopinViewModel();
            p.CloseHandler = closePopin;
            p.OpenHandler = openHandler;
            Popins.Add(p);
        }

        private void openHandler()
        {
            var p = new Popin2ViewModel();
            p.CloseHandler = closePopin;
            Popins.Add(p);
        }

        private void closePopin()
        {
            if (Popins.Any())
                Popins.Remove(Popins.Last());
        }
        #endregion
    }
}
