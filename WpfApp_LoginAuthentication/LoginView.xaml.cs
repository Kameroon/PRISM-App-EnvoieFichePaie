
namespace WpfApp_LoginAuthentication
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView 
    {
        public LoginView()
        {
            InitializeComponent();

            DataContext = new LoginViewModel();
        }
    }
}
