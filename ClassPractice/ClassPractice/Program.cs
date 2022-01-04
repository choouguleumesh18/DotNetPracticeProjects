using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{

    class User
    {
        string _firstName;
        string _lastName;

        public User(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Console.Write("Umesh");
            //Console.Write("Chougule");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 47; j++) 
                {
                    if (i == 0 || i == 11)
                    {
                        Console.Write("*");
                    }
                    else if (i == 1 || i == 10) 
                    { 
                        if (j == 0 || j == 46)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i == 2)
                    {
                        if (j == 1 || j == 4 || j == 5 || j == 8 || j == 13 || j == 14 || j == 15 || j == 16 || j == 22 || j == 29 || j == 36 || j == 39 || j == 40 || j == 41 || j == 42 || j == 45)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else if (i == 3)
                    {
                        if (j == 1 || j == 4 || j == 5 || j == 8 || j == 11 || j == 14 || j == 15 || j == 16 || j == 19 || j == 22 || j == 29 || j == 36 || j == 39 || j == 40 || j == 41 || j == 42 || j == 45)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else if (i == 4)
                    {
                        if (j == 1 || j == 4 || j == 5 || j == 8 || j == 11 || j == 11 || j == 15 || j == 18 || j == 19 || j == 22 || j == 25 || j == 26 || j == 27 || j == 28 || j == 29 || j == 32 || j == 33 || j == 34 || j == 35 || j == 36 || j == 39 || j == 40 || j == 41 || j == 42 || j == 45)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else if (i == 5)
                    {
                        if (j == 1 || j == 4 || j == 5 || j == 8 || j == 11 || j == 12 || j == 13 || j == 17 || j == 18 || j == 19 || j == 22 || j == 29 || j == 36 || j == 45)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else if (i == 6)
                    {
                        if (j == 1 || j == 4 || j == 5 || j == 8 || j == 11 || j == 12 || j == 13 || j == 14 || j == 15 || j == 16 || j == 17 || j == 18 || j == 19 || j == 22 || j == 29 || j == 36 || j == 45)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else if (i == 7)
                    {
                        if (j == 1 || j == 4 || j == 5 || j == 8 || j == 11 || j == 12 || j == 13 || j == 14 || j == 15 || j == 16 || j == 17 || j == 18 || j == 19 || j == 22 || j == 25 || j == 26 || j == 27 || j == 28 || j == 29 || j == 30 || j == 31 || j == 32 || j == 33 || j == 36 || j == 39 || j == 40 || j == 41 || j == 42 || j == 45)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else if (i == 8 || i == 9)
                    {
                        if (j == 1 || j == 8 || j == 8 || j == 11 || j == 12 || j == 13 || j == 14 || j == 15 || j == 16 || j == 17 || j == 18 || j == 19 || j == 22 || j == 29 || j == 36 || j == 39 || j == 40 || j == 41 || j == 42 || j == 45)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }

                    }
                    else
                    {
                        //if (j == 2 || j == 3 || j == 6)
                        //{
                        //    Console.Write(" ");
                        //}
                        //else
                        //{
                        //    Console.Write("*");
                        //}
                    }
                    
                    
                }
            }
                Console.ReadLine();
        }
    }
}
