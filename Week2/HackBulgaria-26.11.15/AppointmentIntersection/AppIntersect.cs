using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentIntersection
{
    class AppIntersect
    {
        public static void FindIntersectingAppointments ( DateTime[] appointments , TimeSpan[] durations )
        {
            for(int i = 0 ; i < appointments.Length ; i++)
            {
                for(int j = i + 1 ; j < appointments.Length ; j++)
                {
                    if(appointments[i].Add(durations[i]) > appointments[j] && appointments[i] < appointments[j].Add(durations[j]))
                    {
                        Console.WriteLine("Appointment 1: {0}\n Appointment 2: {1}\n  Intersection point: {2}" ,
                            appointments[i] , appointments[j] ,
                            appointments[i].Add(durations[i])-appointments[j]);
                    }
                }
            }
        }
        static void Main ( string[] args )
        {
            DateTime[] appointments = new DateTime[]
            {
                new DateTime(2015,11,25,13,00,00),
                new DateTime(2015,11,25,14,20,00),
                new DateTime(2015,11,25,15,30,00),
                new DateTime(2015,11,25,16,00,00),
                new DateTime(2015,11,25,17,50,00),
                new DateTime(2015,11,25,18,10,00)
            };
            TimeSpan[] durations = new TimeSpan[]
            {
                new TimeSpan(1 , 30 , 00),
                new TimeSpan(0 , 40 , 00),
                new TimeSpan(0 , 50 , 00),
                new TimeSpan(1 , 30 , 00),
                new TimeSpan(0 , 40 , 00),
                new TimeSpan(2 , 00 , 00)
            };
            FindIntersectingAppointments(appointments , durations);
            Console.ReadKey();

        }
    }
}
