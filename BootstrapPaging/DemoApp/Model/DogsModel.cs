using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Model
{
    public class DogsModel
    {
        public int TotalSize { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public List<Dog> Items { get; set; }
    }

    public class Dog
    {
        public string Name { get; set; }

        public int Id { get; set; }
    }
}
