using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Design_Pattern
{
    public interface ITrafficLightState
    {
        void Handle(TrafficLightContext context);
    }
}
