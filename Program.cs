using System;

namespace p_chart_and_c_chart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("type (true) to continue or (false) to exit");
                run = Convert.ToBoolean(Console.ReadLine());
                string program = null;
                Console.WriteLine("Please enter program (p) or (c)");
                program = Console.ReadLine();

                if (program == "p")
                {
                    Console.WriteLine("Welcome to P Chart");
                    double defect;
                    double n;
                    double numberOfSamples;
                    double z;
                    double sigmaSubP;
                    double UCL_p;
                    double LCL_p;
                    double pBar;
                    Console.WriteLine("pbar? (y) or (n)");
                    string pBarYN = null;
                    pBarYN = Console.ReadLine();
                    if (pBarYN == "y")
                    {
                        Console.WriteLine("enter p-Bar as a decimal");

                        pBar = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter n; sample size");
                        n = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Z, 2:95.45%, 3:99.73%");
                        z = Convert.ToDouble(Console.ReadLine());
                        sigmaSubP = (Math.Sqrt(((pBar) * (1 - pBar)) / n));
                        UCL_p = (pBar) + ((z) * (sigmaSubP));
                        LCL_p = (pBar) - ((z) * (sigmaSubP));
                        Console.WriteLine("The UCL_p is {0}", UCL_p);
                        Console.WriteLine("The LCL_p is {0}", LCL_p);
                        Console.WriteLine("sigma sub P is {0}", sigmaSubP);
                        Console.WriteLine("Rounded to 3 decimals, UCL_p is {0}", Math.Round(UCL_p, 3));
                        Console.WriteLine("Rounded to 3 decimals, LCL_p is {0}", Math.Round(LCL_p, 3));

                    }
                    if (pBarYN == "n")
                    {
                        Console.WriteLine("Total Defects?");
                        defect = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("sample size?");
                        n = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Total number of samples?");
                        numberOfSamples = Convert.ToDouble(Console.ReadLine());
                        pBar = (defect) / ((n) * (numberOfSamples));
                        Console.WriteLine("p bar is equal to {0}", pBar);

                    }

                }
                if (program == "c")
                {
                    double cBar = 0;
                    double defect;
                    double period;
                    double z;
                    double UCL_c = 0;
                    double LCL_c = 0;

                    Console.WriteLine("c-bar known? (y) or (n)");
                    string cBarYN = null;
                    cBarYN = (Console.ReadLine());
                    if (cBarYN == "y")
                    {
                        Console.WriteLine("Enter c-bar");
                        cBar = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter Z: 2 = 95.45%, 3 = 99.73%");
                        z = Convert.ToDouble(Console.ReadLine());
                        UCL_c = (cBar) + ((z) * (Math.Sqrt(cBar)));
                        Console.WriteLine("UCL_c is {0}", UCL_c);
                        LCL_c = (cBar) - ((z) * (Math.Sqrt(cBar)));
                        Console.WriteLine("LCL_c is {0}", LCL_c);
                        Console.WriteLine("Rounded to 3 decimals, UCL_p is {0}", Math.Round(UCL_c, 2));
                        Console.WriteLine("Rounded to 3 decimals, LCL_p is {0}", Math.Round(LCL_c, 2));




                    }
                    if (cBarYN == "n")
                    {
                        Console.WriteLine("Enter number of defects");
                        defect = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter period");
                        period = Convert.ToDouble("Console.ReadLine");
                        cBar = defect / period;
                        Console.WriteLine("c-bar is{0}", cBar);


                    }

                }



            }
            Console.WriteLine("Press enter to continue...");
            Console.Read();
        }




    }

}



