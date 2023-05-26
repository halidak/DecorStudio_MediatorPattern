using DecorStudio_MediatorPattern.AbstractColleague;
using DecorStudio_MediatorPattern.Colleagues;
using DecorStudio_MediatorPattern.ConcreteMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace DecorStudio_MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DecorStudioMediator mediator = new DecorStudioMediator();

            Colleague customer1 = new Customer("Customer 1", "customer1@gmail.com", "12334567", "Address 1", mediator);
            //Colleague customer2 = new Customer("Customer 2", "customer2@gmail.com", "12334567", "Address 1", mediator);

            Colleague store1 = new Store("Store 1", "Address3", mediator);

            Decor decor1 = new Decor(1, "Decor 1");
            //Decor decor2 = new Decor(2, "Decor 2");


            customer1.SubscribeToDecor(decor1);
            //customer2.SubscribeToDecor(decor2);

            store1.CheckAvailability();

            store1.AddDecor(decor1);
            store1.CheckAvailability();

            Console.ReadLine();
        }
    }
}
