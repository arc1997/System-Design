using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Design_Pattern
{
    public class TrafficLightContext
    {
        private ITrafficLightState _state;

        public TrafficLightContext(ITrafficLightState initialState)
        {
            _state = initialState;
        }

        public void SetState(ITrafficLightState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
