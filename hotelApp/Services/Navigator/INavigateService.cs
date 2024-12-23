using hotelApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace hotelApp.Services.Navigator
{
    public interface INavigateService
    {

        void Navigate<TView, TViewModel>() where TView : Page where TViewModel : BaseViewModel;
    }
}
