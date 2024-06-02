using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_5_3_nedvigimost
{
    public class buying_a_property<T>where T : IRealEstate
    {
        public string FIO_buyer;
        public string FIO_seller;
        public T Real_estate;
        public double Cost;

        public buying_a_property(string fIO_buyer, string fIO_seller, T real_estate, double cost)
        {
            FIO_buyer = fIO_buyer;
            FIO_seller = fIO_seller;
            Real_estate = real_estate;
            Cost = cost;
        }

        public void Info()
        {
            Console.WriteLine($"Продавец:   {FIO_seller}");
            Console.WriteLine($"Покупатель: {FIO_buyer}");
            Console.WriteLine($"Недвижимость: {Real_estate.TypeRealEstate}, Цена: {Cost}");
            Console.WriteLine($"Площадь: {Real_estate.Area}, Количество комнат: {Real_estate.NumberOfRooms}, Адрес: {Real_estate.Address}");
        }

        public void Cost_Per_Square_Meter()
        {
            Console.WriteLine($"Стоимость кв.метра = {Cost/Real_estate.Area}");
        }

    }
}
