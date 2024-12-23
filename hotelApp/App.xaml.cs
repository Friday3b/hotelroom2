using hotelApp.ViewModels;
using hotelApp.Views;
using SimpleInjector;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Navigation;
using System.Xaml;
using hotelApp.Services.Navigator;
namespace hotelApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application 
    {

        public static Container Container { get; set; } = new();
        public App()
        {
            AddOtherServices();
            AddViews();
            AddViewModels();
        }
        private static void AddOtherServices()
        {
            Container.RegisterSingleton<INavigateService, NavigatorService>();
        }

        private static void AddViewModels()
        {
            Container.RegisterSingleton<SelectConditionModel>();
            Container.RegisterSingleton<RoomPageModel>();
            Container.RegisterSingleton<MainPageModel>();

        }

        private static void AddViews()
        {

            Container.RegisterSingleton<mainPage>();
            Container.RegisterSingleton<SelectCondition>();
            Container.RegisterSingleton<RoomPage>();

        }

        protected override void OnStartup(StartupEventArgs e)
        {

            var mainView = Container.GetInstance<mainPage>();
            mainView.DataContext = Container.GetInstance<MainPageModel>();
            mainView.Show();
            base.OnStartup(e);
        }




    }

}
