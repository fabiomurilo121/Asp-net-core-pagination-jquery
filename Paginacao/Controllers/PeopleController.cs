using Microsoft.AspNetCore.Mvc;
using PeopleFiltering.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleFiltering.Controllers
{
    public class PeopleController : Controller
    {
        private static List<Person> People = new List<Person>
        {
            new Person { Id = 1, Name = "John Doe", Age = 30, MaritalStatus = "Single" },
            new Person { Id = 2, Name = "Jane Doe", Age = 25, MaritalStatus = "Married" },
            new Person { Id = 3, Name = "Alice Johnson", Age = 28, MaritalStatus = "Single" },
            new Person { Id = 4, Name = "Bob Smith", Age = 35, MaritalStatus = "Married" },
            new Person { Id = 5, Name = "Charlie Brown", Age = 22, MaritalStatus = "Single" },
            new Person { Id = 6, Name = "Diana Prince", Age = 32, MaritalStatus = "Married" },
            new Person { Id = 7, Name = "Evan Davis", Age = 27, MaritalStatus = "Single" },
            new Person { Id = 8, Name = "Fiona Green", Age = 31, MaritalStatus = "Married" },
            new Person { Id = 9, Name = "George Harris", Age = 26, MaritalStatus = "Single" },
            new Person { Id = 10, Name = "Hannah Walker", Age = 29, MaritalStatus = "Single" },
            new Person { Id = 11, Name = "Ian Scott", Age = 34, MaritalStatus = "Married" },
            new Person { Id = 12, Name = "Jane Miller", Age = 24, MaritalStatus = "Single" },
            new Person { Id = 13, Name = "Kevin Clark", Age = 33, MaritalStatus = "Married" },
            new Person { Id = 14, Name = "Laura Young", Age = 21, MaritalStatus = "Single" },
            new Person { Id = 15, Name = "Michael Baker", Age = 30, MaritalStatus = "Married" },
            new Person { Id = 16, Name = "Nancy Adams", Age = 25, MaritalStatus = "Single" },
            new Person { Id = 17, Name = "Oliver Thompson", Age = 28, MaritalStatus = "Married" },
            new Person { Id = 18, Name = "Patricia Carter", Age = 27, MaritalStatus = "Single" },
            new Person { Id = 19, Name = "Quincy Martinez", Age = 31, MaritalStatus = "Married" },
            new Person { Id = 20, Name = "Rachel White", Age = 22, MaritalStatus = "Single" },
            new Person { Id = 21, Name = "Steven Lewis", Age = 32, MaritalStatus = "Married" },
            new Person { Id = 22, Name = "Tina Lee", Age = 26, MaritalStatus = "Single" },
            new Person { Id = 23, Name = "Uma Thompson", Age = 29, MaritalStatus = "Single" },
            new Person { Id = 24, Name = "Victor Wright", Age = 34, MaritalStatus = "Married" },
            new Person { Id = 25, Name = "Wendy Harris", Age = 24, MaritalStatus = "Single" },
            new Person { Id = 26, Name = "Xander Young", Age = 33, MaritalStatus = "Married" },
            new Person { Id = 27, Name = "Yara Scott", Age = 21, MaritalStatus = "Single" },
            new Person { Id = 28, Name = "Zachary King", Age = 30, MaritalStatus = "Married" },
            new Person { Id = 29, Name = "Abby Walker", Age = 25, MaritalStatus = "Single" },
            new Person { Id = 30, Name = "Brian Hall", Age = 28, MaritalStatus = "Married" },
            new Person { Id = 31, Name = "Cathy Allen", Age = 27, MaritalStatus = "Single" },
            new Person { Id = 32, Name = "David Robinson", Age = 31, MaritalStatus = "Married" },
            new Person { Id = 33, Name = "Ella Garcia", Age = 22, MaritalStatus = "Single" },
            new Person { Id = 34, Name = "Frank Moore", Age = 32, MaritalStatus = "Married" },
            new Person { Id = 35, Name = "Grace Lopez", Age = 26, MaritalStatus = "Single" },
            new Person { Id = 36, Name = "Henry Perez", Age = 29, MaritalStatus = "Single" },
            new Person { Id = 37, Name = "Isabella Cooper", Age = 34, MaritalStatus = "Married" },
            new Person { Id = 38, Name = "Jack Murphy", Age = 24, MaritalStatus = "Single" },
            new Person { Id = 39, Name = "Katherine Reed", Age = 33, MaritalStatus = "Married" },
            new Person { Id = 40, Name = "Liam Powell", Age = 21, MaritalStatus = "Single" },
            new Person { Id = 41, Name = "Mia Jenkins", Age = 30, MaritalStatus = "Married" },
            new Person { Id = 42, Name = "Noah Kelly", Age = 25, MaritalStatus = "Single" },
            new Person { Id = 43, Name = "Olivia Brown", Age = 28, MaritalStatus = "Single" },
            new Person { Id = 44, Name = "Paul Anderson", Age = 34, MaritalStatus = "Married" },
            new Person { Id = 45, Name = "Quinn Wilson", Age = 22, MaritalStatus = "Single" },
            new Person { Id = 46, Name = "Rebecca Carter", Age = 32, MaritalStatus = "Married" },
            new Person { Id = 47, Name = "Samuel Harris", Age = 27, MaritalStatus = "Single" },
            new Person { Id = 48, Name = "Tina Collins", Age = 31, MaritalStatus = "Married" },
            new Person { Id = 49, Name = "Ulysses Martinez", Age = 26, MaritalStatus = "Single" },
            new Person { Id = 50, Name = "Victoria Clark", Age = 29, MaritalStatus = "Single" },
            new Person { Id = 51, Name = "Walter Lewis", Age = 34, MaritalStatus = "Married" },
            new Person { Id = 52, Name = "Xena Young", Age = 24, MaritalStatus = "Single" },
            new Person { Id = 53, Name = "Yvonne Adams", Age = 33, MaritalStatus = "Married" },
            new Person { Id = 54, Name = "Zachary Scott", Age = 21, MaritalStatus = "Single" },
            new Person { Id = 55, Name = "Aiden King", Age = 30, MaritalStatus = "Married" },
            new Person { Id = 56, Name = "Bella Walker", Age = 25, MaritalStatus = "Single" },
            new Person { Id = 57, Name = "Carter Hall", Age = 28, MaritalStatus = "Married" },
            new Person { Id = 58, Name = "Derek Allen", Age = 27, MaritalStatus = "Single" },
            new Person { Id = 59, Name = "Eva Robinson", Age = 31, MaritalStatus = "Married" },
            new Person { Id = 60, Name = "Felix Garcia", Age = 22, MaritalStatus = "Single" },
            new Person { Id = 61, Name = "Grace Moore", Age = 32, MaritalStatus = "Married" },
            new Person { Id = 62, Name = "Henry Lopez", Age = 26, MaritalStatus = "Single" },
            new Person { Id = 63, Name = "Ivy Perez", Age = 29, MaritalStatus = "Single" },
            new Person { Id = 64, Name = "Jack Murphy", Age = 24, MaritalStatus = "Single" },
            new Person { Id = 65, Name = "Katherine Reed", Age = 33, MaritalStatus = "Married" },
            new Person { Id = 66, Name = "Liam Powell", Age = 21, MaritalStatus = "Single" },
            new Person { Id = 67, Name = "Mia Jenkins", Age = 30, MaritalStatus = "Married" },
            new Person { Id = 68, Name = "Noah Kelly", Age = 25, MaritalStatus = "Single" },
            new Person { Id = 69, Name = "Olivia Brown", Age = 28, MaritalStatus = "Single" },
            new Person { Id = 70, Name = "Paul Anderson", Age = 34, MaritalStatus = "Married" },
            new Person { Id = 71, Name = "Quinn Wilson", Age = 22, MaritalStatus = "Single" },
            new Person { Id = 72, Name = "Rebecca Carter", Age = 32, MaritalStatus = "Married" },
            new Person { Id = 73, Name = "Samuel Harris", Age = 27, MaritalStatus = "Single" },
            new Person { Id = 74, Name = "Tina Collins", Age = 31, MaritalStatus = "Married" },
            new Person { Id = 75, Name = "Ulysses Martinez", Age = 26, MaritalStatus = "Single" },
            new Person { Id = 76, Name = "Victoria Clark", Age = 29, MaritalStatus = "Single" },
            new Person { Id = 77, Name = "Walter Lewis", Age = 34, MaritalStatus = "Married" },
            new Person { Id = 78, Name = "Xena Young", Age = 24, MaritalStatus = "Single" },
            new Person { Id = 79, Name = "Yvonne Adams", Age = 33, MaritalStatus = "Married" },
            new Person { Id = 80, Name = "Zachary Scott", Age = 21, MaritalStatus = "Single" },
            new Person { Id = 81, Name = "Aiden King", Age = 30, MaritalStatus = "Married" },
            new Person { Id = 82, Name = "Bella Walker", Age = 25, MaritalStatus = "Single" },
            new Person { Id = 83, Name = "Carter Hall", Age = 28, MaritalStatus = "Married" },
            new Person { Id = 84, Name = "Derek Allen", Age = 27, MaritalStatus = "Single" },
            new Person { Id = 85, Name = "Eva Robinson", Age = 31, MaritalStatus = "Married" },
            new Person { Id = 86, Name = "Felix Garcia", Age = 22, MaritalStatus = "Single" },
            new Person { Id = 87, Name = "Grace Moore", Age = 32, MaritalStatus = "Married" },
            new Person { Id = 88, Name = "Henry Lopez", Age = 26, MaritalStatus = "Single" },
            new Person { Id = 89, Name = "Ivy Perez", Age = 29, MaritalStatus = "Single" },
            new Person { Id = 90, Name = "Jack Murphy", Age = 24, MaritalStatus = "Single" },
            new Person { Id = 91, Name = "Katherine Reed", Age = 33, MaritalStatus = "Married" },
            new Person { Id = 92, Name = "Liam Powell", Age = 21, MaritalStatus = "Single" },
            new Person { Id = 93, Name = "Mia Jenkins", Age = 30, MaritalStatus = "Married" },
            new Person { Id = 94, Name = "Noah Kelly", Age = 25, MaritalStatus = "Single" },
            new Person { Id = 95, Name = "Olivia Brown", Age = 28, MaritalStatus = "Single" },
            new Person { Id = 96, Name = "Paul Anderson", Age = 34, MaritalStatus = "Married" },
            new Person { Id = 97, Name = "Quinn Wilson", Age = 22, MaritalStatus = "Single" },
            new Person { Id = 98, Name = "Rebecca Carter", Age = 32, MaritalStatus = "Married" },
            new Person { Id = 99, Name = "Samuel Harris", Age = 27, MaritalStatus = "Single" },
            new Person { Id = 100, Name = "Tina Collins", Age = 31, MaritalStatus = "Married" }
        };


        public IActionResult Index(string nameFilter, int? ageFilter, string maritalStatusFilter, int page = 1, int pageSize = 10)
        {
            var filteredPeople = People.AsQueryable();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                filteredPeople = filteredPeople.Where(p => p.Name.Contains(nameFilter));
            }

            if (ageFilter.HasValue)
            {
                filteredPeople = filteredPeople.Where(p => p.Age == ageFilter.Value);
            }

            if (!string.IsNullOrEmpty(maritalStatusFilter))
            {
                filteredPeople = filteredPeople.Where(p => p.MaritalStatus == maritalStatusFilter);
            }

            var paginatedPeople = filteredPeople
                                  .Skip((page - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(filteredPeople.Count() / (double)pageSize);
            ViewBag.PageSize = pageSize;

            // Passando uma lista de valores para o ViewBag
            ViewBag.PageSizeOptions = new List<int> { 5, 10, 20, 50 };

            return View(paginatedPeople);
        }


    }
}
