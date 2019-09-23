using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1");
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);
            Console.Write("\n");

            Console.WriteLine("Problem 2");
            int n2 = 5;
            printSeries(n2);
            Console.Write("\n");

            Console.WriteLine("Problem 3");
            int n3 = 5;
            printTriangle(n3);
            Console.Write("\n");

            Console.WriteLine("Problem 4");
            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            Console.WriteLine("Could not get an answer for problems 5&6");
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            //int[] r5 = displayArray(arr1, arr2);
            //displayArray(r5);
            

            /*
            //Puzzle Problem
            Console.WriteLine("Let's Do Math...With Words....");
            Console.WriteLine("For this problem, enter 2 input strings and 1 output string");
            Console.WriteLine("The program is designed to give the values of each character in the strings");

            Console.Write("Enter your first input word: ");
            string input_string_1 = Console.ReadLine();

            Console.Write("Enter your second input word: ");
            string input_string_2 = Console.ReadLine();

            Console.Write("Enter an output string: ");
            string output_string = Console.ReadLine();

            Console.WriteLine("Here are the results: ");
            solvePuzzle(input_string_1, input_string_2, output_string);

            */
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                bool isSelfDividing(int i) 
                {
                    var num = i;// eg 128
                    while (num > 1)// > 1, as 1 is always self dividing num.
                    {
                        var reminder = num % 10; // 128%10 = 8
                        if (reminder == 0 || i % reminder != 0) // if reminder is 0 or 128%8!=0  then its not self dividing
                        {
                            return false;
                            
                        }
                        num = num / 10;// cropping last digit ->prints without the remainder = 12
                    }
                    return true;
                    
                }

                for (int i = x; i <= y; i++)
                {

                    if(isSelfDividing(i) == true) 
                    {
                        Console.Write(i + ", ");
                    }
                    
                                       

                }                                           
                

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            // a do while loop was the way I chose to saolve this problem 
            // I converted a variable into a string to use to eventually write out the repeating values based off of a 
            // counter algorithm that stopped based off of the quantity of the variable in the loop
            try
            {               

                for (int i = 1; i <= n; i++)  //n=5 , number working with is 2...
                {
                    string i_string = Convert.ToString(i); //string "1"
                    int counter = i; //5

                    do
                    {
                                               
                        Console.Write(i_string + ", "); //1
                        counter--;
                    }
                    while (counter != 0);

                }
                               

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
                // This code takes n and prints that number of asterisks to the top row 
                // Because of the shape and matrix of problems like this the number of asterisks is equal to 2(n) - 1 
                //It subsequently adds a space on both sides of the asterisks after the first row to decrease the number of asterisks incrementally

                for (int i = 0; i < n; i++)  
                {
                    for (int j = n; j <= n + i; j++)   
                        Console.Write(" ");
                    for (int j = 1; j <= 2 * (n-i) - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
                                                             

                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
                //use a foreach in both arrays to match each Jewel type with the stones that you have, if it's a match, it gets printed

                foreach (int jewel in J)
                {
                    foreach (int stone in S)
                    {
                        if (stone == jewel)
                        {
                            Console.Write(stone + ", ");
                        }
                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static void displayArray(int[]a, int[]b)
        {
            try
            {
                // Write your code here

                // The logic I was attempting was to concatenate the integer values in both arrays to get two numbers 
                // so for example 1,2,3,11 would equal 12311....
                // Then I wanted to take every combination from that value slicing off the first number 
                // 1,2,3,11....12311 -> 12311, 2311, 311, 11, 1
                // 2,3,4....234 - > 234, 34, 4
                // If you do that for both array values and divide each value of the larger array by every number of the smaller array

                // 12311/234, 12311/34, 12311/4, 2311/234, 2311/34, 2311/4.........
                // and take the combination(s) that equal 1 and then of those values find which one is the largest by comparing the numberator (or denominator)
                // that would give the largest sequence
                // Then I would comma seperate that number out to find the largest sequence 
                // The other parameter is if the array values go past 10
                // In this case, there would need to be a statement where a comma is placed if the combination of the characters is not seperated by adding 1



                //....Attempted Code.......
                // turn both arrays into continuous strings
                /*
                string continuous_result_a = string.Join("", a);
                string continuous_result_b = string.Join("", b);

                Console.WriteLine(continuous_result_a);
                Console.WriteLine(continuous_result_b);


                //comma seperated array values
                string result_a_comma_sep = string.Join(", ", a);
                string result_b_comma_sep = string.Join(", ", b);

                Console.WriteLine(result_a_comma_sep);
                Console.WriteLine(result_b_comma_sep);


                //write series as one continuous value
                int arr1_value = int.Parse(continuous_result_a);
                int arr2_value = int.Parse(continuous_result_b);

                Console.WriteLine(arr1_value);
                Console.WriteLine(arr2_value);

                //finding out which has more digits...in this case which num is larger
                int larger_int;
                int smaller_int;


                if (arr1_value > arr2_value)
                {
                    larger_int = arr1_value;
                    smaller_int = arr2_value;
                }
                else
                {
                    larger_int = arr2_value;
                    smaller_int = arr1_value;

                }

                //Convert big/small int to string

                string big_string = Convert.ToString(larger_int);
                string small_string = Convert.ToString(smaller_int);


                //larger strings that are going to be added to...
                string larger_int_modified = "";
                string smaller_int_modified;

                int character_counter = 0;


                while (character_counter <= big_string.Length)
                {
                    for (int i = 0; i >= big_string.Length; i++)
                    {
                        larger_int_modified += Convert.ToString(result_a_comma_sep[i]);
                        character_counter++;
                    }
                }


                Console.WriteLine(larger_int_modified);


                //The answer, seperated by commas...have to account for if the values go past 9......
                int largest_num;
                */
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

           
        }

        public static void solvePuzzle(string a, string b, string c)
        {
            try
            {
                // Write your code here

                Console.WriteLine("the variables are " + a + b);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
} 


 