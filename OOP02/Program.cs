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


        }
    }
}
