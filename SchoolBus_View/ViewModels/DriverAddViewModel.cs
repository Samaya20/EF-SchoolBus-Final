using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusData.Repos;
using SchoolBusData_Models.Derived;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace SchoolBus_View.ViewModels;

internal class DriverAddViewModel : ViewModelBase
{
    readonly IRepository<Driver>? driverRepo = new BaseRepository<Driver>();

    readonly IRepository<Car>? carRepo = new BaseRepository<Car>();


    Driver? newDriver = new();

    public Driver? NewDriver
    {
        get { return newDriver; }
        set { Set(ref newDriver, value); }
    }


    Car? selectedCar;

    public Car? SelectedCar
    {
        get { return selectedCar; }
        set { Set(ref selectedCar, value); }
    }


    ObservableCollection<Car>? carListboxSource = new();

    public ObservableCollection<Car>? CarListboxSource
    {
        get { return carListboxSource; }
        set { Set(ref carListboxSource, value); }
    }


    public DriverAddViewModel()
    {

        var drivers = driverRepo.GetAll();
        var cars = carRepo.GetAll();

        var carsWithoutDriver = cars!.Where(c => drivers!.All(d => d.CarId != c.Id));

        foreach (var item in carsWithoutDriver)
        {
            carListboxSource.Add(item);
        }
    }

    public RelayCommand Add_Button
    {
        get => new(() =>
        {
            try
            {
                NewDriver!.CarId = SelectedCar!.Id;

                if (SelectedCar != null)
                {
                    DriverViewModel.Drivers!.Add(newDriver!);

                    driverRepo!.Add(newDriver!);

                    driverRepo.SaveChanges();

                    DriverViewModel.window!.Close();

                }
                else MessageBox.Show("Choose Car!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}
