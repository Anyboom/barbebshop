using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop
{
    class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public byte[] Avatar { get; set; }
        public bool IsDeleted { get; set; }

        public override string ToString()
        {
            return $"{Id} | {FirstName} {LastName} {MiddleName} | {Phone}";
        }
    }
}
