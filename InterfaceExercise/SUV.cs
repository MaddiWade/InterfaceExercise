using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool AutomaticDoor { get; set; }
        public bool TvInstallation { get; set; }
        public int NumberOfWheels { get; set; }
        public int RowOfSeats { get; set; }
        public string Color { get; set; }
        public int MilesPerGallon { get; set; }
        public string Logo { get; set; }
        public bool PubliclyTraded { get; set; }
    }
}
