using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    public class addPatient
    {
        private int p_id;
        private string p_firstName;
        private string p_lastName;
        private int p_age;
        private DateTime p_dob;
        private int p_contact;
        private int p_emergencyContact;
        private string p_gender;
        private string p_address;
        private int p_bedNum;
        private string p_floor;

        public int P_id { get => p_id; set => p_id = value; }
        public string P_firstName { get => p_firstName; set => p_firstName = value; }
        public string P_lastName { get => p_lastName; set => p_lastName = value; }
        public int P_age { get => p_age; set => p_age = value; }
        public DateTime P_dob { get => p_dob; set => p_dob = value; }
        public int P_contact { get => p_contact; set => p_contact = value; }
        public int P_emergencyContact { get => p_emergencyContact; set => p_emergencyContact = value; }
        public string P_gender { get => p_gender; set => p_gender = value; }
        public string P_address { get => p_address; set => p_address = value; }
        public int P_bedNum { get => p_bedNum; set => p_bedNum = value; }
        public string P_floor { get => p_floor; set => p_floor = value; }
    }
}
