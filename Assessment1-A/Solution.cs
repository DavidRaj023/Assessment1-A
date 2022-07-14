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
                    GetSumofOddIndex();
                    break;
                case "2":
                    Console.WriteLine("you have entered two");
                    FindMissingNumber();
                    break;
                case "3":
                    Console.WriteLine("you have entered three");
                    FindTargetIndex();
                    break;
                case "4":
                    Console.WriteLine("you have entered four");
                    GetMinAndMax();
                    break;
                case "5":
                    Console.WriteLine("you have entered five");
                    GetPrimeAndNonPrime();
                    break;
                default:
                    Console.WriteLine("Please enter the number 1 to 5");
                    Execute();
                    break;
            }
        }
        public static void GetSumofOddIndex()
        {
            // Input int only
            try
            {
                Console.WriteLine("Q1.Add the sequence of number in odd index\nEnter the sequence of number");

                string userInput = Console.ReadLine();
                
                int[] intArray = IntToArray(Convert.ToInt32(userInput));
                int result = 0;

                if (intArray.Length == 0 || intArray == null)
                {
                    Console.WriteLine("Please enter the valid input...");
                    GetSumofOddIndex();
                }

                for (int i = 0; i < intArray.Length; i += 2)
                {
                    int temp = Convert.ToInt32(intArray[i].ToString());
                    result += temp;
                }
                Console.WriteLine("Input: {0} \nOutput: {1}", userInput, result);

                Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void FindMissingNumber()
        {
            try
            {
                Console.WriteLine("Q2.Find the missing number In the array.\nEnter the array length");
                var arrayLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Array:\n(Example: 1 2 3 5)");

                //int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

                int[] userInput = new int[arrayLength];

                for(int i = 0; i < arrayLength; i++)
                {
                    userInput[i] = Convert.ToInt32(Console.ReadLine());
                }

                if (userInput.Length == 0 || userInput == null)
                {
                    Console.WriteLine("Please enter the valid input...");
                    FindMissingNumber();
                }
                
                var missingNumbers = new List<int>();

                for (int i = userInput.Min(); i <= userInput.Max(); i++)
                {
                    if (!userInput.Contains(i))
                    {
                        missingNumbers.Add(i);
                    }
                }

                Console.WriteLine("User Input: [{0} ]", String.Join(", ", userInput));
                Console.WriteLine(String.Format("Missing Numbers : [ {0} ]", String.Join(", ", missingNumbers)));
                if (missingNumbers.Count == 0)
                {
                    Console.WriteLine("There is no missing numbers");
                }
                Execute();

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void FindTargetIndex()
        {
            try
            {
                Console.WriteLine("Q3.Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.  ");
                Console.WriteLine("Enter the array length");
                
                var arrayLength = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter array input: \n(Example: 9 3 5 2 32 22)");
                
                int[] userInput = new int[arrayLength];
                for (int i = 0; i < arrayLength; i++)
                {
                    userInput[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Given input: [ {0}]", String.Join(",", userInput));
                Console.WriteLine("Enter target");
                int target = Convert.ToInt32(Console.ReadLine());

                
                for(int i = 0; i < userInput.Length; i++)
                {
                    for(int j = i+1; j< userInput.Length; j++)
                    {
                        if(target == userInput[j] + userInput[i])
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

        public static void GetMinAndMax()
        {
            try
            {
                Console.WriteLine("Q4. Find the minimum and maximum elements in array");
                Console.WriteLine("Enter the array length");

                var arrayLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Array:\n(Example: 9 3 5 2 32 22)");
                int[] userInput = new int[arrayLength];
                
                for (int i = 0; i < arrayLength; i++)
                {
                    userInput[i] = Convert.ToInt32(Console.ReadLine());
                }

                int max = 0;
                int min = userInput[0];
                for(int i = 0; i < userInput.Length; i++)
                {
                    if(userInput[i] > max) max = userInput[i];
                    if (userInput[i] < min) min = userInput[i];
                }

                Console.WriteLine("Min: {0} \nMax: {1}", min, max);
                
                Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetPrimeAndNonPrime()
        {
            Console.WriteLine("Q5.Separate the Prime and Non Prime number from the given array");
            Console.WriteLine("Enter array1 input: \n (Example: 9 3 5 2 32 22)");
            int[] array1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

            Console.WriteLine("Enter array2 input: ");
            int[] array2 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            
            int[] userGiven = array1.Concat(array2).Distinct().ToArray();
            
            int j;
            var prime = new List<int>();
            var nonPrime = new List<int>();
            for (int i = 0; i < userGiven.Length; i++)
            {
                if(userGiven[i] == 1)
                {
                    nonPrime.Add(userGiven[i]);
                }
                for (j = 2; j < userGiven[i]; j++)
                    if ((userGiven[i] % j == 0))
                    {
                        nonPrime.Add(userGiven[i]);
                        break;
                    }
                if (j == userGiven[i])
                {
                   prime.Add(userGiven[i]);
                }

            }

            Console.WriteLine(String.Format("Prime Number is : [ {0} ]", String.Join(", ", prime)));
            Console.WriteLine(String.Format("Non Prime Number is : [ {0} ]", String.Join(", ", nonPrime)));

            Execute();
        }

        public static int[] IntToArray(int n)
        {
            if (n == 0) return new int[1] { 0 };

            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }

    }
}
