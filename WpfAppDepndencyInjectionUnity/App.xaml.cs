using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using WpfAppDepndencyInjectionUnity.Models;
//using Microsoft.Practices.Unity
using WpfAppDepndencyInjectionUnity.ViewModels;
using WpfAppDepndencyInjectionUnity.Views;

namespace WpfAppDepndencyInjectionUnity
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPerson, Person>();

            var mainViewModel = container.Resolve<MainViewModel>();
            var window = new MainWindow
            {
                DataContext = mainViewModel
            };
            window.Show();
        }
    }
}
