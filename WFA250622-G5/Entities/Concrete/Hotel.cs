using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA250622_G5.Entities.Abstract;
using WFA250622_G5.Entities.Enums;

namespace WFA250622_G5
{
    internal class Hotel : BaseEntities
    {
        public string HotelName { get; set; }
        public string HotelLocation { get; set; }
        public AccomodationType AccomodationType { get; set; }        
        public double Price { get; set; }
        public string Picture { get; set; }
    }
}
