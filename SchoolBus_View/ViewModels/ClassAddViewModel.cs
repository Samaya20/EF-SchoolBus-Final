using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusData.Repos;
using SchoolBusData_Models.Derived;
using System;
using System.Windows;

namespace SchoolBus_View.ViewModels;

internal class ClassAddViewModel : ViewModelBase
{
    readonly IRepository<Class>? classRepo = new BaseRepository<Class>();


    Class? newClass = new();

    public Class? NewClass
    {
        get { return newClass; }
        set { Set(ref newClass, value); }
    }


    public RelayCommand Add_Button
    {
        get => new(() =>
        {
            try
            {
                ClassViewModel.Classes!.Add(NewClass!);

                classRepo!.Add(NewClass!);

                classRepo.SaveChanges();

                ClassViewModel.window!.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}
