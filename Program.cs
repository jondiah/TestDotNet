using System;

namespace TestDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData user_data = new UserData();
            
            Console.WriteLine("Hi, please tell me your name: ");
            String user_name = Console.ReadLine();
            user_data.SetUserName(user_name);
            Console.WriteLine("Hi {0:G}", user_data.GetUserName() );

            bool run_program = true;
            int active_program = -1;

            // Start program loop
            while(run_program)
            {
                Console.WriteLine("---");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("0. Answer a mathematical question");
                Console.WriteLine("1. Exit Application");
                active_program = Int32.Parse(Console.ReadLine());

                switch(active_program) {
                    case 0:
                        Random r = new Random();
                        int first_number = r.Next(0, 10);
                        int second_number = r.Next(0, 10);
                        Console.WriteLine("What is {0:D} x {1:D}", first_number, second_number);
                        int answer = Int32.Parse(Console.ReadLine());

                        if(answer == (first_number*second_number))
                        {
                            Console.WriteLine("CORRECT ANSWER");
                        }
                        else
                        {
                            Console.WriteLine("WRONG ANSWER! Correct answer is {0:D}", (first_number*second_number));
                        }
                        break;    
                    case 1:
                        run_program = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;

                }
            }

            Console.WriteLine("Bye Bye {0:G}", user_data.GetUserName() );
        }
    }
}
