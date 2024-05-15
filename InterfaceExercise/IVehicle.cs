using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    //In your IVehicle:

    /* DONE Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */

    public interface IVehicle
    {
        public int NumberOfWheels {  get; set; }
        public string Model { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasTrunk { get; set; }

    }
}
