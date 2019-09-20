using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieClassInstantiation()
        {
            Cookie cookie = new Cookie();

            cookie.Name = "Snickerdoodle";
            cookie.BatchSize = 12;
            cookie.Direction = "mix stuff together and bake.";
            cookie.Ingredient = "cinnamon and sugar and butter.";
            cookie.Size = "big";
            cookie.Shape = "round";

            Cookie cookieTwo = new Cookie();

            cookieTwo.Name = "Lemon";
            cookieTwo.BatchSize = 24;
            cookieTwo.Direction = "bake em";
            cookieTwo.Ingredient = "lemons and powdered sugar and white chocolate";
            cookieTwo.Size = "small";
            cookieTwo.Shape = "semi-circle";

            Cookie cookieThree = new Cookie("Chocolate Chip", "Butter and Chocolate", "stuff", "Shmedium", "circle", 18, true);
            cookieThree.SetPrice();
        }


        [TestMethod]
        public void VehicleClassInstantiation()
        {
            Vehicle vehicle = new Vehicle("Fiat", "500 Pop", 64000d, "gray", "162736265", 2017, 8, "Clown Car");

            vehicle.StopVehicle();
            Assert.IsFalse(vehicle.IsRunning);

            Vehicle vehicleTwo = new Vehicle("Toyota", "Camry", 175000d, "blue", "9876657657", 2006, 5, "Sensible Sedan");

            vehicleTwo.StartVehicle();
            Assert.IsTrue(vehicleTwo.IsRunning);


        }
    }
}
