using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Reservation
    {
        public string guest;
        public DateTime arrival;
        public DateTime leave;
        public int room;

        public Reservation(string guest, DateTime arrival, DateTime leave, int room)
        {
            this.guest=guest;
            this.arrival=arrival;
            this.leave=leave;
            this.room=room;
        }

       public static void ReservationInfo(Reservation info)
        {
            Console.WriteLine($"{info.guest} rozpoczyna pobyt: {info.arrival}. Pobyt kończy się dnia: {info.leave}. Numer pokoju: {info.room}");
        }

    }

        


}

