using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_5_3_nedvigimost
{
    public interface IRealEstate
    {
        string TypeRealEstate { get; }
        double Area { get; }
        int NumberOfRooms { get; }
        string Address { get; }

    }



}
