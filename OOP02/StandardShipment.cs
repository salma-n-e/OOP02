using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
    : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

    }
}

