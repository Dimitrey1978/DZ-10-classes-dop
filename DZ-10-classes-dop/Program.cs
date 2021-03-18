﻿using System;

namespace DZ_10_classes_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addr = new Address();
            addr.Index = "153521";
            addr.Country = "Арканар";
            addr.City = "Некрополис";
            addr.Street = "Рябиновая";
            addr.House = "14";
            addr.Apartment = "1";
            Console.WriteLine($"Индекс: {addr.Index}");
            Console.WriteLine($"Страна: {addr.Country}");
            Console.WriteLine($"Город: {addr.City}");
            Console.WriteLine($"Улица: {addr.Street}");
            Console.WriteLine($"Дом: {addr.House}");
            Console.WriteLine($"Квартира: {addr.Apartment}");
        }
    }

    class Address
    {
        string index;
        string country;
        string city;
        string street;
        string house;
        string apartment;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }


}
