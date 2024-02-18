using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus_View.ViewModels.EditViewModels;
using SchoolBus_View.Views;
using SchoolBus_View.Views.EditViews;
using SchoolBusData.Repos;
using SchoolBusData_Models.Derived;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace SchoolBus_View.ViewModels;

internal class CarViewModel : ViewModelBase
{
    readonly IRepository<Car> carRepo;


    public static ObservableCollection<Car>? Cars { get; set; } = new();


    public static Car? _SelectedCar;

    public Car? SelectedCar
    {
        get { return _SelectedCar; }
        set { Set(ref _SelectedCar, value); }
    }


    public CarViewModel(IRepository<Car> carRepo)
    {
        this.carRepo = carRepo;
        Cars = new ObservableCollection<Car>(this.carRepo.GetAll()!);
    }


    public static CarAddView? window;

    public static CarEditView? editWindow;



    public RelayCommand Update_Button
    {
        get => new(() =>
        {
            if (SelectedCar != null)
            {
                editWindow = new();
                editWindow.DataContext = new CarEditViewModel();
                editWindow.ShowDialog();
            }
        });
    }

    public RelayCommand Add_Button
    {
        get => new(() =>
        {
            window = new();
            window.DataContext = new CarAddViewModel();
            window.ShowDialog();
        });
    }

    public RelayCommand Delete_Button
    {
        get => new(() =>
        {
            try
            {
                if (SelectedCar != null)
                {
                    carRepo.Remove(SelectedCar!);

                    Cars!.Remove(SelectedCar!);

                    carRepo.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}
