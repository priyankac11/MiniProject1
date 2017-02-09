using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
 {
    class Program
    {
        static void Main(string[] args)
        {
            
            int planet;
            int weight;  
           
            Console.WriteLine("Menu of Planets");
            Console.WriteLine("===============");
            Console.WriteLine("1. Jupiter 2.Mars  3. Mercury");
            Console.WriteLine("4. Neptune 5.Pluto 6. Saturn");
            Console.WriteLine("7. Uranus  8.Venus 9. <Quit>");



            Console.Write("/n Enter your Menu Choice:  ");
            int choice = Convert.ToInt32(Console.ReadLine());// converts the user input from string to integer
            Console.WriteLine("/n Enter your Weight on Earth");
            int weightChoice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("Your Weight of" + choice + "pounds on Earth would be" + weightChoice * 2.64);
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
                
            
                    
                    }
            
            //Console.WriteLine("Please Enter a number"); 

            // int planetChoice = Convert.ToInt16(Console.ReadLine);
            
            //int planeChoice = 0; 
            //switch (planetChoice)
            //{
            //  case 1: Console.WriteLine("Your Weight of ")
            //}

            //if (planetChoice < 10 && > 0)
            // {

            //}


         /*  int planetChoice;
            Console.WriteLine("Enter your menu choice 1....9"); 

            try
            {
                // convert what the user enters into a # 
                planetChoice = int.Parse(Console.ReadLine());
                String strplanetName = String.Empty; 
                switch (planetChoice)
                {
                    case 1:
                        strplanetName = "Your weight of"  Jupiter ";
                        break;
                    case 2:
                        strplanetName = " Mars";
                        break;
                    case 3:
                        strplanetName = " Mercury ";
                        break;
                    case 4:
                        strplanetName = " Neptune ";
                        break;
                    case 5:
                        strplanetName = " Pluto ";
                        break;
                    case 6:
                        strplanetName = " Saturn ";
                        break;
                    case 7:
                        strplanetName = " Uranus ";
                        break;
                    case 8:
                        strplanetName = " Venus ";
                        break;
                    case 9:
                        strplanetName = " Exit ";
                        break;
                    default:
                        strplanetName = "Sorry Invalid entry is made";
                        break; 

                }
                // print message 
                Console.WriteLine(strplanetName); 
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }

            Console.ReadKey(); */

        }
    }
}
