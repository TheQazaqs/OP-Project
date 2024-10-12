﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;


namespace Product
{
    public class Product
    {
        static void Main(string[] args)
        { }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название: {Name}, Цена: {Price}, Описание: {Description}");
        }
    }
}