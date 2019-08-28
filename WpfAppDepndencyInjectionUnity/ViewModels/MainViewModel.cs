using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDepndencyInjectionUnity.Models;

namespace WpfAppDepndencyInjectionUnity.ViewModels
{
    public class MainViewModel
    {
        private readonly IPerson _person;

        public MainViewModel(IPerson person)
        {
            _person = person;
        }
    }
}
