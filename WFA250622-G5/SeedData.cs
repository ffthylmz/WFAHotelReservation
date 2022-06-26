using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA250622_G5.Entities.Enums;

namespace WFA250622_G5
{
    public class SeedData
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer{ID=1, Name="Fatih", Surname="YILMAZ" },
            new Customer{ID=2, Name="Berna", Surname="YILMAZ"},
            new Customer{ID=3, Name="Ahmet Sinan", Surname="ÖZTÜRK"},
            new Customer{ID=4, Name="Kutay Egemen", Surname="DEMİREL"},
            new Customer{ID=5, Name="Serap", Surname="ÇINAR"}

        };

        public static List<Hotel> hotels = new List<Hotel>()
        {
            new Hotel{ID=1, HotelName="Hilton", HotelLocation=Locations.Antalya, Price=1500, CurrencyUnits=CurrencyUnits.TL},
            new Hotel{ID=2, HotelName="Voyage Torba", HotelLocation=Locations.Muğla, Price=2000, CurrencyUnits=CurrencyUnits.TL},
            new Hotel{ID=3, HotelName="Sheriton", HotelLocation=Locations.Bursa, Price=250, CurrencyUnits=CurrencyUnits.Dolar},
            new Hotel{ID=4, HotelName="Conrad", HotelLocation=Locations.İstanbul, Price=350, CurrencyUnits=CurrencyUnits.Euro},
            new Hotel{ID=5, HotelName="Ramada", HotelLocation=Locations.Antalya, Price=450, CurrencyUnits=CurrencyUnits.Euro},
            new Hotel{ID=6, HotelName="Amara Family Resort", HotelLocation=Locations.Antalya, Price=325, CurrencyUnits=CurrencyUnits.Dolar},
            new Hotel{ID=7, HotelName="Ilıca Spa", HotelLocation=Locations.İzmir, Price=1400, CurrencyUnits=CurrencyUnits.TL},
            new Hotel{ID=7, HotelName="Angora Beach", HotelLocation=Locations.İzmir, Price=200, CurrencyUnits=CurrencyUnits.KuveytDinari}

        };

        public static List<Reservation> reservations = new List<Reservation>()
        {
            new Reservation{ ID=1, Customer=customers[0],Hotel=hotels[1], ReservationDate=new DateTime(2022,06,25)},
            new Reservation{ ID=2, Customer=customers[3],Hotel=hotels[2], ReservationDate=new DateTime(2022,06,24)},
            new Reservation{ ID=3, Customer=customers[2],Hotel=hotels[3], ReservationDate=new DateTime(2022,06,23)}

        };


    }
}
