using hotelApp.Command;
using hotelApp.Services.Navigator;
using hotelApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace hotelApp.ViewModels
{
    public class SelectConditionModel :BaseViewModel
    {
        public RelayCommand GetRoomCommand { get; set; }

        private readonly INavigateService _navigationServices;



        public SelectConditionModel(INavigateService navigationServices)
        {
            _navigationServices = navigationServices;
            GetRoomCommand = new RelayCommand(GetRoom);
            
        }

        private void GetRoom(object? obj)
        {
            _navigationServices.Navigate<RoomPage, RoomPageModel>(); 


        }
    }
}
