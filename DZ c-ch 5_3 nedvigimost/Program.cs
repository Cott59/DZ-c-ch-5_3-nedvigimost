namespace DZ_c_ch_5_3_nedvigimost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Apartment apartment1 = new Apartment();
            apartment1.TypeRealEstate = "Квартира";
            apartment1.Area = 35.5;
            apartment1.NumberOfRooms = 1;
            apartment1.Address = "Lenina 45";
            apartment1.Balcony = true;
            apartment1.Gas = true;
            apartment1.Floor = 3;

            House house1 = new House();
            house1.TypeRealEstate = "Дом";
            house1.Area = 165.43;
            house1.NumberOfRooms = 5;
            house1.Address = "Pushkina 15";
            house1.NumberOfFloor = 2;
            house1.AreaOfLand = 1400;

            buying_a_property<House> buyingAProperty1 = new buying_a_property<House>("Петров Иван Иванович", 
                "Шниперсон Софа Моисеевна", house1, 3480000);
            

            buyingAProperty1.Info();
            buyingAProperty1.Cost_Per_Square_Meter();









        }
    }
}
