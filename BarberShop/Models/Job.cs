using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop
{
    class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public TypeJob Type { get; set; }
    }
}
