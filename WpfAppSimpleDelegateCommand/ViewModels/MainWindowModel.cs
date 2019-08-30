using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppSimpleDelegateCommand.Commands;

namespace WpfAppSimpleDelegateCommand.ViewModels
{
    public class MainWindowModel
    {
        public DelegateCommand TestCmd { get; set; }
        public DelegateCommand TestCmd2 { get; set; }


        public MainWindowModel()
        {
            // --  Show send mail form command  --            
            TestCmd = new DelegateCommand(x => TestMethod());

            TestCmd2 = new DelegateCommand(x => TestMethod2());
        }

        private void TestMethod()
        {
            
        }

        private void TestMethod2()
        {

        }
    }
}
