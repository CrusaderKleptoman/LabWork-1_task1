using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Logic
    {
        public static string Compare(int timeTrainArrival, int timeTrainDeparture, int timePassenger)
        {
            string outMessage = "";
            if (timeTrainArrival > timeTrainDeparture)
            {
                timeTrainDeparture += 24*60;
            }

            if (timeTrainArrival <= timePassenger && timePassenger <= timeTrainDeparture)
            {
                outMessage = "Поезд будет стоять на платформе во время прихода пассажира";
            }
            else
            {
                outMessage = "Поезд не будет стоять на платформе во время прихода пассажира";
            }

            return outMessage;
        }

        public static int GetTime(int hour, int minutes)
        {
            int time = hour * 60 + minutes;

            return time;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a, b, c, d, n, m;

            Console.WriteLine("Введите время прибытия поезда");
            Console.WriteLine("Час прибытия поезда");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Минута прибытия поезда");
            b = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите время отправки поезда");
            Console.WriteLine("Час отправки поезда");
            c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Минута отправки поезда");
            d = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите время прихода пассажира");
            Console.WriteLine("Час прихода пассажира");
            n = byte.Parse(Console.ReadLine());
            Console.WriteLine("Минута прихода пассажира");
            m = byte.Parse(Console.ReadLine());

            var timeTrainArrival = Logic.GetTime(a, b);
            var timeTrainDeparture = Logic.GetTime(c, d);
            var timePassenger = Logic.GetTime(n, m);
            var outMessage = Logic.Compare(timeTrainArrival, timeTrainDeparture, timePassenger);

            Console.WriteLine(outMessage);
            Console.ReadLine();

        }
    }
}
