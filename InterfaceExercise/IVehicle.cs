using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int RowOfSeats { get; set; }
        public string Color { get; set; }
        public int MilesPerGallon { get; set; }

    }
}
