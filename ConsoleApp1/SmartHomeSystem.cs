using System;

namespace SmartHome
{
    // Create a new interface. (Lesson: Interfaces)
    public interface ISmartDevice
    {
        // Note how below each device COULD have its own implementation of TurnOn, TurnOff and Status
        // even though some are exactly the same they could very well be very different.
        // (Lesson: Polymorphism)

        // Also note how each implementation is hidden behind the method meaning we don't know how the device is turned on or off.
        // All we know is that it IS being turned on or off.
        // (Lesson: Encapsulation)
        void TurnOn();
        void TurnOff();
        string Status();
    }

    public class LightBulb : ISmartDevice
    {
        private bool _isOn;

        public void TurnOn()
        {
            _isOn = true;
        }

        public void TurnOff()
        {
            _isOn = false;
        }

        public string Status()
        {
            return _isOn ? "LightBulb is turned on." : "LightBulb is turned off.";
        }
    }

    public class Thermostat : ISmartDevice
    {
        private bool _isOn;

        public void TurnOn()
        {
            _isOn = true;
        }

        public void TurnOff()
        {
            _isOn = false;
        }

        public string Status()
        {
            return _isOn ? "Thermostat is turned on." : "Thermostat is turned off.";
        }
    }

    public class DoorLock : ISmartDevice
    {
        private bool _isActive;

        public void TurnOn()
        {
            _isActive = true;
        }

        public void TurnOff()
        {
            _isActive = false;
        }

        public string Status()
        {
            return _isActive ? "DoorLock is activated." : "DoorLock is deactivated.";
        }
    }
}
