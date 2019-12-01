using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinareBodyApp.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    
    }
}
    

