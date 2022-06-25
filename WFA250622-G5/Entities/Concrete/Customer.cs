using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA250622_G5.Entities.Abstract; // önemli.

namespace WFA250622_G5
{
    public class Customer : BaseEntities
    {       
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
