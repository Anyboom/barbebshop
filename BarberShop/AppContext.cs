using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShop
{
    class AppContext
    {
        private static ApplicationContext _Instance;

        public static ApplicationContext Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ApplicationContext();
                }

                return _Instance;
            }
        }

        private AppContext() {
            throw new NotImplementedException();
        }
    }
}
