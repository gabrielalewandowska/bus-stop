using NUnit.Framework;
using System;
namespace bus_lab
{
    [TestFixture()]
    public class BusTest
    {
        private Bus bus1;
        private Person person1;

        [SetUp]
        public void Init()
        {
            bus1 = new Bus(22, "Ocean Terminal"); 
            person1 = new Person("Gaby", 27);
        }

        [Test()]
        public void TestBusHasNumber()
        {
            Assert.AreEqual(22, bus1.Number);
        }

        [Test()]
        public void TestCanSetBusNumber()
        {
            bus1.Number = 11;
            Assert.AreEqual(11, bus1.Number);
        }

        [Test()]
        public void TestBusHasDestination()
        {
            Assert.AreEqual("Ocean Terminal", bus1.Destination);
        }

        [Test()]
        public void TestBusCanDrive()
        {
            Assert.AreEqual("Brum brum!", bus1.Drive());
        }

        [Test()]
        public void TestPersonHasName()
        {
            Assert.AreEqual("Gaby", person1.Name);
        }

        [Test()]
        public void TestPersonHasAge()
        {
            Assert.AreEqual(27, person1.Age);
        }

        [Test()]
        public void TestBusHasPassengersArray()
        {
            Assert.AreEqual(0, bus1.Passengers.Count);
        }

        [Test()]
        public void TestBusStartsEmpty()
        {
            Assert.AreEqual(0, bus1.GetNumberOfPassengers());
        }

        [Test()]
        public void TestBusCanPickUpPassengers()
        {
            bus1.PickUp(person1);
            Assert.AreEqual(1, bus1.GetNumberOfPassengers());
            Assert.AreEqual(person1, bus1.Passengers[0]);
        }

        [Test()]
        public void TestBusCanDropOffPassengers()
        {
            bus1.PickUp(person1);
            bus1.DropOff(person1);
            Assert.AreEqual(0, bus1.GetNumberOfPassengers());
        }

        [Test()]
        public void TestCanEmptyBus()
        {
            bus1.PickUp(person1);
            bus1.Empty();
            Assert.AreEqual(0, bus1.GetNumberOfPassengers());
        }
    }
}
