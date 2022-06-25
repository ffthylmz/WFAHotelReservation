using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA250622_G5.Entities.Abstract
{
    public abstract class BaseEntities
    {
        public int ID { get; set; }

        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {
            get => _createDate;   // başka gösterim şekli.
            set => _createDate = value;
        }

    }
}
