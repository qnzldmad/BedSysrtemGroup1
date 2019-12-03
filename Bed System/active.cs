using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    public class active
    {
        private int ba_id;
        private string ms_name;
        private int bed_number;
        private DateTime emergency_datetime;
        private DateTime staff_checkdatetime;
        private int systolic;
        private int diastolic;
        private int pulse;
        private int breathing;
        private int temperature;

        public int Ba_id { get => ba_id; set => ba_id = value; }
        public int Bed_number { get => bed_number; set => bed_number = value; }
        public DateTime Emergency_datetime { get => emergency_datetime; set => emergency_datetime = value; }
        public DateTime Staff_checkdatetime { get => staff_checkdatetime; set => staff_checkdatetime = value; }
        public string Ms_name { get => ms_name; set => ms_name = value; }
        public int Systolic { get => systolic; set => systolic = value; }
        public int Diastolic { get => diastolic; set => diastolic = value; }
        public int Pulse { get => pulse; set => pulse = value; }
        public int Breathing { get => breathing; set => breathing = value; }
        public int Temperature { get => temperature; set => temperature = value; }
    }
}
