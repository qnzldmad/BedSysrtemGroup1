using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bed_System;
using BedSystem;
using MySql.Data.MySqlClient;

namespace BedSystem
{
    [TestClass]
    public class UnitTestAddPatientHandler
    {
        [TestMethod]
        public void TestAddNewPatient()
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            string resp = databaseConnertor.connect();
            Assert.AreEqual("Done", resp);

            addPatient addPatient = new addPatient();
            addPatient.P_firstName = "Test";
            addPatient.P_lastName = "Man";
            addPatient.P_age = 30;
            addPatient.P_dob = DateTime.Now;
            addPatient.P_contact = 140055544;
            addPatient.P_emergencyContact = 184845656;
            addPatient.P_gender = "Male";
            addPatient.P_address = "Cheras";
            addPatient.P_bedNum = 5;
            addPatient.P_floor = "4";
            addPatient.P_admission = DateTime.Now;

            addPatientHandler addPatientHandler = new addPatientHandler();
            int resp2 = addPatientHandler.addNewPatient(databaseConnertor.getconn(), addPatient);
            Assert.AreEqual(1, resp2);
        }
    }
}
