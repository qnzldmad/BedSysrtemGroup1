using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedSystem;
using Bed_System;
using MySql.Data.MySqlClient;

namespace BedSystem
{
    [TestClass]
    public class UnitTestAddMedicalStaff
    {
        [TestMethod]
        public void TestAddMedicalStaff()
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            string resp = databaseConnertor.connect();
            Assert.AreEqual("Done", resp);

            addMedicalstaffs addMedicalstaffs = new addMedicalstaffs();
            addMedicalstaffs.Ms_position = "Consultant";
            addMedicalstaffs.Ms_firstName = "Test";
            addMedicalstaffs.Ms_lastName = "Man";
            addMedicalstaffs.Ms_dob = DateTime.Now;
            addMedicalstaffs.Ms_age = 40;
            addMedicalstaffs.Ms_contact = 171234567;
            addMedicalstaffs.Ms_email = "testc@test.com";
            addMedicalstaffs.Ms_loginid = "testman";
            addMedicalstaffs.Ms_password = "20191209";

            addMedicalstaffshandler addMedicalstaffshandler = new addMedicalstaffshandler();
            int resp2 = addMedicalstaffshandler.addNewMedicalStaff(databaseConnertor.getconn(), addMedicalstaffs);
            Assert.AreEqual(1, resp2);
        }
    }
}
