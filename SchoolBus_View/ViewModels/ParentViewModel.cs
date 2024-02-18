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

internal class ParentViewModel : ViewModelBase
{
    readonly IRepository<Parent> parentRepo;

    public static ObservableCollection<Parent>? Parents { get; set; }


    public static Parent? selectedParent = new();

    public Parent? SelectedParent
    {
        get { return selectedParent; }
        set { Set(ref selectedParent, value); }
    }


    public ParentViewModel(IRepository<Parent> parentRepo)
    {
        this.parentRepo = parentRepo;
        Parents = new ObservableCollection<Parent>(this.parentRepo.GetAll()!);
    }


    public static ParentAddView? window;


    public static ParentEditView? editWindow;

    public RelayCommand Update_Button
    {
        get => new(() =>
        {
            if (selectedParent != null)
            {
                editWindow = new()
                {
                    DataContext = new ParentEditViewModel()
                };
                editWindow.ShowDialog();
            }
        });
    }

    public RelayCommand Add_Button
    {
        get => new(() =>
        {
            window = new()
            {
                DataContext = new ParentAddViewModel()
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
                parentRepo.Remove(SelectedParent!);

                Parents!.Remove(SelectedParent!);

                parentRepo.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}

