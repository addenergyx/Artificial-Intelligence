using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyPlanner.cs
{
    class JourneyMode
    {
        public static int UNKNOWN = 2; 

        public static int av_speed, FALSE = 0, TRUE = 1;

        public static int like_scenery = UNKNOWN, is_pilot = UNKNOWN, fly = UNKNOWN, drive = UNKNOWN,
            fly_airline = UNKNOWN, fly_a_Cessna = UNKNOWN, fly_a_Piper = UNKNOWN, motorbike = UNKNOWN, car = UNKNOWN;


        static void Main(string[] args)
        {
            int distance, time;

            string str;

            Console.WriteLine("This is a program to help with travel planning.");
            Console.WriteLine("\nHow far are you going? (miles)");
            str = Console.ReadLine();
            distance = int.Parse(str);

            Console.WriteLine("\nHow much time do you have for the trip? (hours):");
            str = Console.ReadLine();
            time = int.Parse(str);

            av_speed = distance / time;
            Console.WriteLine("Average speed is " + av_speed + "mph");

            Console.WriteLine("\nDo you prefer scenery over speed? (Y/N)");
            str = Console.ReadLine();
            if (str.ToLower() == "y")
                like_scenery = TRUE;

            Console.WriteLine("\nAre you a pilot? (Y/N)");
            str = Console.ReadLine();

            if (str.ToLower() == "y")
                is_pilot = TRUE;

            rules();

            if (fly_airline == TRUE)
                Console.WriteLine("\nFly using a commercial airline.\n");

            if (fly_a_Cessna == TRUE)
                Console.WriteLine("\nRent a Cessna and fly low.\n"); // High wing monoplane

            if (fly_a_Piper == TRUE)
                Console.WriteLine("\nRent a Piper and fly high.\n"); // Low wing monoplane

            if (motorbike == TRUE)
                Console.WriteLine("\nTake your motorbike and ride the country lanes.\n");

            if (car == TRUE)
                Console.WriteLine("\nNo option but to drive a car.\n");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        public static void rules()
        {
            bool done = false;

            while (done == false)
            {

                if (av_speed > 60)
                    fly = TRUE;
                    done = true;

                if (av_speed <= 60)
                    drive = TRUE;
                    done = true;

                if (fly == TRUE && is_pilot == FALSE)
                    fly_airline = TRUE;
                    done = true;

                if (fly == TRUE && is_pilot == TRUE && like_scenery == TRUE && av_speed < 100)
                    fly_a_Cessna = TRUE;
                    done = true;

                if (fly == TRUE && is_pilot == TRUE && 100 < av_speed && av_speed < 200)
                    fly_a_Piper = TRUE;
                    done = true;

                if (drive == TRUE && motorbike == FALSE)
                    car = TRUE;
                    done = true;

                if (drive == TRUE && like_scenery == TRUE)
                    motorbike = TRUE;
                    done = true;
            }
        }

    }
}
