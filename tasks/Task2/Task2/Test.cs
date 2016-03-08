using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    public class Test
    {
        [Test]
        public void simpleTest()
        {
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void CanCreateCar()
        {
            var x = new Car(true, "blue", 50);

            Assert.IsTrue(x.Color == "blue");
            Assert.IsTrue(x.Fuel == true);
            Assert.IsTrue(x.Tank == 50);
        }

        [Test]
        public void CanCreateMotorbike()
        {
            var x = new Motorbike("green", 20);

            Assert.IsTrue(x.Color == "green");
            Assert.IsTrue(x.Tank == 20);
        }

        [Test]
        public void CannotUpdateMotorbikeWithNegativeTank()
        {
            Assert.Catch(() =>
            {
                var x = new Motorbike("blue", 20);
                x.ChangeTank(-20);
            });
        }

        [Test]
        public void CannotCreateMotorbikeWithNullTank()
        {
            Assert.Catch(() =>
            {
                var x = new Motorbike("blue", 0);
            });
        }

        [Test]
        public void CannotCreateCarWithNegativeTank()
        {
            Assert.Catch(() =>
            {
                var x = new Car(true, "blue", -50);
            });
        }

        [Test]
        public void CannotCreateCarWithEmptyColor()
        {
            Assert.Catch(() =>
            {
                var x = new Car( true,"", 50);
            });
        }

        [Test]
        public void CannotUpdateCarWithNegativeTank()
        {
            Assert.Catch(() =>
            {
                var x = new Car(true, "blue", 50);
                x.ChangeTank(-10);
            });
        }
    }
}
