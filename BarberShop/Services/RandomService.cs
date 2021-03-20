using System;
using System.Text;

namespace BarberShop
{
    class RandomService
    {
        private static Random _randomizer;

        static RandomService()
        {
            _randomizer = new Random(Environment.TickCount);
        }

        public static string RandomString(int length)
        {
            StringBuilder result = new StringBuilder();

            char[] data = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

            for (int i = 0; i < length; i++)
            {
                result.Append(data[_randomizer.Next(0, data.Length - 1)]);
            }

            return result.ToString();
        }
    }
}
