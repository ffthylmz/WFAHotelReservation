using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA250622_G5.Entities.Enums;
using WFA250622_G5.Repositories.Abstract;
using WFA250622_G5.Repositories.Interfaces;

namespace WFA250622_G5.Repositories.Concrete
{
    public class ReservationRepository : BaseReservationRepository, IListHotel, IListReservation
    {
        public override void CreateReservation(int id, Customer customer, Hotel hotel)
        {
            Reservation reservation = new Reservation();

            reservation.ID = id;

            reservation.Customer = customer; // --> Bunu yazarakta Customer 'in tüm bilgilerine ulaşıp atama yapabiliriz.

            //reservation.Customer.Name = customer.Name;
            //reservation.Customer.Surname = customer.Surname;

            reservation.Hotel = hotel;  // --> Bunu yazarakta Hotel 'in tüm bilgilerine ulaşıp atama yapabiliriz.

            //reservation.Hotel.HotelName = hotel.HotelName;
            //reservation.Hotel.HotelLocation = hotel.HotelLocation;
            //reservation.Hotel.Picture = hotel.Picture;
            //reservation.Hotel.Price = hotel.Price;
            //reservation.Hotel.CurrencyUnits = hotel.CurrencyUnits;
            //reservation.Hotel.AccomodationType = hotel.AccomodationType;


        }

        public override void DeleteReservation(int id)
        {
            foreach (var item in SeedData.reservations)
            {
                if (item.ID == id)
                {
                    SeedData.reservations.Remove(item);
                }
            }
        }

        public void ListHotel(ComboBox combobox)
        {
            foreach (var item in SeedData.hotels)
            {
                combobox.Items.Add(item.HotelName);
            }

        }

        public List<Reservation> ListReservation()
        {
            return SeedData.reservations.ToList();
        }
    }
}
