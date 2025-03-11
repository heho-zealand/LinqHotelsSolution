using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHotelsExercise
{
    class Room
    {
        public int RoomNo { get; set; }
        public int HotelNo { get; set; }
        public char Types { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return string.Format("RoomNo: {0}, HotelNo: {1}, Types: {2}, Price: {3}", RoomNo, HotelNo, Types, Price);
        }
    }
}

