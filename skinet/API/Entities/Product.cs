using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace API.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}