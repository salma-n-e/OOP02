using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    public class InternationalShipment : Shipment
    {
        private string DestinationCountry;
        private decimal CustomsFee;

        public string DestinationCountryProperty
        {
            get { return DestinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    DestinationCountry = value;
                else
                    DestinationCountry = "Unknown";

            }
        }
        public decimal CustomsFeeproperty
        {
            get { return CustomsFee; }
            set
            {
                if (value >= 0)
                    CustomsFee = value;
                else
                    CustomsFee = 0;
            }
        }
        public override decimal EstimatedDeliveryTCost
        {
            get { return base.EstimatedDeliveryTCost + CustomsFee; }
        }
        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountryProperty = destinationCountry;
            CustomsFeeproperty = customsFee;
        }
        public override void PrintShipmentDetails()
        {
            base.PrintShipmentDetails();
            Console.WriteLine($"Destination Country: {DestinationCountryProperty}");
            Console.WriteLine($"Customs Fee: {CustomsFeeproperty}");
        }
    }
}
