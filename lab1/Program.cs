using System;
using System.Threading;

namespace lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
         
            try
            {
                Console.WriteLine("Do you wanna play a Game!");

                StartSequence();
            }

            catch (Exception ex)
            {
                Console.WriteLine("sorry something went wrong {0}", ex.Message);

            }
            finally
            {
                Console.WriteLine("Program completed");
                
            }

        }





        public static void StartSequence()
        {
            try
            {
                Console.WriteLine("Please Enter a number greater than zero");
                string numberInput = Console.ReadLine();
                int intNum = Convert.ToInt32(numberInput);
                int[] newArray = new int[intNum];
                int[] userArray = Populate(newArray);
                int sum = GetSum(userArray);
                int product = GetProduct(userArray, sum);
                Decimal quotient = GetQuotient(product);

                Console.WriteLine($"your array's length is {numberInput}");
                Console.WriteLine("the numbers in the array are" + String.Join(",", userArray));
                Console.WriteLine($"the sum of the array is {sum}");
                Console.WriteLine($"the product  is {product}");
                Console.WriteLine($"the Quotient is {quotient}");


            }
            catch (FormatException ex)
            {
                Console.WriteLine("That's not a number!", ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("it was littel bit too much !!", ex);
            }

        }




        public static int[] Populate(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i+1} of {arr.Length}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        public static int GetSum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            if (sum < 20)
            {
                throw new ArgumentNullException($"Value of {sum} is too low");
            }

            return sum;
        }

        public static int GetProduct(int[] arr, int sum)
        {
            int product;
            Console.WriteLine($"Please Enter a number between 1 and{arr.Length}");
            int numberInput = Convert.ToInt32(Console.ReadLine());

            product = sum * arr[numberInput];

            if (numberInput > arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return product;



        }

        public static Decimal GetQuotient(int product)
        {

            try
            {
                Console.WriteLine($"Please Enter the number that you want to divied {product} by");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Decimal newUserInput = Convert.ToDecimal(userInput);
                Decimal newProduct = Convert.ToDecimal(product);
                Decimal quotient = Decimal.Divide(newUserInput, newProduct);
                return quotient;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("the number Zero is not divisible");
                return 0;
            }
          

        }
    }
}