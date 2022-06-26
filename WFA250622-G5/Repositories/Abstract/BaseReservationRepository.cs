using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA250622_G5.Repositories.Abstract
{
    public abstract class BaseReservationRepository
    {
        public abstract void DeleteReservation(int id);
        public abstract void CreateReservation(int id,Customer customer, Hotel hotel);

        


    }
}
