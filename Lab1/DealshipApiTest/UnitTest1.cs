using Lab1A.Data;
using Lab1A.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DealshipApiTest
{
    [TestClass]
    public class UnitTest1
    {

        [ClassInitialize]
        public static void Initialize(TestContext tc)
        {
            DealershipMgr.AddDealership( new Dealership { ID = 0, Name = "Kia", Email = "kia@kia.com", PhoneNumber = "1234567890" });
            DealershipMgr.AddDealership(new Dealership { ID = 1, Name = "Honda", Email = "Honda@honda.com", PhoneNumber = "0987654321" });
        }

        /// <summary>
        /// Test the get dealership via passing valid Dealership ID
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestPassGetDealership()
        {
            Dealership dealership1 = DealershipMgr.GetDealership(0);
            Assert.AreEqual("Kia", dealership1.Name);
            Assert.AreEqual("kia@kia.com", dealership1.Email);
            Assert.AreEqual("1234567890", dealership1.PhoneNumber);

            Dealership dealership2 = DealershipMgr.GetDealership(1);
            Assert.AreEqual("Honda", dealership2.Name);
            Assert.AreEqual("Honda@honda.com", dealership2.Email);
            Assert.AreEqual("0987654321", dealership2.PhoneNumber);
        }

        /// <summary>
        /// Tests the add dealership via pass valid new dealership
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestPassAddDealership()
        {
            DealershipMgr.AddDealership(new Dealership { ID = 2, Name = "Chevrolet", Email = "chevy@chevy.com", PhoneNumber = "9059051234" });
            Dealership dealership3 = DealershipMgr.GetDealership(2);
            Assert.AreEqual("Chevrolet", dealership3.Name);
            Assert.AreEqual("chevy@chevy.com", dealership3.Email);
            Assert.AreEqual("9059051234", dealership3.PhoneNumber);
        }

        /// <summary>
        /// Tests getting the whole dealership list
        /// Note: Cannot test to fail due to this function always returning a List<Dealership> even if the list is empty
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestPassGetDealershipList()
        {
            List<Dealership> dealershipList = DealershipMgr.GetDealershipList();
            Assert.IsInstanceOfType(dealershipList, typeof(List<Dealership>));
            int count = dealershipList.Count;
        }

        /// <summary>
        /// Tests delete via passing valid Dealership ID to delete
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestPassDeleteDealership()
        {
            DealershipMgr.DeleteDealership(1);
            Assert.IsNull(DealershipMgr.GetDealership(1));
        }

        /// <summary>
        /// Tests Update via passing valid Dealership ID and new dealership
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestPassUpdateDealership()
        {
            DealershipMgr.UpdateDealership(0, new Dealership { ID = 0, Name = "Honda", Email = "Honda@honda.com", PhoneNumber = "0987654321" });
            Assert.AreEqual("Honda", DealershipMgr.GetDealership(0).Name);
            Assert.AreEqual("Honda@honda.com", DealershipMgr.GetDealership(0).Email);
            Assert.AreEqual("0987654321", DealershipMgr.GetDealership(0).PhoneNumber);
        }

        /// <summary>
        /// Tests that you cannot get a dealership that doesn't exist 
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestFailGetDealership()
        {
            Dealership dealership1 = DealershipMgr.GetDealership(3);
            Assert.IsNull(dealership1);
        }

        /// <summary>
        /// Tests that you cannot add a dealership with an ID that's already use
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestFailAddDealership()
        {
            DealershipMgr.AddDealership(new Dealership { ID = 0, Name = "Chevrolet", Email = "chevy@chevy.com", PhoneNumber = "9059051234" });
            Assert.AreEqual("Honda", DealershipMgr.GetDealership(0).Name);
            Assert.AreEqual("Honda@honda.com", DealershipMgr.GetDealership(0).Email);
            Assert.AreEqual("0987654321", DealershipMgr.GetDealership(0).PhoneNumber);
        }

        /// <summary>
        /// Tests that you cannot delete a dealership that doesn't exist
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestFailDeleteDealership()
        {
            DealershipMgr.DeleteDealership(1);
        }

        /// <summary>
        /// Tests that you cannot update a dealership ID doesn't exist
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ApiTestFailUpdateDealership()
        {
            DealershipMgr.UpdateDealership(4, new Dealership { ID = 4, Name = "Honda", Email = "Honda@honda.com", PhoneNumber = "0987654321" });
            Assert.IsNull(DealershipMgr.GetDealership(4));
        }
    }
}
