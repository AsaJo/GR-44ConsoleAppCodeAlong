namespace GR_44ConsoleAppCodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // bool
            // do while
            // try and catch
            bool keepLooping = true;
            do
            {
                try
                {
                    Console.Clear();
                    //Console.WriteLine("Run exercise by entering a number or -1 to exit.");
                    PrintMenu();
                    //int selection = int.Parse(Console.ReadLine() ?? "0");
                    int selection = AskUserForNumber("menu selection");


                    switch (selection)
                    {
                        case 1:
                            Exercise1();

                            break;
                        case 2:
                            Exercise2();

                            break;
                        case 3:
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("Counting up: " + i);
                            }
                            break;
                        case 4:
                            for (int i = 5; i > 0; i--)
                            {
                                Console.WriteLine("Counting down: " + i);
                            }
                            break;
                        case 9:
                            keepLooping = false;
                            //Console.WriteLine("Thank you and see you again!");
                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                catch
                {

                    Console.WriteLine("Exception has occurred.");
                }


            } while (keepLooping);
        }// End of Main

        static void PrintMenu()
        {
            Console.WriteLine("----------Menu--------");
            Console.WriteLine("1  To Assignments");
            Console.WriteLine("2  To Exercises");
            Console.WriteLine("3  Count up");
            Console.WriteLine("4  Count Down");
            Console.WriteLine("9: Exit ");

        }
        static void Exercise1()
        {
            Console.WriteLine("Replace this with exercises");
        }
        static void Exercise2()
        {
            Console.WriteLine("Replace this with exercises");
        }
        static string? AskUserFor(string what)
        {
            Console.Write("Please enter " + what + ": ");
            return Console.ReadLine();

        }
        static int AskUserForNumber(string what)
        {
            string? result = AskUserFor(what);
            int number = Convert.ToInt32(result);
            return number;
        }

    }// End of Class
}// End of namespace