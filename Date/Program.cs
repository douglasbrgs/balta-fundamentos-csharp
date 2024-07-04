using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // Aula1();
            // Aula2();
            // Aula3();
            // Aula4();
            // Aula5();
            // Aula6();
            // Aula7();
            // Aula8();
            Aula9();
            // Aula10();
        }
        public static void Aula1()
        {
            // var data = new DateTime();
            var data = DateTime.Now;

            Console.WriteLine(data);
        }

        private static void Aula2()
        {
            var data = new DateTime(2024, 6, 24, 18, 15, 30);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine((int)data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
        }

        private static void Aula3()
        {
            var data = DateTime.Now;

            //yyyy MM dd HH mm ss ff z
            var formatada = string.Format("{0:dd/MM/yyyy HH:mm:ss ff z}", data);
            Console.WriteLine(formatada);
        }

        private static void Aula4()
        {
            var data = DateTime.Now;
            var formato1 = string.Empty;
            var formato2 = string.Empty;

            //Tempo
            // formato1 = string.Format("{0:t}", data);
            // Console.WriteLine(formato1);
            // formato2 = string.Format("{0:T}", data);
            // Console.WriteLine(formato2);

            //Data
            // formato1 = string.Format("{0:d}", data);
            // Console.WriteLine(formato1);
            // formato2 = string.Format("{0:D}", data);
            // Console.WriteLine(formato2);

            formato1 = string.Format("{0:f}", data);
            Console.WriteLine(formato1);
            formato2 = string.Format("{0:g}", data);
            Console.WriteLine(formato2);

            // Console.WriteLine(string.Format("{0:r}", data));
            // Console.WriteLine(string.Format("{0:s}", data));
            // Console.WriteLine(string.Format("{0:u}", data));
        }

        private static void Aula5()
        {
            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(-12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));
            Console.WriteLine(data.AddHours(1));
        }

        private static void Aula6()
        {
            var data = DateTime.Now;

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine(data);
        }

        private static void Aula7()
        {
            var pt = new CultureInfo("pt-BR");
            var br = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("D", de));
        }

        private static void Aula8()
        {
            var utcDate = DateTime.UtcNow;

            // Console.WriteLine(DateTime.Now);
            // Console.WriteLine(utcDate);

            // Console.WriteLine(utcDate.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.WriteLine(timezoneAustralia);

            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            // Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("---------");
            }
        }

        private static void Aula9()
        {
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(19, 24, 15);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(24, 19, 24, 15);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(24, 19, 24, 25, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
        }

        private static void Aula10()
        {
            Console.WriteLine(DateTime.DaysInMonth(2024, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}

