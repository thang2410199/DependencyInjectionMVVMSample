using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace DependencyInjectionMVVMSample
{
    public class MainViewModel : IMainViewModel
    {
        private IContactService contactService;

        public ObservableCollection<IContactModel> ContactList { get; set; }

        public MainViewModel(IContactService contactService)
        {
            this.contactService = contactService;

            ContactList = new ObservableCollection<IContactModel>();


            if (ViewModelBase.IsInDesignModeStatic)
            {
                this.GetAllContact();
            }
        }

        public void GetAllContact()
        {
            var result = this.contactService.GetAll();

            foreach (var item in result)
            {
                ContactList.Add(item);
            }
        }
    }
}