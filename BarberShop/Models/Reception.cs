using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop
{
    class Reception
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Client Client { get; set; }
        public Purchase Purchase { get; set; }
        public DateTime DateAt { get; set; }
        public bool IsCanceled { get; set; }
    }
}
