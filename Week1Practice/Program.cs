using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARING VARIABLES
            // 1. Declare a string variable called "myName" and set it equal to your name
            string myName = "Nathan";

            // 2. Declare a number varible called "myAge" and set it equal to your age
            int myAge = 26;

            // 3. Declare a boolean value called "myBool" and set it equal to true or false;
            bool myBool = true;

            // 4. Declare a new list of strings called "productsList" and set it equal to "basketball", "baseball glove", "tennis shoes", "hockey puck"
            List<string> productList = new List<string>(){"basketball", "baseball glove", "tennis shoes", "hockey puck"};
            


            // PRINTING VARIABLES TO THE CONSOLE USING CONSOLE.WRITELINE()
            // 1. Print your name to the console using the format: "My name is <myName> and I'm a beast of a programmer"
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer!");
            // 2. Print out your age to the console using the format: "I am <myAge> years awesome."
            Console.WriteLine("I am " + myAge + " years awesome.");
            // 3. Print out your boolean value using the format: "I set my boolean value equal to <myBool>"
            Console.WriteLine("I set my boolean value equal to " + myBool);
            // 4. Using a For loop, print out each value in productsList.
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList[i]);
            }
            //breaks to make execution easier to read
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            // FOR LOOP PRACTICE
            // 1. Create a for loop that prints out the numbers 1 to 10.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            // 2. Create a for loop that prints out the numbers 10 to 1.
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            // 3. Create a for loop that prints out the numbers 10 to 30, only printing the even numbers
            for (int i = 10; i <= 30; i += 2)
            {
                Console.WriteLine(i);
            }
            // 4. Create a for loop that prints out the numbers 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            for (int i = 100; i >= 75; i -= 5)
            {
                Console.WriteLine(i);
            }
            //for ease of use
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();


            // WHILE LOOP PRACTICE
            int while1 = 1;
            int while2 = 10;
            int while3 = 15;
            int while4 = 100;
            int while5 = 0;
            // 1. Create a while loop that prints out the numbers from 1 to 10.
            while (while1 <= 10)
            {
                Console.WriteLine(while1);
                while1++;
            }
            // 2. Create a while loop that prints out the numbers from 10 to 1.
            while (while2 >= 1)
            {
                Console.WriteLine(while2);
                while2--;
            }
            // 3. Create a while loop that prints out the numbers from 15 to 30, only printing the even numbers
            while (while3 <= 30)
            {
                Console.WriteLine(while3);
                while3 += 2;
            }
            // 4. Create a while loop that prints out the numbers from 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            while (while4 >= 75)
            {
                Console.WriteLine(while4);
                while4 -= 5;
            }
            // 5. Create a while loop that prints out the numbers from 1 to 10 until it reaches one that is divisible by 4.
            while (while5 <= 10)
            {
                while5++;
                Console.WriteLine(while5);
                
                if (while5 % 4 == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();



            // PUTTING IT TOGETHER
            // Use either FOR or WHILE loops to accomplish the following:
            // 1. Print out the number of letters in your name using the format: "My name, <myName>, has <number of letters> in it."
            int nameCounter = 0;
            int productCounter = 0;

            for (int i = 0; i < myName.Length; i++){
                nameCounter++;
            }
            
                Console.WriteLine("My name, " + myName + ", has " + nameCounter + " letters in it.");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.WriteLine();

            // 2. Print out the number of items in your list using the format: "My product list has <number of items> in it."
            for (int i = 0; i < productList.Count; i++){
                productCounter++;
            }
            Console.WriteLine("My product list has " + productCounter + " items in it.");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            // 3. Print out the number of letters of each item in productsList using the format: "<product> has <number of letters> in it."
           //This is what I thought 3. was asking for
            //int totalLength = productList.Sum(product => product.Length);
            //Console.WriteLine(totalLength);
            for (int i = 0; i < productList.Count; i++)
            {

                 
                Console.WriteLine(productList[i] + " has " + productList[i].Length + " letters in it."  );
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();


                // DECLARING AND CALLING FUNCTIONS
                // 1. Create a function called "Greeting" that takes one string parameter called "name".  This function will print "Hello <name>"
                // 2. Call the Greeting function by passing in "Geronimo Jackson" as your parameter.
                // 3. Call the Greeting function by passing in myName as your parameter.
                Greeting("Geronimo Jackson");
            Greeting(myName);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

             
            // 4. Create a function called "DoubleIt" that takes one integer parameter called "number".  This function will print "<number> doubled is <number * 2>"
            // 5. Call your DoubleIt Function by passing in 1337 as your parameter.
            // 6. Call your DoubleIt function by passing in myAge as your parameter.
            DoubleIt(1337);
            DoubleIt(myAge);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();


            // 7. Create a function called "Multiply" that takes two integer parameters called "num1" and "num2".  This function will print "<num1> times <num2> is <num1 * num2>"
            // 8. Call your Multiply function by passing in 2 and 8 as your parameters.
            // 9. Call your Multiply function by passing in 3 and myAge as your parameters.
            Multiply(2, 8);
            Multiply(3, myAge);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            // 10. Create a function called "LoopThis" that takes two integer parameters called "startNum" and "endNum".  
            //      This function will print out: 
            //          a. "I'm looping from <startNum> to <endNum>."  
            //          b. The numbers from startNum to endNum, one per line.
            // 11. Call your LoopThis function by passing in 20 and 30 as your parameters.
            // 12. Call your LoopThis function by passing in 0 and myAge as your parameters.
            LoopThis(20, 30);
            LoopThis(0, myAge);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            // 13. Create a function called "SuperLoop" that takes three integer parameters called "startNum", "endNum", and "increment".  
            //      You will need to track how many times the loop has been executed in a variable called "loopCount".
            //      This function will print out: 
            //          a. "I'm looping from <startNum> to <endNum>, incrementing <increment> each time"  
            //          b. The numbers from startNum to endNum, one per line.
            //          c. "That loop was craaaaaazy, we looped X times"
            // 14. Call your SuperLoop function by passing in 0, 100, and 15 as your parameters.
            // 15. Call your SuperLoop function by passing in 0, 200, and myAge as your parameters.
            SuperLoop(0, 100, 15);
            SuperLoop(0, 200, myAge);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();


            //DECLARING AND CALLING RETURN FUNCTIONS
            // 1. Create a function called "NewGreeting" that takes one string parameter called "name".  This function will return a string in the format of "Hello, <name>"
            // 2. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter "Neil deGrasse-Tyson"
            //          EX: Console.WriteLine(FunctionCall("myParameter"));
            // 3. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter myName.
            Console.WriteLine(NewGreeting("Neil deGrasse-Tyson"));
            Console.WriteLine(NewGreeting(myName));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            
            // 4. Create a function called "TripleIt" that takes one integer parameter called "number".  This function will return the number times 3.
            // 5. Using your TripleIt function as part of the parameter for Console.WriteLine(), 
            //      call your TripleIt function using the parameter of 10 to print out "10 tripled is <TripleIt Function Call>"
            // 6. Using your TripleIt function as part of the parameter for Console.WriteLine(), 
            //      call your TripleIt function using the parameter of myAge to print out "<myAge> tripled is <TripleIt Function Call>"
            Console.WriteLine("10 tripled is " + TripleIt(10));
            Console.WriteLine(myAge + " tripled is " + TripleIt(myAge));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            // 7. Create a function called "RealMultiply" that takes two integer parameters called "num1", and "num2".  This function will return the num1 * num2.
            // 8. Using your RealMultiply function as part of the parameter for Console.WriteLine(), 
            //      call your RealMultiply function using the parameter of 5 and 10 to print out the returned value from your function.
            // 9. Using your RealMultiply function as part of the parameter for Console.WriteLine(), 
            //      call your RealMultiply function using the parameter of 2 and myAge to print out the returned value from your function.
            Console.WriteLine(RealMultiply(5,10));
            Console.WriteLine(RealMultiply(2, myAge));


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            //FUNCTION CALL MADNESS!
            // 1. Call your SuperLoop function using the following parameters:
            //      startNum = Call RealMultiply with the parameters 1, 5
            //      endNum = Call TripleIt with the parameter myAge
            //      increment = Call TripleIt with the parameter of myAge minus 10
            SuperLoop(RealMultiply(1, 5), TripleIt(myAge), TripleIt(myAge - 10));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            

            // 2. Call your SuperLoop function using the following parameters:
            //      startNum = Call RealMultiply with the parameters 1, and TripleIt with the parameter of 3.
            //      endNum = Call TripleIt with the parameter RealMultiply with the parameters: myAge, 7
            //      increment = Call TripleIt with the parameter of myAge minus RealMultiply with the parameters 2, 4.
            SuperLoop(RealMultiply(1, TripleIt(3)), TripleIt(RealMultiply(myAge, 7)), TripleIt(myAge - RealMultiply(2, 4)));


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();


        }


        //START -- FUNCTION DECLARATIONS 
        /// <summary>
        /// Greets the argument string
        /// </summary>
        /// <param name="name"></param>
        public static void Greeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        /// <summary>
        /// Doubles number passed as args
        /// </summary>
        /// <param name="number"></param>
        public static void DoubleIt(int number)
        {
            int number2 = number * 2;
            Console.WriteLine(number + " doubled equals " + number2);
        }

        /// <summary>
        /// Multiplies 2 numbers together
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " equals " + (num1 * num2));
        }

        /// <summary>
        /// Loops and displays between 2 numbers
        /// </summary>
        /// <param name="startNum"></param>
        /// <param name="endNum"></param>
        public static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum);

            while (startNum <= endNum)
            {
                Console.WriteLine(startNum);
                startNum++;
            }
        }
        /// <summary>
        /// Loops between 2 numbers using set increments    
        /// </summary>
        /// <param name="startNum"></param>
        /// <param name="endNum"></param>
        /// <param name="increment"></param>
        public static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = 0;
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + ", incrementing by " + increment + " each time.");
            while (startNum <= endNum)
            {
                Console.WriteLine(startNum);
                startNum += increment;
                loopCount++;
            }
            Console.WriteLine("That was craaaaaaazy, we looped " + loopCount + " times!");
        }


        public static string NewGreeting(string name)
        {
            return "Hello, " + name;
        }


        public static int TripleIt(int number)
        {
            return number * 3;
        }


        public static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }
        //Example function declaration
        static void MyFunction(string myParameter)
        {
            //Code block
        }

        //END   -- FUNCTION DECLARATIONS
    }
}
