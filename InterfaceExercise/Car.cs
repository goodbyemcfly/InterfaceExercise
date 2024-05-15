using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    //In each of your Car, Truck, and SUV classes

    /* DONE Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * DONE Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */

    public class Car : IVehicle, ICompany
    {
        public string Color { get; set; }
        public int TireSize { get; set; }
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasTrunk { get; set ; }
        public string CompanyName { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}
