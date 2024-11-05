using System;

namespace ALBRIGHT_ASSIGNMENT_1_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MSSA CCAD16
            // CHRISTOPHER ALBRIGHT
            // 05NOV2024 -- COURSE DAY 2
            // ASSIGNMENT 1-2


            // SOLUTION 1-2-1

            Console.WriteLine("\nEnter an integer:");
            int check1_Integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter another integer:");
            int check2_Integer = Convert.ToInt32(Console.ReadLine());

            if (check1_Integer == check2_Integer)
            {
                Console.WriteLine("\n" + check1_Integer + " and " + check2_Integer + " are equal.");
            }
            else
            {
                Console.WriteLine("\n" + check1_Integer + " and " + check2_Integer + " are not equal.");

            //----------------------------------------------------------------------------------------------------------------------

            //SOLUTION 1-2-2

            Console.WriteLine("\nSolution 1-2-2");
            Console.WriteLine("\nHow many of the set of natural numbers do you want to sum?:\n");

            int natural_numbers_Int = Convert.ToInt32(Console.ReadLine());
            int sum_natural_Int = 0;

            Console.WriteLine("\nThe fist "+natural_numbers_Int+" numbers (including zero) are:");

                for (int i = 0; i <= natural_numbers_Int; i++)
                {
                    sum_natural_Int = sum_natural_Int + i;
                    Console.WriteLine(i);
                }
            Console.WriteLine("\nThe sum of the first "+natural_numbers_Int+" natural numbers is "+sum_natural_Int+"\n");

                //----------------------------------------------------------------------------------------------------------------------

                //SOLUTION 1-2-3

             Console.WriteLine("\nSolution 1-2-3");
             Console.WriteLine("\nWelcome to the calculator!");
                string continue_Char;
                do
                {
                    Console.WriteLine("\nEnter a number:");
                    double val_1_Double = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nEnter another number:");
                    double val_2_Double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nKey Guide: 1-addition, 2-subtraction, 3-multiplication, 4-division");
                    Console.WriteLine("\nPlease type the corresponding letter for the desired operation");
                    int selection_Char = Convert.ToInt32(Console.ReadLine());

                    switch (selection_Char)
                    {
                        case 1:
                            Console.WriteLine("\n" + val_1_Double + " + " + val_2_Double + " == " + (val_1_Double + val_2_Double));
                            break;
                        case 2:
                            Console.WriteLine("\n" + val_1_Double + " - " + val_2_Double + " == " + (val_1_Double - val_2_Double));
                            break;
                        case 3:
                            Console.WriteLine("\n" + val_1_Double + " * " + val_2_Double + " == " + (val_1_Double * val_2_Double));
                            break;
                        case 4:
                            Console.WriteLine("\n" + val_1_Double + " / " + val_2_Double + " == " + (val_1_Double / val_2_Double));
                            break;
                        default:
                            Console.WriteLine("\nIncorrect Input");
                            break;
                    }
                    Console.WriteLine("\nType c to continue or any other character to exit");
                    continue_Char = Console.ReadLine();
                }
                while (continue_Char == "c");

                Console.WriteLine("\nGoodbye!");
            }
        }
    }
}
