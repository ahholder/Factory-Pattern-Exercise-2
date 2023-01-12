﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from ListDataAccess.");
            return new List<Product> { new Product() };
        }
        public void SaveData() 
        {
            Console.WriteLine("I am saving data to a ListDataAccess database.");
        }
    }
}