namespace Calculator1
{

    class calculator
    {

        static void Main(string[] args)
        {

            string restarting;


            do
            {

                Console.WriteLine("\n\nHello. Welcome to the calculator program.\n\n");
                Console.WriteLine("Which type of calculator would you like to use?\n\n");
                Console.WriteLine("press 1 for addition\n\npress 2 for subtraction\n\npress 3 for multipication\n\npress 4 for division\n\npress 5 for square root:\n\npress 6 for calculating an exponent\n\npress 7 for adding decimals\n\npress 8 for subtracting decimals");
                Console.WriteLine("\nWARNING: When using this calculator remember to not use spaces and input one number at a time (they can be more than one digit)\n\n");

                string answer = Console.ReadLine();
                bool Valid = false;

                if (answer == "1")
                {
                    Valid = true;
                    Console.WriteLine("\nGreat. Input your first number:\n\n");
                    long num1;
                    bool parsedSuccessfully = long.TryParse(Console.ReadLine(), out num1);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = long.TryParse(Console.ReadLine(), out num1);
                        }
                    }

                    Console.WriteLine("\nPlus\n");
                    long num2;
                    parsedSuccessfully = long.TryParse(Console.ReadLine(), out num2);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = long.TryParse(Console.ReadLine(), out num2);
                        }
                    }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Here's your answer:\n\n");
                    Console.WriteLine($"=> {Plus(num1, num2)} <=");


                }
                else if (answer == "2")
                {

                    Valid = true;
                    Console.WriteLine("\nGreat. Input your first number:\n\n");
                    long num3;
                    bool parsedSuccessfully = long.TryParse(Console.ReadLine(), out num3);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = long.TryParse(Console.ReadLine(), out num3);
                        }
                    }
                    Console.WriteLine("\nMinus\n");
                    long num4;
                    parsedSuccessfully = long.TryParse(Console.ReadLine(), out num4);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = long.TryParse(Console.ReadLine(), out num4);
                        }
                    }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Here's your answer:\n\n");
                    Console.WriteLine($"=> {Minus(num3, num4)} <=");

                }
                else if (answer == "3")
                {

                    Valid = true;
                    Console.WriteLine("\nGreat. Input your first number:\n\n");
                    long num5;
                    bool parsedSuccessfully = long.TryParse(Console.ReadLine(), out num5);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = long.TryParse(Console.ReadLine(), out num5);
                        }
                    }
                    Console.WriteLine("\nTimes\n");
                    long num6;
                    parsedSuccessfully = long.TryParse(Console.ReadLine(), out num6);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = long.TryParse(Console.ReadLine(), out num6);
                        }
                    }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Here's your answer:\n\n");
                    Console.WriteLine($"=> {Times(num5, num6)} <=");

                }
                else if (answer == "4")
                {
                    Valid = true;
                    Console.WriteLine("\nGreat. Input your first number:\n\n");
                    double num7;
                    bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num7);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num7);
                        }
                    }
                    Console.WriteLine("\nDivided by\n");
                    double num8;
                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num8);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num8);
                        }
                    }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Here's your answer:\n\n");
                    Console.WriteLine($"=> {Divide(num7, num8)} <=");

                }
                else if (answer == "5")
                {

                    Valid = true;
                    Console.WriteLine("\nGreat. Input your number:\n\n");
                    double num9;
                    bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num9);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num9);
                        }
                    }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Here's your answer:\n\n");
                    Console.WriteLine($"=> {SquareRoot(num9)} <=");

                }

                else if (answer == "6")
                {
                    Valid = true;
                    Console.WriteLine("\nGreat. Input your first number:\n\n");
                    double num10;
                    bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num10);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num10);
                        }
                    }
                    Console.WriteLine("\n\nTo the power of\n\n");
                    double num11;
                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num11);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num11);
                        }
                    };
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Here's your answer:\n\n");
                    Console.WriteLine($"=> {ToThePowerOf(num10, num11)} <=");

                }

                else if (answer == "7")
                {
                    Valid = true;
                    Console.WriteLine("\nGreat. Input your first number:\n\n");
                    double num12;
                    bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num12);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num12);
                        }
                    }
                    Console.WriteLine("\n\nPlus\n\n");
                    double num13;
                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num13);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num13);
                        }
                    };
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Here's your answer:\n\n");
                    Console.WriteLine($"=> {DecimalPlus(num12, num13)} <=");

                }

                else if (answer == "8")
                {
                    Valid = true;
                    Console.WriteLine("\nGreat. Input your first number:\n\n");
                    double num14;
                    bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num14);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num14);
                        }
                    }
                    Console.WriteLine("\n\nMinus\n\n");
                    double num15;
                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num15);

                    if (parsedSuccessfully == false)
                    {
                        Console.WriteLine("\n\nInvald input.\n\n");
                        Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                        while (parsedSuccessfully == false)
                        {
                            Console.WriteLine("\n\ntry again\n\n");

                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num15);
                        }
                    };
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Here's your answer:\n\n");
                    Console.WriteLine($"=> {DecimalMinus(num14, num15)} <=");

                }

                else
                {
                    Valid = false;

                    while (Valid == false)
                    {
                        Console.WriteLine("\n\nInvalid input");
                        Console.WriteLine("\n\ninput is too long or not a number.\n\n");

                        answer = Console.ReadLine();
                        Valid = false;

                        if (answer == "1")
                        {
                            Valid = true;
                            Console.WriteLine("\nGreat. Input your first number:\n\n");
                            int num1;
                            bool parsedSuccessfully = int.TryParse(Console.ReadLine(), out num1);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = int.TryParse(Console.ReadLine(), out num1);
                                }
                            }

                            Console.WriteLine("\nPlus\n");
                            int num2;
                            parsedSuccessfully = int.TryParse(Console.ReadLine(), out num2);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = int.TryParse(Console.ReadLine(), out num2);
                                }
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Here's your answer:\n\n");
                            Console.WriteLine($"=> {Plus(num1, num2)} <=");


                        }
                        else if (answer == "2")
                        {

                            Valid = true;
                            Console.WriteLine("\nGreat. Input your first number:\n\n");
                            int num3;
                            bool parsedSuccessfully = int.TryParse(Console.ReadLine(), out num3);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = int.TryParse(Console.ReadLine(), out num3);
                                }
                            }
                            Console.WriteLine("\nMinus\n");
                            int num4;
                            parsedSuccessfully = int.TryParse(Console.ReadLine(), out num4);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = int.TryParse(Console.ReadLine(), out num4);
                                }
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Here's your answer:\n\n");
                            Console.WriteLine($"=> {Minus(num3, num4)} <=");

                        }
                        else if (answer == "3")
                        {

                            Valid = true;
                            Console.WriteLine("\nGreat. Input your first number:\n\n");
                            int num5;
                            bool parsedSuccessfully = int.TryParse(Console.ReadLine(), out num5);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = int.TryParse(Console.ReadLine(), out num5);
                                }
                            }
                            Console.WriteLine("\nTimes\n");
                            int num6;
                            parsedSuccessfully = int.TryParse(Console.ReadLine(), out num6);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = int.TryParse(Console.ReadLine(), out num6);
                                }
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Here's your answer:\n\n");
                            Console.WriteLine($"=> {Times(num5, num6)} <=");

                        }
                        else if (answer == "4")
                        {
                            Valid = true;
                            Console.WriteLine("\nGreat. Input your first number:\n\n");
                            double num7;
                            bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num7);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num7);
                                }
                            }
                            Console.WriteLine("\nDivided by\n");
                            double num8;
                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num8);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num8);
                                }
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Here's your answer:\n\n");
                            Console.WriteLine($"=> {Divide(num7, num8)} <=");

                        }
                        else if (answer == "5")
                        {

                            Valid = true;
                            Console.WriteLine("\nGreat. Input your number:\n\n");
                            double num9;
                            bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num9);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num9);
                                }
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Here's your answer:\n\n");
                            Console.WriteLine($"=> {SquareRoot(num9)} <=");

                        }

                        else if (answer == "6")
                        {
                            Valid = true;
                            Console.WriteLine("\nGreat. Input your first number:\n\n");
                            double num10;
                            bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num10);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num10);
                                }
                            }
                            Console.WriteLine("\n\nTo the power of\n\n");
                            double num11;
                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num11);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num11);
                                }
                            };
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Here's your answer:\n\n");
                            Console.WriteLine($"=> {ToThePowerOf(num10, num11)} <=");

                        }

                        else if (answer == "7")
                        {
                            Valid = true;
                            Console.WriteLine("\nGreat. Input your first number:\n\n");
                            double num12;
                            bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num12);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num12);
                                }
                            }
                            Console.WriteLine("\n\nPlus\n\n");
                            double num13;
                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num13);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num13);
                                }
                            };
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Here's your answer:\n\n");
                            Console.WriteLine($"=> {DecimalPlus(num12, num13)} <=");

                        }

                        else if (answer == "8")
                        {
                            Valid = true;
                            Console.WriteLine("\nGreat. Input your first number:\n\n");
                            double num14;
                            bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out num14);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num14);
                                }
                            }
                            Console.WriteLine("\n\nMinus\n\n");
                            double num15;
                            parsedSuccessfully = double.TryParse(Console.ReadLine(), out num15);

                            if (parsedSuccessfully == false)
                            {
                                Console.WriteLine("\n\nInvald input.\n\n");
                                Console.WriteLine("\n\nInput is too long or not a number.\n\n");
                                while (parsedSuccessfully == false)
                                {
                                    Console.WriteLine("\n\ntry again\n\n");

                                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out num15);
                                }
                            };
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Here's your answer:\n\n");
                            Console.WriteLine($"=> {DecimalMinus(num14, num15)} <=");

                        }

                    }
                }


                Console.WriteLine("\n\nYou have reached the end of this calculator.\n\n");

                Console.Write("would you like to restart? (Y/N) ");
                restarting = Console.ReadLine().ToUpper();
                while ((restarting != "Y") && (restarting != "N"))
                {
                    Console.WriteLine("Invalid input\n\n");
                    Console.WriteLine("would you like to restart? (Y/N)");
                    restarting = Console.ReadLine().ToUpper();
                }

                if (restarting == "Y")
                {
                    Console.WriteLine("\n\nRestarting...");
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n\nShutting Down...");
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    Console.Clear();


                }








            } while (restarting == "Y");






        }



        static long Plus(long Number1, long Number2)
        {
            long Answer = Number1 + Number2;
            return Answer;

        }

        static long Minus(long Number3, long Number4)
        {
            long Answer = Number3 - Number4;
            return Answer;

        }

        static long Times(long Number5, long Number6)
        {
            long Answer = Number5 * Number6;
            return Answer;

        }

        static double Divide(double Number7, double Number8)
        {
            double answer2 = Number7 / Number8;
            return answer2;


        }

        static double SquareRoot(double Number9)
        {
            double answer2 = Math.Sqrt(Number9);
            return answer2;


        }

        static double ToThePowerOf(double Number10, double Number11)
        {
            double answer2 = Math.Pow(Number10, Number11);
            return answer2;


        }

        static double DecimalPlus(double Number12, double Number13)
        {
            double answer2 = (Number12 + Number13);
            return answer2;
        }

        static double DecimalMinus(double Number14, double Number15)
        {
            double answer2 = (Number14 - Number15);
            return answer2;
        }

    }

}