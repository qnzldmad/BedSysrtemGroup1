using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bed_System;
using BedSystem;
using MySql.Data.MySqlClient;

namespace BedSystem
{
    [TestClass]
    public class UnitTestPatientRealTime
    {
        [TestMethod]
        public void TestPatientRealTime()
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            string resp = databaseConnertor.connect();
            Assert.AreEqual("Done", resp);

            realtimeclass realtimeclass = new realtimeclass();
            realtimeclass.P_id = 1;
            realtimeclass.P_systolic = 120;
            realtimeclass.P_diastolic = 80;
            realtimeclass.P_breathing = 20;
            realtimeclass.P_pulse = 60;
            realtimeclass.P_temperature = 36;

            realtimeHandler realtimeHandler = new realtimeHandler();
            int resp2 = realtimeHandler.addRealTime(databaseConnertor.getconn(), realtimeclass);
            Assert.AreEqual(1, resp2);
        }
    }
}
