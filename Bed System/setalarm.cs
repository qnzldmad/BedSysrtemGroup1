using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    public class setalarm
    {
        private int sa_id;
        private int p_id;
        private int p_min_blood_sys;
        private int p_min_temperature;
        private int p_min_blood_dias;
        private int p_min_breathing_rate;
        private int p_min_pulse_rate;
        private int p_max_pulse;
        private int p_max_sys;
        private int p_max_dias;
        private int p_max_temperature;
        private int p_max_breathing;

        public int Sa_id { get => sa_id; set => sa_id = value; }
        public int P_id { get => p_id; set => p_id = value; }
        public int P_min_blood_sys { get => p_min_blood_sys; set => p_min_blood_sys = value; }
        public int P_min_temperature { get => p_min_temperature; set => p_min_temperature = value; }
        public int P_min_blood_dias { get => p_min_blood_dias; set => p_min_blood_dias = value; }
        public int P_min_breathing_rate { get => p_min_breathing_rate; set => p_min_breathing_rate = value; }
        public int P_min_pulse_rate { get => p_min_pulse_rate; set => p_min_pulse_rate = value; }
        public int P_max_pulse { get => p_max_pulse; set => p_max_pulse = value; }
        public int P_max_sys { get => p_max_sys; set => p_max_sys = value; }
        public int P_max_dias { get => p_max_dias; set => p_max_dias = value; }
        public int P_max_temperature { get => p_max_temperature; set => p_max_temperature = value; }
        public int P_max_breathing { get => p_max_breathing; set => p_max_breathing = value; }
    }
}
