using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class MiniProject
    {
        static void Main(string[] args)
        {

            int planet;
            int weight;
            do
            {
                Console.WriteLine("Menu of Planets");
                Console.WriteLine("===============");
                Console.WriteLine("1. Jupiter 2.Mars  3. Mercury");
                Console.WriteLine("4. Neptune 5.Pluto 6. Saturn");
                Console.WriteLine("7. Uranus  8.Venus 9. <Quit>");

                int choice = Convert.ToInt32(Console.ReadLine());// converts the user input from string to integer

                Console.Write("/n Enter your Menu Choice:  ");
                Console.WriteLine("/n Enter your Weight on Earth");

                int weightChoice = Convert.ToInt32(Console.ReadLine());
                {
                    while (choice != 9) // checking if the user input is less than 9 
                    {
                        if (choice == 1)
                        {

                            Console.WriteLine("Your Weight of" + choice + " pounds on Earth would be" + weightChoice * 2.64);
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Your Weight of" + choice + "pounds on Earth would be" + weightChoice * 0.38);
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine("Your Weight of" + choice + "pounds on Earth would be" + weightChoice * 0.37);

                        }
                        else if (choice == 4)
                        {
                            Console.WriteLine("Your Weight of" + choice + "pounds on Earth would be" + weightChoice * 1.12);

                        }
                        else if (choice == 5)
                        {
                            Console.WriteLine("Your Weight of" + choice + "pounds on Earth would be" + weightChoice * 0.04);

                        }
                        else if (choice == 6)
                        {
                            Console.WriteLine("Your Weight of" + choice + "pounds on Earth would be" + weightChoice * 1.15);

                        }
                        else if (choice == 7)
                        {
                            Console.WriteLine("Your Weight of" + choice + "pounds on Earth would be" + weightChoice * 1.15);

                        }
                        else if (choice == 8)
                        {
                            Console.WriteLine("Your Weight of" + choice + "pounds on Earth would be" + weightChoice * 0.38);

                        }
                        else if (choice == 9)
                        {
                            Console.WriteLine("Exit");
                        }

                    }



                    try
                    {
                        if (choice != 9)
                        {
                            Console.WriteLine("Please pick a number from 1 -9");
                        }
                    }


                    catch (Exception er)
                    {
                        Console.WriteLine(er.Message);
                    }

                    Console.ReadKey();

                
            

