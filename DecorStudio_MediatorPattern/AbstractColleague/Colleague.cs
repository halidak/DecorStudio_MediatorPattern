using DecorStudio_MediatorPattern.Colleagues;
using DecorStudio_MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_MediatorPattern.AbstractColleague
{
    public abstract class Colleague
    {
        protected IMediator mediator;
        public Colleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void SubscribeToDecor(Decor decor);
        public abstract void CheckAvailability();
        public abstract void AddDecor(Decor decor);
      

    }
}
