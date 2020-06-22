using System;
using System.ComponentModel.Design.Serialization;

namespace MethodsEx
{
    class Program
    {
      /*  public int Max(int x, int y)
        {
            if (x > y)
                return x;
            else


                return y;
        }*/
      public static int Add(int x, int y)
        {
            int res = x + y;
            return res;
        }

       public static int Sub( int x, int y)
        {
            int res = x - y;
            return res;

        }
        public static int Mult(int x, int y)
        {
            int res = x * y;
            return res;
        }

        public static int Div(int x, int y)
        {
            int res = x / y;
            return res;

        }
        static void Main(string[] args)
        {      // var Exercise
            /*  Console.Write("Whats your Name: ");
              string name = Console.ReadLine();
              Console.Write("How old are you?: ");
              string age = Console.ReadLine();
              Console.Write("Whats your fav color?: ");
              string favColor = Console.ReadLine();
              Console.WriteLine($"Why hi there {name}! I see that you are {age} years old, thats cool! I also see that your" +
                  $"fav color is {favColor} Sweet mine is too! ");
            */

            Console.WriteLine(" Were going to add or sub 2 dif numbers");
            Console.Write("What is the first number you want to use?: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the second number you want to use?: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want to add, or sub, or mult, or div?");
            string choice =Console.ReadLine();

            if (choice.Equals("add"))
            {
                int a = Add(x, y);
                Console.WriteLine(a);
            }
            else if (choice.Equals("sub"))
            {
                int a = Sub(x, y);
                Console.WriteLine(a);
            }

            else if(choice.Equals("mult"))
            {
                int a = Mult(x, y);
                Console.WriteLine(a);

            }
            else 
            {
                int a = Div(x, y);
                Console.WriteLine(a);
                //Nice Work!!!!!
            }

        }
    }
}
