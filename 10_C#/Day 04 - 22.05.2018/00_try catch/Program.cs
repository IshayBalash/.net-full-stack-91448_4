using System;

namespace _00_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 0, 1, 2, 3, 4 };

            int num1 = 9, num2, num3;

            try
            {
                Console.WriteLine("pls enter your number");
                num2 = int.Parse(Console.ReadLine());
                num3 = num1 / arr[num2];
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("ArithmeticException");
            }

            /* //COMPILATION ERROR
             * // A previous catch clause already catches all exceptions of this or of a super type('ArithmeticException')
            catch (DivideByZeroException ex)  
            {
                Console.WriteLine("you are catched with DivideByZeroException");
            }
            */

            catch (FormatException)
            {
                Console.WriteLine("you are catched with FormatException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("you are catched with IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"you are catched with {ex.GetType()}");
            }
            finally
            {
                Console.WriteLine("finally MSG");
            }

            Console.WriteLine("after all try & catch");
        }
    }
}
