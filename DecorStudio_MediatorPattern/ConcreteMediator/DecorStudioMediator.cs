using DecorStudio_MediatorPattern.Colleagues;
using DecorStudio_MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_MediatorPattern.ConcreteMediator
{
    public class DecorStudioMediator : IMediator
    {
        public List<Customer> customers { get; set; } = new List<Customer>();
        public List<Store> stores { get; set; } = new List<Store>();

        public void CheckDecorAvailability(Decor decor)
        {
            foreach (var store in stores)
            {
                if (store.AvailableDecor.Contains(decor))
                {
                    Console.WriteLine($"Decor '{decor.Name}' is available at store '{store.Name}'.");
                    return;
                }
                Console.WriteLine($"Decor '{decor.Name}' is not available at any store.");
            }
        }

        public void Notify(Store store, Decor decor)
        {
            foreach (Customer customer in customers)
            {
                if (customer.subscribedDecors.Contains(decor))
                {
                    store.Notify(decor.Name);
                    customer.Notify(decor);
                }
            }
        }

        public void RegisterCustomer(Customer customer)
        {
            customers.Add(customer);
        }


        public void RegisterStore(Store store)
        {
            stores.Add(store);
        }

        public void SubscribeToDecor(Customer customer, Decor decor)
        {
            foreach (Store store in stores)
            {
                if (!store.AvailableDecor.Contains(decor))
                {
                    customer.SubscribeToDecor(decor);
                    return;
                }
            }
        }
    }
}
