using CarClassLibary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obli1AnnSofieTests
{
    [TestClass()]
    public class CarTests
    {
        private Car car = new Car { Id = 1, Model = "Tesla", Price = 1000000, LicensePlate = "AB3053" };
        private Car carZero = new Car { Id = 0, Model = "Opel", Price = 80000, LicensePlate = "CF9895" };
        private Car carModelShort = new Car { Id = 2, Model = "Olé", Price = 1000, LicensePlate = "OP1010" };
        private Car carNegativePrice = new Car { Id = 3, Model = "Fiat Panda", Price = -12000, LicensePlate = "CP9053" };
        private Car carLicensePlate2Short = new Car { Id = 4, Model = "Peugeot", Price = 40500, LicensePlate = "BI" };
        private Car carLicensePlate2Long = new Car { Id = 5, Model = "Lupo", Price = 90050, LicensePlate = "TYHFE8064" };

        [TestMethod()]
        public void ValidateIdTest()
        {
            car.ValidateId();
            Assert.ThrowsException<ArgumentException>(() => carZero.ValidateId());
        }

        [TestMethod()]
        public void ValidateModelTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carModelShort.ValidateModel());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carNegativePrice.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carLicensePlate2Short.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carLicensePlate2Long.ValidateLicensePlate());
        }
    }

}