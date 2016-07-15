using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight;

namespace DependencyInjectionMVVMSample
{
    public class ServiceLocator
    {
        static SimpleIoc Manager = SimpleIoc.Default;
        static ServiceLocator()
        {
            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(() => Manager);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Fake data to use in Design Mode
                Manager.Register<IContactService>(() => new FakeContactService());
            }
            else
            {
                // Register the real data source, can be from database, remote server ....
                Manager.Register<IContactService>(() => new ContactService());
                //Manager.Register<IContactService>(() => new LocalDatabaseContactService());
            }

            Manager.Register<IMainViewModel>(() => new MainViewModel(
                GetInstance<IContactService>()
            ));

        }

        public static IMainViewModel MainVM
        {
            get
            {
                return GetInstance<IMainViewModel>();
            }
        }

        public static T GetInstance<T>(string uniqueKey = null)
        {
            if (!string.IsNullOrEmpty(uniqueKey))
                return Manager.GetInstance<T>(uniqueKey);
            return Manager.GetInstance<T>();
        }

        public static void DeleteInstance<T>(string uniqueKey) where T : class
        {
            Manager.Unregister<T>(uniqueKey);
        }
    }
}
