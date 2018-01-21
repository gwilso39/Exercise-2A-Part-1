using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A_Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following code I modified but also found some after searching the internet
            //Most of this code was found at w3resource.com to help me with the loop

            //Establishing a loop, declaring variables i, n and sum while setting sum to zero
            int i, n, sum = 0;

            //declaring variable avg as a double
            double avg;

            //this code asks the user for input of any 10 numbers
            Console.Write("Input 10 numbers between 0 and 100: ");

            //as the user inputs their numbers, the "for" loop initializes at 1
            //while less than or equal to 10 the loop continues and is incremented after
            for (i=1; i<=10;i++)
            {
                //When the user inputs their number, this write will designate where they are in sequence
                Console.Write("Number - {0} :", i);

                //while (Console.ReadLine())) - trying to work exceptions into test a number 0-100...

                //When the number is input, it is converted from a string to an int and added to variable n
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            //after the loop completes, avg is set by dividing the sum by 10
            avg = sum / 10.0;

            //This step pushes the text out with the user's sum and their average
            Console.Write("The sum of your 10 numbers is: {0}\nThe Average is: {1}\n", sum, avg);

            //This step tells you what letter grade the student would have based on the average
            //this is a simple "if, else if" style check against the calculated average
            if (avg >= 90)
            {
                Console.WriteLine("Your grade is an A");
            }
            else if (avg >=80)
            {
                Console.WriteLine("Your Grade is a B");
            }
            else if (avg >=70)
            {
                Console.WriteLine("Your Grade is a C");
            }
            else if (avg >=60)
            {
                Console.WriteLine("Your Grade is a D");
            }
            else if (avg <60)
            {
                Console.WriteLine("Your Grade is an F");
            }
            //Console.WriteLine("Are you ready to try something else?");
            
        }

        
            
            
        //The below code was code I was trying to apply and write initially based on an excercise in the book
        //I would have liked to work on it a little more but it was not working very well and it just
        //seemed it would be so much more efficient in a loop but I am not sure of the syntax of a loop yet.
            
        //{
            //(new Program()).numberSum();
        //}

        //void numberSum()
        /*{
            int firstNumber = readIntOne("Enter a number between 0 and 100: ");
            int secondNumber = readIntTwo("Enter a second number, also between 0 and 100: ");
            int thirdNumber = readIntThree("Enter a third number.  Again between 0 and 100: ");
            int fourthNumber = readIntFour("Enter a fourth number.  Yes, between 0 and 100: ");
            int fifthNumber = readIntFive("Enter a fifth number.  You should know by now, between 0 and 100: ");
            int sixthNumber = readIntSix("Enter another number.  Are you keeping count?  This is your 6th: ");
            int seventhNumber = readIntSeven("Enter yet another number.  Only 3 more after this one: ");
            int eighthNumber = readIntEight("Enter your eightth number.  We're still wanting these between 0 and 100: ");
            int ninthNumber = readIntNine("Enter your second to last nuber: ");
            int tenthNumber = readIntTen("Do I need to ask?  Just put it in here: ");
            writeSum(calculateSum(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, sixthNumber, seventhNumber, eighthNumber, ninthNumber, tenthNumber));
        }*/

        //the below code was also a feeble attempt at trying to make something work and playing around

        /*int a, b, c, d, e, f, g, h, j, k;
        Console.WriteLine("Enter ten numbers ");
        a=int.Parse(Console.ReadLine());
        b=int.Parse(Console.ReadLine());
        c=int.Parse(Console.ReadLine());
        d=int.Parse(Console.ReadLine());
        e=int.Parse(Console.ReadLine());
        f=int.Parse(Console.ReadLine());
        g=int.Parse(Console.ReadLine());
        h=int.Parse(Console.ReadLine());
        j=int.Parse(Console.ReadLine());
        k=int.Parse(Console.ReadLine());*/
    }
}
