using System.Reflection;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q 1 
            // a)  struct is a value type, while class is a reference type.
            // structs are stored on the stack, while classes are stored on the heap.
            // Structs cannot have a default constructor, while classes can.
            // Structs cannot inherit from other structs or classes, while classes can.
            // Structs are generally used for small data structures that do not require inheritance or polymorphism,
            // while classes are used for more complex data structures that require these features

            // b) Inheritance & Reusability: They support OOP principles like inheritance and polymorphism,
            // making the codebase scalable and maintainable.

            //  Performance with Large Data: Passing a class (Reference Type) copies only its memory address,
            //  whereas passing a struct (Value Type) copies the entire object,
            //  which overheads memory when dealing with large data structures.


            // Q 2 
            // a) Shipment
            // b) ExpressShipment
            // c) TrackingCode
            // d) because Inheritance allows us to reuse code written in the parent class instead of rewriting it.
            // This makes the code cleaner, reduces errors,
            // and makes future updates much easier since changes are made in only one place.



            {
                
                Console.Write("Enter Delivery Center Name: ");
                string centerName = Console.ReadLine();
                DeliveryCenter center = new DeliveryCenter(centerName, 10);

                

                Console.WriteLine(" Enter Standard Shipment Details ");
                Console.Write("Tracking Code: ");
                string stdCode = Console.ReadLine();
                Console.Write("Description: ");
                string stdDesc = Console.ReadLine();
                Console.Write("Weight: ");
                double stdWeight = double.Parse(Console.ReadLine());
                Console.Write("Delivery Fee: ");
                decimal stdFee = decimal.Parse(Console.ReadLine());
                Console.Write("City: ");
                string stdCity = Console.ReadLine();
                Console.Write("Street: ");
                string stdStreet = Console.ReadLine();
                Console.Write("Building Number: ");
                int stdBuilding = int.Parse(Console.ReadLine());

                DeliveryAddress stdAddress = new DeliveryAddress(stdCity, stdStreet, stdBuilding);
                StandardShipment standard = new StandardShipment(stdCode, stdDesc, stdWeight, stdFee, stdAddress);

                


                Console.WriteLine("Enter Express Shipment Details ");
                Console.Write("Tracking Code: ");
                string expCode = Console.ReadLine();
                Console.Write("Description: ");
                string expDesc = Console.ReadLine();
                Console.Write("Weight: ");
                double expWeight = double.Parse(Console.ReadLine());
                Console.Write("Delivery Fee: ");
                decimal expFee = decimal.Parse(Console.ReadLine());
                Console.Write("Extra Fee: ");
                decimal expExtraFee = decimal.Parse(Console.ReadLine());
                Console.Write("City: ");
                string expCity = Console.ReadLine();
                Console.Write("Street: ");
                string expStreet = Console.ReadLine();
                Console.Write("Building Number: ");
                int expBuilding = int.Parse(Console.ReadLine());

                DeliveryAddress expAddress = new DeliveryAddress(expCity, expStreet, expBuilding);
                ExpressShipment express = new ExpressShipment(expCode, expDesc, expWeight, expFee, expAddress, expExtraFee);

                


                Console.WriteLine(" Enter International Shipment Details ");
                Console.Write("Tracking Code: ");
                string intCode = Console.ReadLine();
                Console.Write("Description: ");
                string intDesc = Console.ReadLine();
                Console.Write("Weight: ");
                double intWeight = double.Parse(Console.ReadLine());
                Console.Write("Delivery Fee: ");
                decimal intFee = decimal.Parse(Console.ReadLine());
                Console.Write("Destination Country: ");
                string intCountry = Console.ReadLine();
                Console.Write("Customs Fee: ");
                decimal intCustoms = decimal.Parse(Console.ReadLine());
                Console.Write("City: ");
                string intCity = Console.ReadLine();
                Console.Write("Street: ");
                string intStreet = Console.ReadLine();
                Console.Write("Building Number: ");
                int intBuilding = int.Parse(Console.ReadLine());

                DeliveryAddress intAddress = new DeliveryAddress(intCity, intStreet, intBuilding);
                InternationalShipment intl = new InternationalShipment(intCode, intDesc, intWeight, intFee, intAddress, intCountry, intCustoms);

                
                center.AddShipment(standard);
                center.AddShipment(express);
                center.AddShipment(intl);

                
                Console.WriteLine(" ALL SHIPMENTS ");
                center.PrintAllShipments();

                
                Console.WriteLine(" SEARCH SHIPMENT ");
                Console.Write("Enter tracking code to search: ");
                string searchCode = Console.ReadLine();
                Shipment foundShipment = center[searchCode];

                if (foundShipment != null)
                {
                    Console.WriteLine("[Shipment Found Details]");
                    foundShipment.PrintShipmentDetails();
                }
                else
                {
                    Console.WriteLine("Shipment not found!");
                }

               
                Console.WriteLine(" REMOVE SHIPMENT");
                Console.Write("Enter tracking code to remove: ");
                string removeCode = Console.ReadLine();
                bool isRemoved = center.RemoveShipment(removeCode);

                if (isRemoved)
                    Console.WriteLine($"Shipment {removeCode} removed successfully.");
                else
                    Console.WriteLine($"Shipment {removeCode} could not be found to remove.");

              
                Console.WriteLine(" REMAINING SHIPMENTS ");
                center.PrintAllShipments();
            }
        }
    }

}
    