﻿using System;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 1

            // int 

            // Sum

            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine($"Result is: {c}");

            // Subtraction

            int d = 50;
            int e = 30;
            int result = d - e;
            Console.WriteLine($"Result of {d} - {e} is: {result}");

            // Divide

            int f = 10;
            int g = 2;
            int divideResult = f / g;
            Console.WriteLine();

            // Multiplication

            int h = 12;
            int j = 25;
            int multResult = h * j;
            Console.WriteLine(multResult);


            // string 

            string firstName = "James";
            string secondName = "Johnson";
            string fullName = firstName + " " + secondName;

            Console.WriteLine($"User first name is: {firstName}");
            Console.WriteLine($"User first lastname is: {secondName}");
            Console.WriteLine($"User fullname is: {fullName}");

            Console.Write("Enter your name: ");

            string askForName = Convert.ToString(Console.Read());

            Console.WriteLine($"Your name is {askForName}");

            // char 

            char ch = '$';

            Console.WriteLine($"Dollar sign is: {ch}");

            char cSharp = '#';

            Console.WriteLine($"Favorite programming language is C{cSharp}");

            char mailSym = '@';

            Console.WriteLine($"{mailSym} is used for mails");

            // byte 

            byte b1 = 0;
            byte b2 = 255;

            Console.WriteLine($"Min range of [byte] is {b1}");
            Console.WriteLine($"Max range of [byte] is {b2}");

            // sbyte

            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine($"Min range of [sbyte] is {sb1}");
            Console.WriteLine($"Max range of [sbyte] is {sb2}");

            // uint

            uint uin1 = 10;
            uint uin2 = 20;
            uint resultOf = uin1 + uin2;

            Console.WriteLine(resultOf);

            // short 

            short sOne = 1;
            short sTwo = 2;
            short sThree = 3;
            short sFour = 4;

            Console.WriteLine($"Shorts: {sOne},{sTwo},{sThree},{sFour}");

            // ushort

            ushort usOne = 100;
            ushort usTwo = 200;

            Console.WriteLine($"ushort :{usOne},{usTwo}");

            // bool

            bool engineStart = false;
            Console.WriteLine($"Car engine is not started - {engineStart}");
            engineStart = true;
            Console.WriteLine($"Now car engine is started - {engineStart}");

            bool ligtsIsOn = true;
            Console.WriteLine($"Lights are on - {ligtsIsOn}");
            ligtsIsOn = false;
            Console.WriteLine($"Now lights are off - {ligtsIsOn}");

            // CWL

            Console.WriteLine("WriteLine method print text in the console");
            Console.WriteLine(".NET is framework");
            Console.WriteLine("C# is programming language of .NET Platform");

            // CR

            int x = Console.Read();
            Console.WriteLine(x);

            // CW

            Console.Write("This method print text on the same line " +
                "not on new line!");

            // CRL

            Console.Write("Enter your name to print in the [Console]: ");
            string askForNameFromUser = Console.ReadLine();
            Console.WriteLine($"Your name is {askForNameFromUser}");

            // CRK

            Console.WriteLine("Click on the <Enter> key on your keyboard to close console");
            Console.ReadKey();

            // DateTime 

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            // CW , CRL 

            // Ask to user for firstname , secondname , userage

            Console.Write("Enter your first name: ");
            string userFirstName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter your second name: ");
            string userSecondName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            string fullAnswer = userFirstName + " " + userSecondName + " " + userAge;

            Console.WriteLine($"Your first name is: {userFirstName}");
            Console.WriteLine($"Your first name is: {userSecondName}");
            Console.WriteLine($"Your first name is: {userAge}");
            Console.WriteLine(fullAnswer);

            // Calculator

            // Addition

            Console.WriteLine("Addition numbers");

            Console.Write("Enter 1 number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2 number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            int totalResult = numberOne + numberTwo;
            Console.WriteLine($"Result of addition is: {totalResult}");

            // Subtraction

            Console.WriteLine("Subtraction numbers");

            Console.Write("Enter 1 number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2 number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result of subtraction is: {numOne - numTwo}");

            // Multiply

            Console.WriteLine("Multiply numbers");

            Console.Write("Enter 1 number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2 number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result of multiplying is: {num1 * num2}");

            // Divide

            Console.WriteLine("Divide numbers");

            Console.Write("Enter 1 number: ");
            int nOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2 number: ");
            int nTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result of dividing is: {nOne / nTwo}");
        }
    }
}

