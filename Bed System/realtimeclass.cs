﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    public class realtimeclass
    {
        private int pm_id;
        private int p_id;
        private int p_systolic;
        private int p_diastolic;
        private int p_breathing;
        private int p_pulse;
        private int p_temperature;

        public int Pm_id { get => pm_id; set => pm_id = value; }
        public int P_id { get => p_id; set => p_id = value; }
        public int P_systolic { get => p_systolic; set => p_systolic = value; }
        public int P_diastolic { get => p_diastolic; set => p_diastolic = value; }
        public int P_breathing { get => p_breathing; set => p_breathing = value; }
        public int P_pulse { get => p_pulse; set => p_pulse = value; }
        public int P_temperature { get => p_temperature; set => p_temperature = value; }
    }
}
