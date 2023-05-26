using DecorStudio_MediatorPattern.AbstractColleague;
using DecorStudio_MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_MediatorPattern.Colleagues
{
    public class Store : Colleague
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Decor> AvailableDecor { get; set; }
        public Store(string name, string address, IMediator mediator) : base(mediator)
        {
            Name = name;
            Address = address;
            AvailableDecor = new List<Decor>();
            mediator.RegisterStore(this);
        }

        public void Notify(string decor)
        {
            Console.WriteLine($"Store {Name} has received a new decor: {decor}");
        }

        public override void AddDecor(Decor decor)
        {
            AvailableDecor.Add(decor);
            mediator.Notify(this, decor);
        }

        public override void SubscribeToDecor(Decor decor)
        {
            Console.WriteLine($"Customer is subscribed to decor '{decor.Name}'.");
        }

        public override void CheckAvailability()
        {
            foreach (var decor in AvailableDecor)
            {
                mediator.CheckDecorAvailability(decor);
            }
        }


    }
}
