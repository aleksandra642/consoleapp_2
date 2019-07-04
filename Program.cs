

using System;

namespace ConsoleApp2
    {
        class Program
        {
        static void Main()
        {

            Console.WriteLine("Hello World!");

            string first_name = "Bob";
            Console.WriteLine(first_name);

            string surname = "Smith";
            Console.WriteLine(surname);

            string cat = "Sonik";
            Console.WriteLine(cat);

            string dog = "Charly";
            Console.WriteLine(dog);

            string test = "Test one";
            Console.Write(test);

            string test_two = "Test two";
            Console.WriteLine(test_two);

            first_name = "Tom";
            Console.WriteLine(first_name);

            string sun = "Sun";
            Console.WriteLine(sun);

            string star = "Star";
            Console.WriteLine(star);

            string sentence = "\t \t \n are sutting outside";
            Console.WriteLine($"{dog} and {cat} {sentence}");

            Console.WriteLine($"\t {test} and {test_two} \n have been executed.");



            string name = "Tom";
            int age = 34;
            double height = 1.7;
            Console.WriteLine("Name: {0}  Age: {1}  Height: {2}м", name, height, age);

            Console.ReadKey();


            /* Byte*/

            byte b1 = 0;
            Console.WriteLine(b1);

            byte b2 = 255;
            Console.WriteLine(b2);

            byte b3 = 1;
            Console.WriteLine(b3);

            byte b4 = 254;
            Console.WriteLine(b4);

            byte b5 = 127;
            Console.WriteLine(b5);

            byte b6 = 117;
            Console.WriteLine(b6);

            byte b7 = 17;
            Console.WriteLine(b7);

            byte b8 = 47;
            Console.WriteLine(b8);

            byte b9 = 77;
            Console.WriteLine(b9);

            byte b10 = 107;
            Console.WriteLine(b10);

            /* SBYTE*/

            sbyte sb1 = -127;
            Console.Write(sb1);

            sbyte sb2 = -128;
            Console.Write(sb2);

            sbyte sb3 = 127;
            Console.Write(sb3);

            sbyte sb4 = 126;
            Console.Write(sb4);

            sbyte sb5 = 0;
            Console.Write(sb5);


            /*SHORT*/

            short sh1 = -32768;
            short sh2 = 32767;
            short sh3 = 0;
            short sh4 = 4;
            short sh5 = 7;
            Console.WriteLine($"\n {sh1} + {sh2} + {sh3} + {sh4} + {sh5}");


            /*USHORT

            ushort ush1 = 10;
            ushort ush2 = 65535;
            ushort ush3 = 111;
            ushort ush4 = 14;
            ushort ush5 = 100;
            Console.WriteLine("\n {0} {2} {3} {1} {5}", ush1, ush3, ush4, ush2, ush5);



            int i1 = 1;
            int i2 = 2;
            int i3 = 3;
            int i4 = 4;
            int i5 = 5;


                       Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
    */

            /*VIA CONSOLE*/

            string enter = "Enter name";
            Console.WriteLine(enter);
            string read = Console.ReadLine();

            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string last_name_1 = Console.ReadLine();

            Console.Write("Enter your age:");
            int age_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height:");
            double heightt = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Street name:");
            string address = Console.ReadLine();

            Console.Write("Enter your Streey number:");
            string street_number = Console.ReadLine();

            Console.Write($"First name: {read} Last name: {last_name_1} Age: {age_1} Height: {heightt} Weight: {weight} Wage: {salary}" +
                $"Address: {address} {street_number}");


            /*ADDING*/
            int x = 11;
            int z = 12;
            int y = x + z;
            Console.WriteLine($"\n {y}");

            int a = 11;
            int b = 12;
            int c = a + b;
            Console.WriteLine($"\n {c}");

            int d = 11;
            int e = 12;
            int f = d + e;
            Console.WriteLine($"\n {f}");

            int g = 11;
            int h = 12;
            int i = g + h;
            Console.WriteLine($"\n {i}");

            int j = 11;
            int k = 12;
            int l = j + k;
            Console.WriteLine($"\n {l}");

            int aa = 5;
            int bb = 3;
            int cc = aa - bb;
            Console.WriteLine(cc);

            int xx = 5;
            int zz = xx - 1;
            Console.WriteLine(zz);

            int rr = 3;
            int uu = rr * 6;
            Console.WriteLine(uu);

            int aw = 20;
            double az = aw / 3;
            Console.WriteLine(az);


            double at = 20;
            double ar = at / 3;
            Console.WriteLine(ar);

            int ty = 8;
            int tu = ty / 2;
            Console.WriteLine(tu);




        }
    }
    }



