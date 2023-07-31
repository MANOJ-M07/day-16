using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterface
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryPercentage { get; private set; }

        public Smartphone(string model)
        {
            Model = model;
            IsConnected = false;
            BatteryPercentage = 0;
        }

        public bool Connect()
        {
            // Your implementation for smartphone's connect method
            IsConnected = true;
            return IsConnected;
        }

        public void Charge(int minutes)
        {
            // Your implementation for smartphone's charge method
            BatteryPercentage += minutes / 10; // Assuming 10 minutes charge increases battery by 1%
            if (BatteryPercentage > 100)
                BatteryPercentage = 100;
        }

        public string Display()
        {
            // Your implementation for smartphone's display method
            return $"Smartphone Model: {Model}, Battery: {BatteryPercentage}%";
        }
    }
}
