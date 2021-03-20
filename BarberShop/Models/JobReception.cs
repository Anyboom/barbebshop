using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop
{
    class JobReception {
        public int Id { get; set; }
        public Job Job { get; set; }
        public Reception Reception { get; set; }
    }
}
