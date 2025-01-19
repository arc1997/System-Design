using Design_Patterns.State_Design_Pattern;
using Design_Patterns.State_Design_Pattern.ConcreteStates;

class MAIN
{
    public static void Main(string[] args)
    {
        var trafficLight = new TrafficLightContext(new GreenLightState());

        for (int i = 0; i < 6; i++)
        {
            trafficLight.Request();
            System.Threading.Thread.Sleep(1000); // Simulate time delay
        }
    }

}



