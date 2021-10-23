using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace SOLID.OCP.Violation
{
    // This service locator pattern had a hard coded switch. Changed it so that the values it queried would be added through dependency injection when the DeviceFinder was instantiated.
    // Configure this with your favourite IoC container or manually create the dictionary at class instantiation.
    public class DeviceFinder 
    {
        private Dictionary<DeviceModel, SerialPort> _devices;
        public DeviceFinder(Dictionary<DeviceModel, SerialPort> devices)
        {
            this._devices = devices;
        }
        public string FindDevice(DeviceModel model)
        {
            if(_devices.TryGetValue(model, out SerialPort port))
            {
                return Find(port);
            }else
            {
                throw new ArgumentException($"Unknown model: {model}.");
            }
        }

        private string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach(string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0 )
                    return name;
            }
            return null;
        }
    }
}
