using System;
using System.Collections.Generic;

namespace DependencyInjectionMVVMSample
{
    internal class ContactService : IContactService
    {
        public ContactService()
        {
        }

        public List<IContactModel> GetAll()
        {
            //Get data from remote server or database
            return new List<IContactModel>();
        }
    }
}