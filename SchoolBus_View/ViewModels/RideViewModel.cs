using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusData.Repos;
using SchoolBusData_Models.Derived;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace SchoolBus_View.ViewModels;

internal class RideViewModel : ViewModelBase
{
    readonly IRepository<Ride> rideRepo = new BaseRepository<Ride>();

    readonly IRepository<Car> carRepo = new BaseRepository<Car>();

    readonly IRepository<Driver> driverRepo = new BaseRepository<Driver>();


    Ride? selectedRide = new();

    public Ride? SelectedRide
    {
        get { return selectedRide; }
        set { Set(ref selectedRide, value); }
    }


    public static ObservableCollection<Ride>? rides = new();

    public ObservableCollection<Ride>? Rides
    {
        get { return rides; }
        set { Set(ref rides, value); }
    }


    public void GetStudentsWithCarAndDriver()
    {
        List<Ride> rideList = rideRepo.GetAll()!.ToList();

        Rides = new();

        foreach (var ride in rideList)
        {
            ride.Driver = driverRepo.Get(ride.DriverId!.Value);
            ride.Car = carRepo.Get(ride.CarId);
            Rides!.Add(ride);
        }
    }

    public RideViewModel(IRepository<Ride> rideRepo)
    {
        this.rideRepo = rideRepo;
        Rides = new ObservableCollection<Ride>(this.rideRepo.GetAll()!);

        GetStudentsWithCarAndDriver();
    }

    public RelayCommand Delete_Button
    {
        get => new(() =>
        {
            try
            {
                rideRepo.Remove(SelectedRide!);

                Rides!.Remove(SelectedRide!);

                rideRepo.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}

