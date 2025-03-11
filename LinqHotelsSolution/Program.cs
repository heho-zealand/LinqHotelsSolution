using LinqHotelsExercise;
using System.Linq;

var hotels = new Hotel[]
           {
                new Hotel() {HotelNo = 1, Name = "The Pope", Address = "Vaticanstreet 1  1111 Bishopcity"},
                new Hotel() {HotelNo = 2, Name = "Lucky Star", Address = "Lucky Road 12  2222 Hometown"},
                new Hotel() {HotelNo = 3, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 4, Name = "deLuxeCapital", Address = "Luxury Road 99  4444 Luxus"},
                new Hotel() {HotelNo = 5, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 6, Name = "Prindsen", Address = "Algade 5, 4000 Roskilde"},
                new Hotel() {HotelNo = 7, Name = "Scandic", Address = "Algade 5, 4000 Roskilde"},
           };

var rooms = new Room[]
{
                new Room() {RoomNo = 1, HotelNo = 1, Types = 'D', Price = 200},
                new Room() {RoomNo = 2, HotelNo = 1, Types = 'D', Price = 200},
                new Room() {RoomNo = 3, HotelNo = 1, Types = 'D', Price = 200},
                new Room() {RoomNo = 4, HotelNo = 1, Types = 'D', Price = 200},
                new Room() {RoomNo = 11, HotelNo = 1, Types = 'S', Price = 150},
                new Room() {RoomNo = 12, HotelNo = 1, Types = 'S', Price = 150},
                new Room() {RoomNo = 13, HotelNo = 1, Types = 'S', Price = 150},
                new Room() {RoomNo = 21, HotelNo = 1, Types = 'F', Price = 220},
                new Room() {RoomNo = 22, HotelNo = 1, Types = 'F', Price = 220},
                new Room() {RoomNo = 23, HotelNo = 1, Types = 'F', Price = 220},
                new Room() {RoomNo = 1, HotelNo = 2, Types = 'D', Price = 230},
                new Room() {RoomNo = 2, HotelNo = 2, Types = 'D', Price = 230},
                new Room() {RoomNo = 3, HotelNo = 2, Types = 'D', Price = 230},
                new Room() {RoomNo = 4, HotelNo = 2, Types = 'D', Price = 230},
                new Room() {RoomNo = 11, HotelNo = 2, Types = 'S', Price = 180},
                new Room() {RoomNo = 12, HotelNo = 2, Types = 'S', Price = 180},
                new Room() {RoomNo = 21, HotelNo = 2, Types = 'F', Price = 300},
                new Room() {RoomNo = 22, HotelNo = 2, Types = 'F', Price = 300},
                new Room() {RoomNo = 1, HotelNo = 3, Types = 'D', Price = 175},
                new Room() {RoomNo = 2, HotelNo = 3, Types = 'D', Price = 180},
                new Room() {RoomNo = 11, HotelNo = 3, Types = 'S', Price = 100},
                new Room() {RoomNo = 21, HotelNo = 3, Types = 'S', Price = 100},
                new Room() {RoomNo = 31, HotelNo = 3, Types = 'F', Price = 200},
                new Room() {RoomNo = 32, HotelNo = 3, Types = 'F', Price = 230},
                new Room() {RoomNo = 1, HotelNo = 4, Types = 'D', Price = 500},
                new Room() {RoomNo = 2, HotelNo = 4, Types = 'D', Price = 550},
                new Room() {RoomNo = 3, HotelNo = 4, Types = 'D', Price = 550},
                new Room() {RoomNo = 11, HotelNo = 4, Types = 'S', Price = 350},
                new Room() {RoomNo = 12, HotelNo = 4, Types = 'S', Price = 360},
                new Room() {RoomNo = 1, HotelNo = 5, Types = 'D', Price = 250},
                new Room() {RoomNo = 2, HotelNo = 5, Types = 'D', Price = 170},
                new Room() {RoomNo = 11, HotelNo = 5, Types = 'S', Price = 150},
                new Room() {RoomNo = 21, HotelNo = 5, Types = 'F', Price = 300},
                new Room() {RoomNo = 22, HotelNo = 5, Types = 'F', Price = 310},
                new Room() {RoomNo = 23, HotelNo = 5, Types = 'F', Price = 320},
                new Room() {RoomNo = 24, HotelNo = 5, Types = 'F', Price = 320},
                new Room() {RoomNo = 1, HotelNo = 6, Types = 'D', Price = 290},
                new Room() {RoomNo = 11, HotelNo = 6, Types = 'S', Price = 185},
                new Room() {RoomNo = 21, HotelNo = 6, Types = 'F', Price = 360},
                new Room() {RoomNo = 22, HotelNo = 6, Types = 'F', Price = 370},
                new Room() {RoomNo = 23, HotelNo = 6, Types = 'F', Price = 380},
                new Room() {RoomNo = 24, HotelNo = 6, Types = 'F', Price = 380},
                new Room() {RoomNo = 1, HotelNo = 7, Types = 'D', Price = 200},
                new Room() {RoomNo = 2, HotelNo = 7, Types = 'D', Price = 200},
                new Room() {RoomNo = 3, HotelNo = 7, Types = 'D', Price = 200},
                new Room() {RoomNo = 4, HotelNo = 7, Types = 'D', Price = 200},
                new Room() {RoomNo = 11, HotelNo = 7, Types = 'S', Price = 150},
                new Room() {RoomNo = 12, HotelNo = 7, Types = 'S', Price = 150},
                new Room() {RoomNo = 13, HotelNo = 7, Types = 'S', Price = 150},
                new Room() {RoomNo = 14, HotelNo = 7, Types = 'S', Price = 150},
                new Room() {RoomNo = 21, HotelNo = 7, Types = 'F', Price = 220},
                new Room() {RoomNo = 22, HotelNo = 7, Types = 'F', Price = 220},
                new Room() {RoomNo = 23, HotelNo = 7, Types = 'F', Price = 220},
                new Room() {RoomNo = 24, HotelNo = 7, Types = 'F', Price = 220}
};


