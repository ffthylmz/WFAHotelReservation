using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA250622_G5.Entities.Abstract;

namespace WFA250622_G5
{
    public class Reservation : BaseEntities
    {
        public Hotel Hotel { get; set; }
        public Customer Customer { get; set; }

        private DateTime _reservationDate = DateTime.Now;

        public DateTime ReservationDate
        {
            get { return _reservationDate; }
            set { _reservationDate = value; }
        }



    }
}
