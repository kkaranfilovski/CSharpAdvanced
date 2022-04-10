using SEDC.Oop.Class02.BonusHomework.Models;

namespace SEDC.Oop.Class02.BonusHomework.Interfaces
{
    public interface IRepairService
    {
        void CheckVehicle(Vehicle vehicle);

        void FixVehicle(Vehicle vehicle);
    }
}