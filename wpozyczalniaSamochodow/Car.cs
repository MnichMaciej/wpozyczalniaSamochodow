using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpozyczalniaSamochodow
{
    enum CarType
    {
        SUV=1,Combi=2,Sport=3,Sedan=4,Coupe=5
    }
    class Car : CarData
    {
        public int carId;
        public string registrationNumber;
        public CarType type; //TODO: zamienić na enuma (stworzyć enuma w sumie po pierwsze)
        public int vehicleOdometer; //TODO: zamienić w bazie danych na inta bo jest double
        public bool carEfficiency;
        public bool isDisabled;
    }
}
