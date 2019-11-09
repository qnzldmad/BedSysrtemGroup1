using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Bed_System;

namespace BadSystem
{
    [TestClass]
    public class UnitTestaddPatientHandler
    {
        [TestMethod]
        public void TestAddNewPatient()
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            string resp = databaseConnertor.connect();
            Assert.AreEqual("Done", resp);

            addPatient addPatient = new addPatient();
            addPatient.P_firstName = "Kay";
            addPatient.P_lastName = "Aum";
            addPatient.P_age = 22;
            addPatient.P_dob = DateTime.Now;
            addPatient.P_contact = 140055544;
            addPatient.P_emergencyContact = 184845656;
            addPatient.P_gender = "Male";
            addPatient.P_address = "Cheras";

            addPatientHandler addPatientHandler = new addPatientHandler();
            int resp2 = addPatientHandler.addNewPatient(databaseConnertor.getconn(), addPatient);
            Assert.IsNotNull(resp2);
        }
    }
}
