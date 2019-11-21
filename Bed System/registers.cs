using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    class registers
    {
        private int register_id;
        private int s_id;
        private DateTime register_date;
        private DateTime register_time;
        private DateTime deregister_date;
        private DateTime deregister_time;

        public int Register_id { get => register_id; set => register_id = value; }
        public int S_id { get => s_id; set => s_id = value; }
        public DateTime Register_date { get => register_date; set => register_date = value; }
        public DateTime Register_time { get => register_time; set => register_time = value; }
        public DateTime Deregister_date { get => deregister_date; set => deregister_date = value; }
        public DateTime Deregister_time { get => deregister_time; set => deregister_time = value; }
    }
}
