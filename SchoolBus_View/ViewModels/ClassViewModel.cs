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

internal class ClassViewModel : ViewModelBase
{
    readonly IRepository<Class> classRepo;

    public static ObservableCollection<Class>? Classes { get; set; }


    public static Class? selectedClass;

    public Class? SelectedClass
    {
        get { return selectedClass; }
        set { Set(ref selectedClass, value); }
    }


    public ClassViewModel(IRepository<Class> classRepo)
    {
        this.classRepo = classRepo;
        Classes = new ObservableCollection<Class>(this.classRepo.GetAll()!);
    }

    public static ClassAddView? window;

    public static ClassEditView? EditWindow;

    public RelayCommand Update_Button
    {
        get => new(() =>
        {
            if (selectedClass != null)
            {
                EditWindow = new()
                {
                    DataContext = new ClassEditViewModel()
                };
                EditWindow.ShowDialog();
            }
        });
    }

    public RelayCommand Add_Button
    {
        get => new(() =>
        {
            window = new()
            {
                DataContext = new ClassAddViewModel()
            };
            window.ShowDialog();
        });
    }

    public RelayCommand Delete_Button
    {
        get => new(() =>
        {
            try
            {
                classRepo.Remove(SelectedClass!);

                Classes!.Remove(SelectedClass!);

                classRepo.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}