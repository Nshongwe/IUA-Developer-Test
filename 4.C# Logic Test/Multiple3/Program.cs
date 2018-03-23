using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

               for (int i = 1; i < 101; i++)
                {
                   //call methods to check if number contains both 3 and 7
                    if (checkifnumcontains3(i) && checkifnumcontains7(i))
                    {
                        Console.Write(i);
                        Console.Write("THREE");
                        Console.Write("SEVEN");
                        Console.WriteLine();
                    }
                    else
                        //Call methods to check if number is divisible by both 3 and 7
                        if (checkifdivisibleby3(i) && checkifdivisibleby7(i))
                        {
                            Console.Write(i);
                            Console.Write("THREE");
                            Console.Write("SEVEN");
                            Console.WriteLine();
                        }
                        else
                        if (checkifdivisibleby3(i) || checkifnumcontains3(i) || checkifdivisibleby7(i) || checkifnumcontains7(i))
                        {
                            //call the method to check if a number is divisible or contains 3
                            if (checkifdivisibleby3(i) || checkifnumcontains3(i))
                            {
                                Console.Write(i);
                                Console.Write("THREE");

                                Console.WriteLine();

                            }
                            //call the method to check if a number is divisible or contains 7
                            if (checkifdivisibleby7(i) || checkifnumcontains7(i))
                            {
                                Console.Write(i);
                                Console.Write("SEVEN");
                                Console.WriteLine();
                            }

                        }
                        else
                        {
                            Console.WriteLine(i);
                        }

                }
                Console.Read();
            }
            catch(Exception)
            {
                throw new Exception("Something went wrong");
                
            }
        }

        private static bool checkifdivisibleby3(int i)
        {
            if (i % 3 == 0)
                return true;
            else
                return false;
        }

        private static bool checkifnumcontains3(int i)
        {
            string stringi = i.ToString();
            if (stringi.Contains("3"))
                return true;
            else
                return false;
        }
        private static bool checkifdivisibleby7(int i)
        {
            if (i % 7 == 0)
                return true;
            else
                return false;
        }

        private static bool checkifnumcontains7(int i)
        {
            string stringi = i.ToString();
            if (stringi.Contains("7"))
                return true;
            else
                return false;
        }
    }
}
