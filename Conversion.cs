using System;

namespace Assignment02 {
    public class Conversion {

        private int convertedValue;

        public Conversion() {
            convertedValue = 1;
        }

        public Conversion(int userInput) {
            convertedValue = userInput;
        }

        public double ConvertCelciusToFahrenheit() {

            return Math.Round((double)convertedValue * 9 / 5 + 32, 2);
        }

        public double ConvertCelciusToKelvin() {
            return Math.Round(convertedValue + 273.15, 2);
        }
        public double ConvertKelvinToFahrenheit() {

            return Math.Round((convertedValue - 273.15) * 9 / 5 + 32, 2);
        }
        public double ConvertKelvinToCelsius() {

            return Math.Round(convertedValue - 273.15, 2);
        }
        public double ConvertFahrenheitToKelvin() {

            return Math.Round((convertedValue - 32) * 5 / 9 + 273.15, 2);
        }
        public double ConvertFahrenheitToCelsius() {

            return Math.Round((double)(convertedValue - 32) * 5 / 9, 2);
        }

    }
}