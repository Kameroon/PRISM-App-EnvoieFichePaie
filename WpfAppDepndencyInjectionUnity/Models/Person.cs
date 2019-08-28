using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDepndencyInjectionUnity.Models
{
    public class Person : IPerson
    {
        public Person()
        {
            Text = "Hello";
        }

        public string Text { get; set; }

    }
}
