namespace CorpFleet.Models
{
    public class PassengerVehicle : Vehicle
    {
        public int PassengerCapacity { get; set; }

        public override string GetVehicleType()
        {
            return "Пассажирский";
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   $", количество пассажиров: {PassengerCapacity}";
        }
    }
}