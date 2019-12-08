using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedSystem;
using Bed_System;
using MySql.Data.MySqlClient;

namespace BedSystem
{
    [TestClass]
    public class UnitTestAddPatientMedicalHandler
    {
        [TestMethod]
        public void TestAddPatientMedical()
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            string resp = databaseConnertor.connect();
            Assert.AreEqual("Done", resp);

            pmdetails pmdetails = new pmdetails();
            pmdetails.P_id = 11;
            pmdetails.P_systolic = 120;
            pmdetails.P_diastolic = 80;
            pmdetails.P_breathing = 20;
            pmdetails.P_pulse = 60;
            pmdetails.P_temperater1 = 36;

            pmdetailsHandler pmdetailsHandler = new pmdetailsHandler();
            int resp2 = pmdetailsHandler.addNewDetails(databaseConnertor.getconn(), pmdetails);
            Assert.AreEqual(1, resp2);
        }
    }
}
