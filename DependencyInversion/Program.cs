namespace DependencyInversion
{
    // An interface for a light.
    public interface ILight
    {
        void TurnOn();
    }

    // A class for a light bulb.
    public class LightBulb : ILight
    {
        public void TurnOn()
        {
            Console.WriteLine("Light bulb is on!");
        }
    }

    // A class that depends on the ILight interface, not a specific light.
    public class Switch
    {
        private ILight _light;
        public Switch(ILight light)
        {
            _light = light;
        }

        public void Flip()
        {
            _light.TurnOn();
        }
    }
}

// Now we can easily change the type of light without changing the Switch class.

// ---------
// The Dependency Inversion Principle is about making sure that big things depend on general ideas,
// not on small, specific details.