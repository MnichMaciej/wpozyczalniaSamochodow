using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalniaSamochodow
{
    public enum CarType
    {
        SUV=1,Combi=2,Sport=3,Sedan=4,Coupe=5
    }
    public class Car : CarData
    {
        public int carId;
        public string registrationNumber;
        public CarType type; 
        public int vehicleOdometer; 
        public bool carEfficiency;
        public bool isDisabled;
    }
}
