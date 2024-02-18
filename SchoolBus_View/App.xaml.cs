using GalaSoft.MvvmLight.Messaging;
using SchoolBusData.Repos;
using SchoolBusData_Models.Derived;
using SchoolBus_View.Services;
using SchoolBus_View.ViewModels;
using SchoolBus_View.Views;
using SimpleInjector;
using System.Windows;


namespace SchoolBus_View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container? Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            Window window = new MainWindow();
            var viewModel = Container!.GetInstance<MainViewModel>();
            window.DataContext = viewModel;

            window.ShowDialog();

            base.OnStartup(e);
        }

        private void Register()
        {
            Container = new Container();

            Container.RegisterSingleton<INavigationService, NavigationService>();

            Container.RegisterSingleton<IMessenger, Messenger>();


            Container.RegisterSingleton<MainViewModel>();

            Container.RegisterSingleton<CarViewModel>();

            Container.RegisterSingleton<DriverViewModel>();

            Container.RegisterSingleton<ParentViewModel>();

            Container.RegisterSingleton<CreateRideViewModel>();

            Container.RegisterSingleton<ClassViewModel>();

            Container.RegisterSingleton<StudentViewModel>();

            Container.RegisterSingleton<RideViewModel>();

            //Container.RegisterSingleton<CarAddViewModel>();

            //add models



            Container.RegisterSingleton<IRepository<Car>, BaseRepository<Car>>();

            Container.RegisterSingleton<IRepository<Driver>, BaseRepository<Driver>>();

            Container.RegisterSingleton<IRepository<Class>, BaseRepository<Class>>();

            Container.RegisterSingleton<IRepository<Parent>, BaseRepository<Parent>>();

            Container.RegisterSingleton<IRepository<Student>, BaseRepository<Student>>();

            Container.RegisterSingleton<IRepository<Ride>, BaseRepository<Ride>>();




        }
    }
}
