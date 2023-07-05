using System;

namespace ExtensionsMethodsMiniAppHomework
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
        {
            bool isValidInt = false;
            bool isInValidRange = false;
            int output = 0;

            while (!isValidInt || !isInValidRange)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);
                isInValidRange = (output >= minValue && output <= maxValue);
            }
            return output;
        }
    }
}
