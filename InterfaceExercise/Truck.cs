using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int BedLength { get; set; }
        // Bed length is to be measured in Feet
        public bool MiddleFrontSeat { get; set; }
        public int NumberOfWheels { get; set; }
        public int RowOfSeats { get; set; }
        public string Color { get; set; }
        public int MilesPerGallon { get; set; }
        public string Logo { get; set; }
        public bool PubliclyTraded { get; set; }
    }
}
