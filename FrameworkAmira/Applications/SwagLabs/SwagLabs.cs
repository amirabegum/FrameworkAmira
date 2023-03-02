using FrameworkAmira.Applications.SwagLabs.Pages;
using FrameworkAmira.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAmira.Applications.SwagLabs
{
    public class SwagLabs
    {
        Driver _driverManager;

        public SwagLabs(Driver driverManager)
        {
            _driverManager = driverManager;
        }

        public Products Products => new(_driverManager);
        public Login Login => new(_driverManager);
        public Checkout Checkout => new(_driverManager);
    }
}
