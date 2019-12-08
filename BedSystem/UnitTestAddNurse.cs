using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedSystem;
using Bed_System;
using MySql.Data.MySqlClient;

namespace BedSystem
{
    [TestClass]
    public class UnitTestAddNurse
    {
        [TestMethod]
        public void TestAddNurse()
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            string resp = databaseConnertor.connect();
            Assert.AreEqual("Done", resp);

            addNurses addNurses = new addNurses();
            addNurses.S_position = "Nurse";
            addNurses.S_firstName = "Test";
            addNurses.S_lastName = "Man";
            addNurses.S_dob = DateTime.Now;
            addNurses.S_age = 40;
            addNurses.S_contact = 171234567;
            addNurses.S_email = "testc@test.com";
            addNurses.S_loginid = "testman";
            addNurses.S_password = "20191209";

            addNursesHandler addNursesHandler = new addNursesHandler();
            int resp2 = addNursesHandler.addNewNurse(databaseConnertor.getconn(), addNurses);
            Assert.AreEqual(1, resp2);
        }
    }
}
