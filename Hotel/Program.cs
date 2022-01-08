using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;




namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Witaj w Hotelu");
            Console.WriteLine("Wybierz operację, którą chcesz wykonać:");
            Console.WriteLine("[1] Rezerwacja pobytu.");
            Console.WriteLine("[2] Sprawdzenie rezerwacji");
            Console.WriteLine("[3] Rozliczenie pobytu");
            Console.WriteLine("[9] Wyjdź z programu");

            

            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:

                    Console.WriteLine("Metoda rezerwacji");
                    Console.WriteLine("Podaj imię i nazwisko gościa.");
                    string guest = Console.ReadLine();

                    Console.WriteLine("Podaj datę przyjazdu");
                    DateTime arrival = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Podaj datę wyjazdu");
                    DateTime leave = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Podaj numer pokoju");
                    int room = int.Parse(Console.ReadLine());


                    Reservation Rezerwacja = new Reservation(guest, arrival, leave, room);
                    Reservation.ReservationInfo(Rezerwacja);

                    break;

                case 2:
                    Console.WriteLine("Meetoda weryfikacji rezerwacji");
                    break;

                case 3:
                    Console.WriteLine("Metoda rozliczenia pobytu.");
                    break;


                case 9:
                    System.Environment.Exit(1);
                    break;

                default:
                    break;
            }
        }
    }
}
