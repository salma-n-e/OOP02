using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    public class DeliveryCenter
    {
        private string CenterName;
        private Shipment[] Shipment;
        private int count;

        public string centerName
        {             get { return centerName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    centerName = value;
                else
                    centerName = "Unknown";
            }}
        public Shipment[] Shipments
        {
            get { return Shipment; }
            set { Shipment = value; }
        }
        public int Count
        {
            get { return count; }
            set
            {
                if (value >= 0)
                    count = value;
                else
                    count = 0;
            }
        }
        public DeliveryCenter(string centerName, int capacity)
        {
            this.centerName = centerName;
            Shipment = new Shipment[capacity];
            count = 0;
        }
        public bool AddShipment(Shipment shipment)
        {
            if (count < Shipment.Length)
            {
                Shipment[count] = shipment;
                count++;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return Shipments[index];
                return null;
            }
        }

       
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (Shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                        return Shipments[i];
                }
                return null;
            }
        }

        
        public bool RemoveShipment(string trackingCode)
        {
            int indexFound = -1;

            for (int i = 0; i < count; i++)
            {
                if (Shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                {
                    indexFound = i;
                    break;
                }
            }

            if (indexFound == -1)
                return false;

            
            for (int i = indexFound; i < count - 1; i++)
            {
                Shipments[i] = Shipments[i + 1];
            }

            Shipments[count - 1] = null;
            count--;
            return true;
        }

        
        public void PrintAllShipments()
        {
            Console.WriteLine($" Delivery Center: {CenterName} ");
            if (count == 0)
            {
                Console.WriteLine("No shipments available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Shipment #{i + 1} ");
                Shipments[i].PrintShipmentDetails();
                Console.WriteLine();
            }
        }

    }
}
