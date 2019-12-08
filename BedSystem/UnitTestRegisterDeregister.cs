using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedSystem;
using Bed_System;
using MySql.Data.MySqlClient;

namespace BedSystem
{
    [TestClass]
    public class UnitTestRegisterDeregister
    {
        [TestMethod]
        public void TestRegisterDeregister()
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            string resp = databaseConnertor.connect();
            Assert.AreEqual("Done", resp);

            rederegister rederegister = new rederegister();
            rederegister.Ms_id = 1;
            rederegister.Register_date = DateTime.Now;
            rederegister.Register_time = "14:00";
            rederegister.Deregister_date = DateTime.Now;
            rederegister.Deregister_time = "20:00";

            rederegisterHandler rederegisterHandler = new rederegisterHandler();
            int resp2 = rederegisterHandler.addReDeregister(databaseConnertor.getconn(), rederegister);
            Assert.AreEqual(1, resp2);
        }
    }
}
