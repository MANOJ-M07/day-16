using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterface
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        public string Brand { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryPercentage { get; private set; }

        public Laptop(string brand)
        {
            Brand = brand;
            IsConnected = false;
            BatteryPercentage = 0;
        }

        public bool Connect()
        {
            // Your implementation for laptop's connect method
            IsConnected = true;
            return IsConnected;
        }

        public void Charge(int minutes)
        {
            // Your implementation for laptop's charge method
            BatteryPercentage += minutes / 5; // Assuming 5 minutes charge increases battery by 1%
            if (BatteryPercentage > 100)
                BatteryPercentage = 100;
        }

        public string Display()
        {
            // Your implementation for laptop's display method
            return $"Laptop Brand: {Brand}, Battery: {BatteryPercentage}%";
        }
    }
}
