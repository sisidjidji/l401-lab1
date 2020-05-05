using System;
using System.Threading;

namespace lab1
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Do you wanna play a Game!");
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
                Console.WriteLine("Thank you from Trying");
            }

        }
    }
}



  static void StartSequence()
{
    try
    {
        Console.WriteLine("Please Enter a number greater than zero");
        string  numberInput= Console.ReadLine();
        int intNum = Convert.ToInt32(numberInput);
        int[] newArray = new int[intNum];
        int [] userArray= Populate(newArray);

        Console.WriteLine($"the array length is {numberInput}");
        int sum = GetSum(newArray);
    }
    catch (FormatException ex) { 
        Console.WriteLine("That's not a number!",ex); 
    }
    catch (OverflowException ex) {
        Console.WriteLine("it was littel bit too much !!",ex);
    }


}




static int[] Populate(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++) {
       Console.WriteLine($"Please enter a number {i} of {arr.Length}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
            }
       
}
static int GetSum(int[] arr)
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
    Console.WriteLine($"the sum of the array is : {sum}");
}

static int GetProduct(int []arr, int sum)
{
    int product;
    Console.WriteLine($"Please Enter a number between 1 and{arr.Length}");
    int numberInput = Convert.ToInt32(Console.ReadLine());

    product = sum * arr[numberInput];

    Console.WriteLine($"{sum}*{arr[numberInput]}={product}");

    if (numberInput >arr.Length)
    {
        throw new IndexOutOfRangeException();
    }
}
static decimal GetQuotient(int product)
{

}