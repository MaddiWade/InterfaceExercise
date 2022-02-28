using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public bool MiddleSeatBelt { get; set; }
        public bool Trunk { get; set; }

        public string Logo { get; set; }
        public bool PubliclyTraded { get; set; }
        public int NumberOfWheels { get; set; }
        public int RowOfSeats { get; set; }
        public string Color { get; set; }
        public int MilesPerGallon { get; set; }


    }
}
