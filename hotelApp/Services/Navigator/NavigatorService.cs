using hotelApp.ViewModels;
using hotelApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace hotelApp.Services.Navigator
{
    public class NavigatorService :INavigateService
    {

        public void Navigate<TView, TViewModel>() where TView : Page where TViewModel : BaseViewModel
        {
            var mainVm = System.Windows.Application.Current.MainWindow.DataContext as MainPageModel;
            if (mainVm is not null)
            {
                mainVm!.CurrentPage = App.Container.GetInstance<TView>();
                mainVm.CurrentPage.DataContext = App.Container.GetInstance<TViewModel>();
            }
        }
    }
}
