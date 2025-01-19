using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Design_Pattern.ConcreteStates
{
    public class YellowLightState : ITrafficLightState
    {
        public void Handle(TrafficLightContext context)
        {
            Console.WriteLine("Yellow Light: Prepare to stop!");
            context.SetState(new RedLightState());
        }
    }
}
