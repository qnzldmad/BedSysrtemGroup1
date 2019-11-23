using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    public class addMedicalstaffs
    {
        private int ms_id;
        private string ms_position;
        private string ms_firstName;
        private string ms_lastName;
        private DateTime ms_dob;
        private int ms_age;
        private int ms_contact;
        private string ms_email;
        private string ms_loginid;
        private string ms_password;



        public int Ms_id { get => ms_id; set => ms_id = value; }
        public string Ms_position { get => ms_position; set => ms_position = value; }
        public string Ms_firstName { get => ms_firstName; set => ms_firstName = value; }
        public string Ms_lastName { get => ms_lastName; set => ms_lastName = value; }
        public DateTime Ms_dob { get => ms_dob; set => ms_dob = value; }
        public int Ms_age { get => ms_age; set => ms_age = value; }
        public int Ms_contact { get => ms_contact; set => ms_contact = value; }
        public string Ms_email { get => ms_email; set => ms_email = value; }
        public string Ms_loginid { get => ms_loginid; set => ms_loginid = value; }
        public string Ms_password { get => ms_password; set => ms_password = value; }
    }
}
