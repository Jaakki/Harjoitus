using System;
using System.Collections.Generic;

namespace Harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            per1.name = "Seppo";
            per1.age = 29;
            per1.salary = 500;

            Person per2 = new Person();
            per2.name = "Titta";
            per2.age = 26;
            per2.salary = 450;

            Person per3 = new Person();
            per3.name = "Sauli";
            per3.age = 60;
            per3.salary = 5000;

            Console.WriteLine($"{per1.name} {per1.age} {per1.salary}");
            Console.WriteLine($"{per2.name} {per2.age} {per2.salary}");
            Console.WriteLine($"{per3.name} {per3.age} {per3.salary}");
            Console.WriteLine();

            per1.name = "Teppo";
            per1.age = 32;
            per1.salary = 800;

            per3.name = "Kuningas Sauli";
            per3.age = 70;
            per3.salary = 10000;

            Console.WriteLine($"{per1.name} {per1.age} {per1.salary}");
            Console.WriteLine($"{per2.name} {per2.age} {per2.salary}");
            Console.WriteLine($"{per3.name} {per3.age} {per3.salary}");
            Console.WriteLine();

            Person per4 = new Person();
            per4.name = "Pentti";
            per4.age = 13;

            Person per5 = new Person();
            per5.name = "Juuso";
            per5.age = 33;

            Console.WriteLine($"{per4.name} {per4.age}");
            Console.WriteLine($"{per5.name} {per5.age}");
            Console.WriteLine();

            Person juuso = new Person();
            juuso.name = "Juuso";

            Person pekka = new Person();
            pekka.name = "Pekka";
            pekka.friend = juuso;

            Person antti = new Person();
            antti.name = "Antti";
            antti.friend = pekka;

            Console.WriteLine($"{pekka.name} kaveri on {pekka.friend.name}. {antti.name} kaveri on {antti.friend.name}.");
            Console.WriteLine();

            List<string> Persons = new List<string>();
            Persons.Add(per1.name);
            Persons.Add(per2.name);
            Persons.Add(per3.name);
            Persons.Add(per4.name);
            Persons.Add(per5.name);

            List<int> Ages = new List<int>();
            Ages.Add(per1.age);
            Ages.Add(per2.age);
            Ages.Add(per3.age);
            Ages.Add(per4.age);
            Ages.Add(per5.age);

            foreach (var name in Persons)
            {
                Console.WriteLine(name);
            }

            int addedAges = 0;
            foreach (var age in Ages)
            {
                addedAges = addedAges + age;
                Console.WriteLine($"Ikä: {age}");
            }

            Console.WriteLine($"Yhteenlaskettu ikä: {addedAges}");

        }
    }
}
