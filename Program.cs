using System;
using System.Linq;

namespace W3Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            //Declaring variables:

            double num = 2.2D; //"D" stands for "double" and should be at the end of line. 
            Console.WriteLine(num);

            bool onMailingList = true;
            Console.WriteLine("Are you on mailing list: " + onMailingList);

            //Declaring variable without assigning value, and assigning value later. 

            char letter;
            letter = '2';
           
            Console.WriteLine(letter);

            string fName;
            string lName;
            fName = "Vicky";
            lName = "Jones";
            string fullName;
            fullName = fName + lName;
            Console.WriteLine("Welcome " + fullName);

            int x = 6, y = 4, a = 1;
            Console.WriteLine(x + y + a);

            //Using "contant" keyword to make value unchangeable and read-only.

            const char endLetter = 'z';
            Console.WriteLine(endLetter);

            //Type casting AKA type conversion. Implicit

            int myInt = 9;
            long myLongInt = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myLongInt);

            //Type casting - Explicit

            double myDouble = 9.8956214368;
            int myInt1 = (int)myDouble; //done manually by placing type in parenthesis in
            // front of value. 

            Console.WriteLine(myDouble); //output is 9.8956214368
            Console.WriteLine(myInt1);// output is 9

            //Type converstion methods

            int myInt2 = 4;
            double myDouble1 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt2));//output 4 as a string
            Console.WriteLine(Convert.ToDouble(myInt2));//output 4
            Console.WriteLine(Convert.ToInt32(myDouble1));// output 5
            Console.WriteLine(Convert.ToString(myBool));// output true (as string)

            Console.WriteLine("Enter your user name:");
            string userName = Console.ReadLine(); //always returns a string. 
            Console.WriteLine("Hello " + userName + ", great to see you again");

            Console.WriteLine("Please enter your age:");
            string age = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            //Arithmetic operators

            int aa = 5;
            int b = 2;

            var ans = 5 % 2; // returns the division remainder - equals 1
            Console.WriteLine(ans);

            // Incrementing operator

            aa++; // take the value of "aa" and increment it by one. Ans: 6
            Console.WriteLine(aa);

            //Decrementing Operator

            b--;
            Console.WriteLine(b);

            //Math Methods

            int c = 1002;
            int d = 1001;
            int e = 2;

            Console.WriteLine(Math.Max(c, d));
            Console.WriteLine(Math.Min(c, e));

            

            //String Methods

            string Name = "vicky"; //actually an object
            Console.WriteLine("The length of vicky is " + Name.Length);

            string ans = Name.ToUpper();
            Console.WriteLine(ans);

            string LName = " jones";
            string fullName = string.Concat(Name, LName);
            Console.WriteLine(fullName);

            //String Interpolation

            Console.WriteLine("Full name is {0}{1}", Name,LName);

            Console.WriteLine($"Full name is {Name} {LName}");

            string country1 = "india";
            string country2 = "Australia";

            Console.WriteLine("I would like to live in {0} and NOT {1}", country1, country2);

            Console.WriteLine($"The best country is {country2}, the second best is {country1}");

            Console.WriteLine("The first letter of India is "+ country1[0]);
            char firstLetter = country1[0];
            Console.WriteLine("The first letter of India is " + firstLetter);
            Console.WriteLine("The last letter in Australia is " + country2[8]);

            //"Index of" method

            Console.WriteLine(country1.IndexOf("i"));

            //"substring" method

            string fullSent = country1 + country2;
            Console.WriteLine(fullSent);

            int charPos = fullSent.IndexOf("A");
            string LastSent = fullSent.Substring(charPos);
            Console.WriteLine(LastSent);

            string fName = "Vicky";
            string lName = "Jones";

            string fullName1 = fName + lName;

            int charPosi = fullName1.IndexOf("J");
            Console.WriteLine(fullName1.Substring(charPosi));

            Console.WriteLine(fullName1.Substring(fullName1.IndexOf("J")));

           // Escape characters

            Console.WriteLine("I enjoy \"vacationing\" with the family");
            Console.WriteLine(" \"Get out\" he said, \'I am going to hurt you\'");

            Console.WriteLine("Please bring: \t A table \t A chair \nAnd a blanket");
            string text = "Hello World\b!";
            Console.WriteLine(text);

            // Booleans

            int a = 12;
            int b = 13;

            Console.WriteLine(a < b); //output False
            Console.WriteLine(12 < 12);//output False
            Console.WriteLine(a == b);//output True
            Console.WriteLine(12 == 12);//output True
            Console.WriteLine(a == 1); //output False

            // If statement

            if (a == 12)
            {
                Console.WriteLine("a is equal to 12"); //statement ends with semi-colon
            }

            if (2 > 1)
            {
                Console.WriteLine("2 is greater than 1");
            }

            // Else statement

            if(a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else // gets executed if condition is False
            {
                Console.WriteLine("a is not equal to b");
            }
            */
            // Else/if statement

            int outsideTemp = 79;
            int insideTemp = 66;


            if (outsideTemp == insideTemp)
            {
                Console.WriteLine("Temperature is just right");
            }

            else if (outsideTemp < insideTemp)
            {
                Console.WriteLine("It is colder outside than inside");
            }

            else
            {
                Console.WriteLine("It is colder inside than outside");
            }

            // Ternary function
            string answer = (outsideTemp == insideTemp) ? "Outside temp same as inside" : "Outside temp not same as inside";

            string answer2 = (outsideTemp > insideTemp) ? "It is hotter outside" : "It is hotter inside";
            Console.WriteLine(answer2);
            int num3 = 4;
            bool isEven;

            isEven = (num3 % 2 == 0) ? true : false;

            Console.WriteLine(isEven);

            Console.WriteLine((num3 % 3 == 0) ? true : false);

            switch (num3)
            {
                case 1:
                    Console.WriteLine("blah");
                    break;

                case 2:
                    Console.WriteLine("blah blah");
                    break;

                case 3:
                    Console.WriteLine("number is three");
                    break;

                default:
                    Console.WriteLine("This is the default value");
                    break;


            }


            string keyword = "bingo";

            switch (keyword)
            {
                case "horse":
                    Console.WriteLine("This is not bingo");
                    break;

                case "cat":
                    Console.WriteLine("This is not bingo");
                    break;

                default:
                    Console.WriteLine("It appears there was no bingo");
                    break;



            }


            /*int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            //Do/While loop (variant of while loop. Notice how it executes at least once,
            //because conditions are tested after.)
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }

            while (i < 0);

            // For loop

            for (int a = 0; a < 10; a = a + 2)
            {
                Console.WriteLine(a); // output 0,2,4,6,8
            }

            string[] horses = { "Phar Lap","Bobby","Jumpie","Red"};

            Array.Sort(horses);
            foreach (string horse in horses)
            {
                Console.WriteLine(horse);
            }


            int[] numbers = { 2, 22, 101, 33, 12 };
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());

            Array.Sort(numbers);

            for (int c = 0; c <numbers.Length; c++)
            {
                Console.WriteLine(c);
            }


            Console.WriteLine(numbers[1]);
            numbers[0] = 1;

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            for (int y = 0; y < numbers.Length; y++)
            {
                Console.WriteLine(numbers[y]);
            }

            // Creating an Array

            string []cars = { "BMW", "Ford", "Toyota" };
            string[] boats = new string[2];
            Console.WriteLine(boats.Length);

            Console.WriteLine(numbers.Length);

            /*
            foreach (string item in horses)
            {
                Console.WriteLine(item);
            }

            for (int b = 0; b < 10; b++)
            {
                
                if (b == 4)
                {
                    continue;
                }

                Console.WriteLine(b);
            }

            int x = 2;
            while(x < 10)
            {
                
               

                if (x == 4)
                {
                    continue;
                }
                Console.WriteLine(x);
                x++;
            }
            */
                    
        }


       

    }
}
