using SEDC.Oop.Class02.BonusHomework.Interfaces;

namespace SEDC.Oop.Class02.BonusHomework.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        private CarWash carWash = new CarWash();
        private GasPump gasPump = new GasPump();
        private RepairService repairService = new RepairService();


        public void CheckVehicle(Vehicle vehicle)
        {
            repairService.CheckVehicle(vehicle);
        }

        public void FixVehicle(Vehicle vehicle)
        {
            repairService.FixVehicle(vehicle);
        }

        public void PumpGas(Vehicle vehicle)
        {
            gasPump.PumpGas(vehicle);
        }

        public void WashCar(Vehicle car)
        {
            carWash.WashCar(car);
        }

        public void WashTrailer(Vehicle truck)
        {
            carWash.WashTrailer(truck);
        }
    }
}
