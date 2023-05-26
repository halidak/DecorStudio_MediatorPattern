using DecorStudio_MediatorPattern.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_MediatorPattern.Mediator
{
    public interface IMediator
    {
        void Notify(Store store, Decor decor);
        void RegisterCustomer(Customer customer);
        void RegisterStore(Store stores);
        void SubscribeToDecor(Customer customer, Decor decor);
        void CheckDecorAvailability(Decor decor);
    }
}
