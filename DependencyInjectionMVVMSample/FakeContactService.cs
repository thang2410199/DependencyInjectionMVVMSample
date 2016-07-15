using SutoLorem;
using System;
using System.Collections.Generic;

namespace DependencyInjectionMVVMSample
{
    internal class FakeContactService : IContactService
    {
        public FakeContactService()
        {
        }

        public List<IContactModel> GetAll()
        {
            List<IContactModel> list = new List<IContactModel>();
            LoremText lorem = new LoremText();
            // Generate 5 random contact
            for (int i = 0; i < 5; i++)
            {
                list.Add(new ContactModel()
                {
                    Name = lorem.GetFullname(),
                    Description = lorem.GetSentence()
                });
            }

            return list;
        }
    }
}