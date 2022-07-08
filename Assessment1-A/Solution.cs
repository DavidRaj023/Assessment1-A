using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    public class Solution
    {
        public static void Execute()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter the Question number");
            var questionNumber = Console.ReadLine();

            switch (questionNumber)
            {
                case "1":
                    Console.WriteLine("you have entered one");
                    GetQuestion1();
                    break;
                case "2":
                    Console.WriteLine("you have entered two");
                    GetQuestion2Version2();
                    break;
                case "3":
                    Console.WriteLine("you have entered three");
                    GetQuestion3();
                    break;
                case "4":
                    Console.WriteLine("you have entered four");
                    GetQuestion4();
                    break;
                case "5":
                    Console.WriteLine("you have entered five");
                    GetQuestion5();
                    break;
                default:
                    Console.WriteLine("Please enter the number 1 to 5");
                    break;
            }
        }
        public static void GetQuestion1()
        {
            try
            {
                Console.WriteLine("Q1.Add the sequence of number in odd index\n");
                Console.WriteLine("Enter the sequence of number");

                String userInput = Console.ReadLine();
                //int length = userInput.Length;
                int result = 0;
                for (int i = 0; i < userInput.Length; i += 2)
                {
                    int temp = Convert.ToInt32(userInput[i].ToString());
                    result += temp;
                }
                Console.WriteLine("Given input: {0}", userInput);
                Console.WriteLine("Output: {0}", result);

                Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void GetQuestion2()
        {
            try
            {
                Console.WriteLine("Q2.Find the missing number In the array");
                Console.WriteLine("Enter the Array");
                Console.WriteLine("Example: 1 2 3 5");
                int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

                int n = array.Length;

                int total = (n + 1) * (n + 2) / 2;
                for (int i = 0; i < array.Length; i++)
                {
                    total -= array[i];
                }
                Console.WriteLine(total);

                Execute();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetQuestion2Version2()
        {
            try
            {
                Console.WriteLine("Q2.Find the missing number In the array");
                Console.WriteLine("Enter the Array");
                Console.WriteLine("Example: 1 2 3 5");
                int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                Console.WriteLine("Missing Numbers");
                Console.Write("[");
                for (int i = array.Min(); i <= array.Max(); i++)
                {
                    if (!array.Contains(i))
                    {
                        Console.Write(" " + i);
                    }
                }
                Console.WriteLine(" ]");

                Execute();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetQuestion3()
        {
            try
            {
                Console.WriteLine("Q3.Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.  ");
                Console.WriteLine("Enter array input: ");
                Console.WriteLine("Example: 9 3 5 2 32 22");
                int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

                Console.WriteLine("Enter target");
                int target = Convert.ToInt32(Console.ReadLine());

                for(int i = 0; i < array.Length; i++)
                {
                    for(int j = i+1; j< array.Length; j++)
                    {
                        if(target == array[j] + array[i])
                        {
                            Console.WriteLine("[ {0}, {1} ]", i, j);
                        }
                    }
                }

                Execute();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetQuestion4()
        {
            try
            {
                Console.WriteLine("Q4. Find the minimum and maximum elements in array");
                Console.WriteLine("Enter the Array");
                Console.WriteLine("Example: 9 3 5 2 32 22");
                int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

                Console.WriteLine("Min: " + array.Min());
                Console.WriteLine("Max: " + array.Max());

                Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetQuestion5()
        {
            Console.WriteLine("Q5.Separate the Prime and Non Prime number from the given array");
            Console.WriteLine("Enter array1 input: ");
            Console.WriteLine("Example: 9 3 5 2 32 22");
            int[] array1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

            Console.WriteLine("Enter array2 input: ");
            int[] array2 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int[] concat = array1.Concat(array2).Distinct().ToArray();
            int j;
            var prime = new List<int>();
            var nonPrime = new List<int>();
            for (int i = 0; i < concat.Length; i++)
            {
                if(concat[i] == 1)
                {
                    nonPrime.Add(concat[i]);
                }
                for (j = 2; j < concat[i]; j++)
                    if ((concat[i] % j == 0))
                    {
                        nonPrime.Add(concat[i]);
                        break;
                    }
                if (j == concat[i])
                {
                   prime.Add(concat[i]);
                }

            }

            Console.WriteLine(String.Format("Prime Number is : [ {0} ]", String.Join(", ", prime)));
            Console.WriteLine(String.Format("Non Prime Number is : [ {0} ]", String.Join(", ", nonPrime)));
        }
    }
}
