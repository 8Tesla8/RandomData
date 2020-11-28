using System;
using System.Text;

namespace RandomDataCreator
{
    //RandomDataCreator
    public class Creator
    {
        private readonly Random _random = new Random();

        private readonly string _consonants = "bcdfghjklmnpqrstvwxyz";
        private readonly string _vowels = "aeiou";


        public string GenerateRandomBool()
        {
            bool randomBool = _random.Next(0, 2) > 0;
            return randomBool.ToString();
        }

        public string GenearateRandomIpAdress()
        {
            var data = new byte[4];
            _random.NextBytes(data);
            return (new System.Net.IPAddress(data)).ToString();
        }

        public string GenerateRandomDate()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;

            var date = start.AddDays(_random.Next(range));

            return date.ToString();
        }

        public string GenerateRandomNumber(int length)
        {
            var sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
                sb.Append(_random.Next(10));

            return sb.ToString();
        }

        public string GenerateRandomString(int length)
        {
            var sb = new StringBuilder();

            char ch;
            for (int i = 0; i < length; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * _random.NextDouble() + 65)));
                sb.Append(ch);
            }

            return sb.ToString();
        }

        public string GenerateRandomName(int length, bool upperCaseFirstLetter = true)
        {
            var sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                char character;

                if (i % 2 == 0)
                {
                    var index = _random.Next(0, _consonants.Length - 1);

                    character = _consonants[index];
                }
                else
                {
                    var index = _random.Next(0, _vowels.Length - 1);

                    character = _vowels[index];
                }

                if (upperCaseFirstLetter && i == 0)
                    character = char.ToUpper(character);

                sb.Append(character);
            }

            return sb.ToString();
        }
    }
}
