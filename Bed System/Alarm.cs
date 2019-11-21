using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    class Alarm
    {
        private int id;
        private string name;
        private int pulserate;
        private int breathingrate;
        private int bloodsys;
        private int blooddias;
        private int temperature;

        public int Id
        {
            get => id; set => id = value;
        }

        public string Name
        {
            get => name; set => name = value;
        }

        public int Pulserate
        {
            get => pulserate; set => pulserate = value;
        }

        public int Breathingrate
        {
            get => breathingrate; set => breathingrate = value;
        }

        public int Bloodsys
        {
            get => bloodsys; set => bloodsys = value;
        }

        public int Blooddias
        {
            get => blooddias; set => blooddias = value;
        }

        public int Temperature
        {
            get => temperature; set => temperature = value;
        }
    }
}
