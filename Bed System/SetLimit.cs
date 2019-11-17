using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    class SetLimit
    {
        private int id;
        private string name;
        private int pulse;
        private int breathing;
        private int bloodsys;
        private int temperature;
        private int blooddias;

        public int Id { get => id; set => id = value; }
        public int Pulse { get => pulse; set => pulse = value; }
        public int Breathing { get => breathing; set => breathing = value; }
        public int Bloodsys { get => bloodsys; set => bloodsys = value; }
        public int Temperature { get => temperature; set => temperature = value; }
        public int Blooddias { get => blooddias; set => blooddias = value; }
        public string Name { get => name; set => name = value; }
    }
}
