using System;

namespace CorpFleet.Models
{
    public class CargoVehicle : Vehicle
    {
        public decimal LoadCapacity { get; set; }

        public override string GetVehicleType()
        {
            return "Грузовой";
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   $", грузоподъёмность: {LoadCapacity} т";
        }
    }
}