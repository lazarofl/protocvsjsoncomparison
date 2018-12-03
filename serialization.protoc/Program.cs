using Google.Protobuf;
using System;
using System.IO;
using static Person.Types;

namespace serialization.protoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");

            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

            stopWatch.Start();

            for (int i = 1; i <= 10000000; i++)
            {
                if (i % 1000 == 0)
                    Console.WriteLine($"iteration: {i}");

                var phoneNumber = new PhoneNumber
                {
                    Number = "(11) 12345-6789",
                    Type = PhoneType.Mobile
                };
                var person = new Person()
                {
                    Name = "Lazaro",
                    Id = 123,
                    Email = "email@email.com",
                    Phone = phoneNumber
                };

                var bytes = person.ToByteArray();

                var person_frombytes = new Person();
                person_frombytes.MergeFrom(bytes);
            }

            stopWatch.Stop();

            Console.WriteLine($"ElapsedMilliseconds: {stopWatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