// 1) List full details of all Hotels
var hotelsQuery = from hotel in hotels select hotel;
foreach (var hotel in hotelsQuery)
{
    Console.WriteLine(hotel);
}
Console.WriteLine();

// 2) List full details of all hotels in Roskilde
hotelsQuery = from hotel in hotels where hotel.Address.Contains("Roskilde") select hotel;
foreach (var hotel in hotelsQuery)
{
    Console.WriteLine(hotel);
}
Console.WriteLine();

// 3) List the names of all hotels in Roskilde
var hotelsQuery1 = from hotel in hotels where hotel.Address.Contains("Roskilde") select hotel.Name;
foreach (var hotel in hotelsQuery1)
{
    Console.WriteLine(hotel);
}
Console.WriteLine();

// 4)List all double rooms with a price below 400 pr night
var roomQuery = from room in rooms where room.Types == 'D' && room.Price < 400 select room;
foreach (var room in roomQuery)
{
    Console.WriteLine(room);
}
Console.WriteLine();

// 5)List all double or family rooms with a price below 400 pr night in ascending order of price
roomQuery = from room in rooms
            where (room.Types == 'D' || room.Types == 'F') && room.Price < 400
            orderby room.Price
            select room;
foreach (var room in roomQuery)
{
    Console.WriteLine(room);
}
Console.WriteLine();

// 6)List all hotels that starts with 'P'
Console.WriteLine("All hotels that starts with P: ");
var hotelsQuery2 = from hotel in hotels where hotel.Name.StartsWith("P") select hotel.Name;
foreach (var hotel in hotelsQuery2)
{
    Console.WriteLine(hotel);
}
Console.WriteLine();


// 7)List the number of hotels
var hotelsQuery3 = hotels.Count();
Console.WriteLine("Total no of hotels: ");
Console.WriteLine(hotelsQuery3);
Console.WriteLine();

// 8)List the number of hotels in Roskilde
var hotelsQuery4 = hotels.Count(hotel => hotel.Address.Contains("Roskilde"));
Console.WriteLine("No of hotels in Roskilde: ");
Console.WriteLine(hotelsQuery4);
Console.WriteLine();

// 9)what is the avarage price of a room
var roomQuery1 = from room in rooms select room.Price;
Console.WriteLine("Avarage price of a room: ");
Console.WriteLine((int)roomQuery1.Average());
Console.WriteLine();



//10)what is the avarage price of a room at Hotel Scandic
var joinQuery = from room in rooms
                join hotel in hotels
                on room.HotelNo equals hotel.HotelNo
                where hotel.Name.Equals("Scandic")
                select room.Price;

Console.WriteLine("Avarage price of a room at Hotel Scandic: ");
Console.WriteLine((int)joinQuery.Average());
Console.WriteLine();

//11)what is the total reveneue per night from all double rooms
roomQuery1 = from room in rooms where room.Types == 'D' select room.Price;
Console.WriteLine("Total reveneue from all double rooms: ");
Console.WriteLine(roomQuery1.Sum());
Console.WriteLine();

//12)List distinct price and type of all rooms at Hotel Prindsen
var joinQuery1 = from room in rooms
                 join hotel in hotels
                 on room.HotelNo equals hotel.HotelNo
                 where hotel.Name.Equals("Prindsen")
                 select new { price = room.Price, type = room.Types };

Console.WriteLine("Price and type of all rooms at Hotel Prindsen: ");
foreach (var priceAndType in joinQuery1)
{
    Console.WriteLine("Price: " + priceAndType.price + " Type: " + priceAndType.type);
}
Console.WriteLine();

//13)List distinct price and type of all rooms at Hotel Prindsen
var joinQuery2 = (from room in rooms
                  join hotel in hotels
                  on room.HotelNo equals hotel.HotelNo
                  where hotel.Name.Equals("Prindsen")
                  select new { price = room.Price, type = room.Types }).Distinct();

Console.WriteLine("Distinct Price and type of all rooms at Hotel Prindsen: ");
foreach (var priceAndType in joinQuery2)
{
    Console.WriteLine("Price: " + priceAndType.price + " Type: " + priceAndType.type);
}
Console.WriteLine();