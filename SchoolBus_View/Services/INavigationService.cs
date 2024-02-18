using GalaSoft.MvvmLight;

namespace SchoolBus_View.Services;

public interface INavigationService
{
    void NavigateTo<T>() where T : ViewModelBase;
}
