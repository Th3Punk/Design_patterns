using System;
using System.Collections.Generic;

namespace Adapter_pattern
{
    public class AdapterExample
    {
        private readonly IAddressRepository Repository;
        private readonly IMessageService Service;

        public AdapterExample(IAddressRepository _repository, IMessageService _service)
        {
            Repository = _repository ?? throw new ArgumentNullException(nameof(_repository));
            Service = _service ?? throw new ArgumentNullException(nameof(_service));
        }


        public void Start()
        {
            //legyen egy adatforrás
            //var list = new List<string> { "sitkei.balazs92@gmail.com" };

            //var repo = new AddressRepository();

            //legyen egy mail megoldásunk


            //és ezeket kössük össze
            var messageService = new MessageTestService();

            //var addressList = repo.GetAddresses();
            var addressList = Repository.GetAddresses();

            foreach (var address in addressList)
            {
                messageService.AddMessage(_to: address.EMail, _subject: "Valami", _text: "Szöveg");
            }

            messageService.SendMessages();

            
        }
    }
}