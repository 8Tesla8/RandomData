using System;

namespace RandomDataCreator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Generation random data");


            var creator = new Creator();

            Console.WriteLine();
            Console.WriteLine(" IP Adress:");
            Console.WriteLine(creator.GenearateRandomIpAdress());
            Console.WriteLine(creator.GenearateRandomIpAdress());
            Console.WriteLine(creator.GenearateRandomIpAdress());


            Console.WriteLine();
            Console.WriteLine(" Date:");
            Console.WriteLine(creator.GenerateRandomDate());
            Console.WriteLine(creator.GenerateRandomDate());
            Console.WriteLine(creator.GenerateRandomDate());


            Console.WriteLine();
            Console.WriteLine(" Number:");
            Console.WriteLine(creator.GenerateRandomNumber(5));
            Console.WriteLine(creator.GenerateRandomNumber(5));
            Console.WriteLine(creator.GenerateRandomNumber(5));


            Console.WriteLine();
            Console.WriteLine(" String:");
            Console.WriteLine(creator.GenerateRandomString(5));
            Console.WriteLine(creator.GenerateRandomString(5));
            Console.WriteLine(creator.GenerateRandomString(5));


            Console.WriteLine();
            Console.WriteLine(" Name:");
            Console.WriteLine(creator.GenerateRandomName(5));
            Console.WriteLine(creator.GenerateRandomName(5));
            Console.WriteLine(creator.GenerateRandomName(5));


            Console.WriteLine();
            Console.WriteLine(" Bool:");
            Console.WriteLine(creator.GenerateRandomBool());
            Console.WriteLine(creator.GenerateRandomBool());
            Console.WriteLine(creator.GenerateRandomBool());
        }
    }
}
