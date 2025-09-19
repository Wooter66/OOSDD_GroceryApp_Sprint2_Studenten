using Grocery.App.ViewModels;
using Grocery.App.Views;

namespace Grocery.App
{
    public partial class App : Application
    {
        public App(LoginViewModel viewModel)
        {
            InitializeComponent();

            // MainPage = new AppShell(); // AppShell tijdelijk uitgeschakeld
            MainPage = new LoginView(viewModel); // LoginView gebruiken
        }
    }
}
