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
        private int minpulse;
        private int minbreathing;
        private int minbloodsys;
        private int mintemperature;
        private int minblooddias;
        private int maxpulse;
        private int maxbreathing;
        private int maxbloodsys;
        private int maxtemperature;
        private int maxblooddias;

        public int Id { get => id; set => id = value; }
        public int Minpulse { get => minpulse; set => minpulse = value; }
        public int Minbreathing { get => minbreathing; set => minbreathing = value; }
        public int Minbloodsys { get => minbloodsys; set => minbloodsys = value; }
        public int Mintemperature { get => mintemperature; set => mintemperature = value; }
        public int Minblooddias { get => minblooddias; set => minblooddias = value; }
        public int Maxpulse { get => maxpulse; set => maxpulse = value; }
        public string Name { get => name; set => name = value; }
        public int Maxbreathing { get => maxbreathing; set => maxbreathing = value; }
        public int Maxbloodsys { get => maxbloodsys; set => maxbloodsys = value; }
        public int Maxtemperature { get => maxtemperature; set => maxtemperature = value; }
        public int Maxblooddias { get => maxblooddias; set => maxblooddias = value; }
    }
}
