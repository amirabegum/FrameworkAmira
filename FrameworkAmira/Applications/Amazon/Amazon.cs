using FrameworkAmira.Applications.Pages;
using FrameworkAmira.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAmira.Applications
{
    public class Amazon
    {
        Driver _driverManager; 

        public Amazon(Driver driverManager)
        {
            _driverManager = driverManager;
        }

        public HomePage HomePage => new HomePage(_driverManager); //creates an instance of homepage 

    }
}
