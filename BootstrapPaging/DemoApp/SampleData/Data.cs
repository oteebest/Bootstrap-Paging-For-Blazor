using DemoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.SampleData
{
    public class Data
    {
        List<Dog> items = new List<Dog>();

        public Data()
        {
          
            items.Add(new Dog { Name = "Dog A", Id = 1 });
            items.Add(new Dog { Name = "Dog B", Id = 2 });
            items.Add(new Dog { Name = "Dog C", Id = 3 });
            items.Add(new Dog { Name = "Dog D", Id = 4 });
            items.Add(new Dog { Name = "Dog E", Id = 5 });
            items.Add(new Dog { Name = "Dog F", Id = 6 });
            items.Add(new Dog{ Name = "Dog G", Id = 7 });
            items.Add(new Dog{ Name = "Dog H", Id = 8 });
            items.Add(new Dog{ Name = "Dog I", Id = 9 });
            items.Add(new Dog{ Name = "Dog J", Id = 10 });
            items.Add(new Dog{ Name = "Dog K", Id = 11 });
            items.Add(new Dog{ Name = "Dog L", Id = 12 });
            items.Add(new Dog{ Name = "Dog M", Id = 13 });
            items.Add(new Dog{ Name = "Dog N", Id = 14 });
            items.Add(new Dog{ Name = "Dog O", Id = 15 });
            items.Add(new Dog{ Name = "Dog P", Id = 16 });
            items.Add(new Dog{ Name = "Dog Q", Id = 17 });
            items.Add(new Dog{ Name = "Dog R", Id = 18 });
            items.Add(new Dog{ Name = "Dog S", Id = 19 });
            items.Add(new Dog{ Name = "Dog T", Id = 20 });
            items.Add(new Dog{ Name = "Dog U", Id = 21 });
            items.Add(new Dog{ Name = "Dog V", Id = 22 });
            items.Add(new Dog{ Name = "Dog W", Id = 23 });
            items.Add(new Dog{ Name = "Dog X", Id = 24 });
            items.Add(new Dog{ Name = "Dog Y", Id = 25 });
            items.Add(new Dog{ Name = "Dog Z", Id = 26 });
        }

        public DogsModel GetItems(int pageNumber, int pageSize)
        {
            var list = items.OrderBy(u => u.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return new DogsModel
            {
                Items = list,
                TotalSize = items.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}
