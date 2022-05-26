using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervace
{
    public static class ReservationCreator
    {
        public static bool Create()
        {
            bool done = false;
            ReservationFilterDialog? filter = null;
            while (!done)
            {
                if (filter == null)
                {
                    filter = new ReservationFilterDialog();
                    
                }

                if (filter.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                VehicleDisplay? VehicleDisplay = new(filter.result, true);
                if (VehicleDisplay.ShowDialog() == DialogResult.OK)
                {
                    done = true;
                }
            }
            return done;
        }
    }
}
