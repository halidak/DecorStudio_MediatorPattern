using DecorStudio_MediatorPattern.AbstractColleague;
using DecorStudio_MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_MediatorPattern.Colleagues
{
    public class Customer : Colleague
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Decor> subscribedDecors { get; set; }

        public Customer(string name, string email, string phone, string address, IMediator mediator) : base(mediator)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            subscribedDecors = new List<Decor>();
            mediator.RegisterCustomer(this);
        }

        public override void SubscribeToDecor(Decor decor)
        {
            subscribedDecors.Add(decor);
            Console.WriteLine($"Customer {Name} subscribed to decor '{decor.Name}'.");
        }

        public void Notify(Decor decor)
        {
            Console.WriteLine($"Customer {Name} has received a notification that: {decor.Name} is avaliable");
        }


        public override void CheckAvailability()
        {
            foreach (var decor in subscribedDecors)
            {
                mediator.CheckDecorAvailability(decor);
            }
        }

        public override void AddDecor(Decor decor)
        {
            Console.WriteLine($"Adding decor '{decor.Name}' to customer {Name}'s collection.");
            subscribedDecors.Add(decor);
        }
    }
}
