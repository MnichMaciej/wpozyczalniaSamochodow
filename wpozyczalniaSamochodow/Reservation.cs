using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wypozyczalniaSamochodow;

namespace wpozyczalniaSamochodow
{
    public class Reservation
    {
        public int reservationId;
        public string registrationNumber;
        public string brand;
        public string model;
        public string dateBegin;
        public string dateEnd;
        public CarType carType;
        public int fineId;
        public bool ended;

    }
}
