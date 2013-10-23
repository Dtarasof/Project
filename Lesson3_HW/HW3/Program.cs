﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3
{
    class Program
    {

        public static void task1()
        {
            /*1. Напишите программу, проверяющую число, введенное с клавиатуры на четность.*/
           
            Console.WriteLine("You selected task1 - checking numbers are even or not");

            int a = 0;
           
            Console.WriteLine("Please enter some number:");
            a = Convert.ToInt32(Console.ReadLine());

            if ((a % 2) == 0 )
            
                Console.WriteLine("You entered even number:");
            else
                Console.WriteLine("You entered not even number:");
        }


       public static void task2()
        {
            /*  2. Дано натуральное число а (a<100). Напишите программу, выводящую на экран количество цифр в этом числе и сумму этих цифр.*/

            double a = 0.0;
            string str_digits="";
            int digits_count = 0, digits_sum = 0;
           

            try
            {
                Console.WriteLine("Please enter some float number <100:");
                a = Convert.ToDouble(Console.ReadLine());
                
            }

            catch
            {
                Console.WriteLine("Error occured, please try again:");
            }

            if (a < 100)
            {

                str_digits = Convert.ToString(a);

                for (int i = 0; i < str_digits.Length; i++)
                {
                    if (str_digits[i] != '.')
                    {
                        digits_count++;
                        digits_sum += Convert.ToInt32(str_digits[i].ToString());
                    }
                }


                Console.WriteLine("digits_count {0}", digits_count);
                Console.WriteLine("digits_sum {0}", digits_sum);
            }
            else
            {
                Console.WriteLine("You entered number more than 100, please try again");
            }

            Console.WriteLine("Please enter any key to continue");
            Console.ReadKey();
          
        }

       public static void task3()
       {


           /*
           3. Известно, что 1 дюйм равен 2.54 см. Разработать приложение, переводящие дюймы в сантиметры и наоборот. Диалог с пользователем реализовать через систему меню.
           */

           double inches = 0, sm = 0;
           int selected = 0;
           Console.WriteLine("You selected task3 - Converting to inches");

           do
           {

               Console.Clear();

               Console.WriteLine("Please select:");
               Console.WriteLine("1 - convert inches to sm");
               Console.WriteLine("2 - convert centimeters to inches");
               Console.WriteLine("0 - close");

               selected = Convert.ToInt32(Console.ReadLine());

                 switch (selected)
                {

                    case 1:
                        Console.WriteLine("Please enter inches amount");
                        inches = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("It is {0} sm", inches*2.54);            

                        break;

                    case 2:
                        Console.WriteLine("Please enter centimeters amount");
                        sm = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("It is {0} centimeters ", sm / 2.54);    

                        break;

                    default:
                        break;


                }
                 Console.ReadKey();
                 Console.Clear();


           } while (selected != 0);

       }

       public static void task4()
       {
        /*
           Разработать программу, которая выводит на экран линию из символов. Число символов, какой использовать символ, 
         * и какая будет линия - вертикальная, или горизонтальная - указывает пользователь. 
        */


           char symbol =' ';
           int line_lenght = 0;
           bool is_vertical = false;

                   try
           {
               Console.WriteLine("Please enter line lenght:");
               line_lenght = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Please enter line symbol:");
               symbol = Convert.ToChar(Console.ReadLine());

               Console.WriteLine("Please enter 1 - for vertical or something else - for gorizonal line:");
               if (Console.ReadLine() == "1")
                   is_vertical = true;
               else
                   is_vertical = false;

           }

           catch
           {
               Console.WriteLine("Error occured, please try again:");
           }

           Console.WriteLine("You entered {0}", line_lenght);
           Console.WriteLine("You entered {0}", symbol);


           for (int i = 0; i < line_lenght; i++)
           {
               if (is_vertical == true) 
                   Console.WriteLine(symbol);
               else
                   Console.Write(symbol);
           }
        }

       public static void task5()
       {
       }


       public static void task6()
       {
       }


        static void Main(string[] args)
        {
            int task_num = 0;
            //  homework hw = new homework();

            do
            {        
            try
            {
                Console.WriteLine("Please enter homework task number, or 0 to exit");
                task_num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered incorrect value:");
            }

                           
                switch (task_num)
                {

                    case 1:
                        task1();
                        break;

                    case 2:
                        task2();
                        break;

                    case 3:
                        task3();
                        break;

                    case 4:
                        task4();
                        break;

                    case 5:
                        task5();
                        break;

                    case 6:
                        task6();
                        break;


                    default:
                        Console.WriteLine("Default case");
                        break;


                }
            Console.ReadKey();
            Console.Clear();

            } while (task_num != 0);
            

        }
    }
}
