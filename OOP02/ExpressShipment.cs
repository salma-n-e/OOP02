using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    public class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
                else
                    extraFee = 0;
            }
        }
            public override decimal EstimatedDeliveryTCost
        {
            get { return base.EstimatedDeliveryTCost + ExtraFee; }
        }

        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
       : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override void PrintShipmentDetails()
        {
            base.PrintShipmentDetails();
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
    }
    }



