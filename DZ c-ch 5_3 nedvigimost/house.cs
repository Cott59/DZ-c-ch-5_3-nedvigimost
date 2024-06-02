using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_5_3_nedvigimost
{
    public struct House : IRealEstate
    {
        public string TypeRealEstate { get; set; }
        public double Area { get; set; }
        public int NumberOfRooms { get; set; }
        public string Address { get; set; }

        public int NumberOfFloor { get; set; }
        public double AreaOfLand { get; set; }  

    }
}
