using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Tests
{
    public class ConversionTest
    {

        [Test]
        public void ConvertCelciusToFahrenheit_WhenInputIs0_Returns32()
        {
            //Arrange
            int convertedValue = 0;
            double expected = 32;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertCelciusToFahrenheit();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertCelciusToFahrenheit_WhenInputIs1_Returns33dot8()
        {
            //Arrange
            int convertedValue = 1;
            double expected = 33.8;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertCelciusToFahrenheit();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertCelciusToFahrenheit_WhenInputIsMinus1_Returns30dot2()
        {
            //Arrange
            int convertedValue = -1;
            double expected = 30.2;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertCelciusToFahrenheit();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertCelciusToKelvin_WhenInputIs0_Returns273dot15()
        {
            //Arrange
            int convertedValue = 0;
            double expected = 273.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertCelciusToKelvin();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertCelciusToKelvin_WhenInputIs1_Returns274dot15()
        {
            //Arrange
            int convertedValue = 1;
            double expected = 274.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertCelciusToKelvin();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertCelciusToKelvin_WhenInputIsMinus1_Returns272dot15()
        {
            //Arrange
            int convertedValue = -1;
            double expected = 272.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertCelciusToKelvin();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertFahrenheitToCelsius_WhenInputIs0_ReturnsMinus17dot78()
        {
            //Arrange
            int convertedValue = 0;
            double expected = -17.78;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertFahrenheitToCelsius_WhenInputIs1_ReturnsMinus17dot22()
        {
            //Arrange
            int convertedValue = 1;
            double expected = -17.22;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertFahrenheitToCelsius_WhenInputIsMinus1_ReturnsMinus18dot33()
        {
            //Arrange
            int convertedValue = -1;
            double expected = -18.33;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_WhenInputIs0_Returns256dot15()
        {
            //Arrange
            int convertedValue = 0;
            double expected = 256.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_WhenInputIs1_Returns256dot15()
        {
            //Arrange
            int convertedValue = 1;
            double expected = 256.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_WhenInputIsMinus1_Returns255dot15()
        {
            //Arrange
            int convertedValue = -1;
            double expected = 255.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertKelvinToCelsius_WhenInputIs0_ReturnsMinus273dot15()
        {
            //Arrange
            int convertedValue = 0;
            double expected = -273.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertKelvinToCelsius_WhenInputIs1_ReturnsMinus272dot15()
        {
            //Arrange
            int convertedValue = 1;
            double expected = -272.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertKelvinToCelsius_WhenInputIsMinus1_ReturnsMinus274dot15()
        {
            //Arrange
            int convertedValue = -1;
            double expected = -274.15;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_WhenInputIs0_ReturnsMinus459dot67()
        {
            //Arrange
            int convertedValue = 0;
            double expected = -459.67;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_WhenInputIs1_ReturnsMinus457dot87()
        {
            //Arrange
            int convertedValue = 1;
            double expected = -457.87;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_WhenInputIsMinus1_ReturnsMinus461dot47()
        {
            //Arrange
            int convertedValue = -1;
            double expected = -461.47;


            //Act
            double actual = (new Conversion(convertedValue)).ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
