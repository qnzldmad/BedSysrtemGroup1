using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    public class addNurses
    {
        private int s_id;
        private string s_position;
        private string s_firstName;
        private string s_lastName;
        private DateTime s_dob;
        private int s_age;
        private int s_contact;
        private string s_email;
        private string s_loginid;
        private string s_password;

        public int S_id { get => s_id; set => s_id = value; }
        public string S_position { get => s_position; set => s_position = value; }
        public string S_firstName { get => s_firstName; set => s_firstName = value; }
        public string S_lastName { get => s_lastName; set => s_lastName = value; }
        public DateTime S_dob { get => s_dob; set => s_dob = value; }
        public int S_age { get => s_age; set => s_age = value; }
        public int S_contact { get => s_contact; set => s_contact = value; }
        public string S_email { get => s_email; set => s_email = value; }
        public string S_loginid { get => s_loginid; set => s_loginid = value; }
        public string S_password { get => s_password; set => s_password = value; }
    }
}
