using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            using (var _context = new BookDBcontext())
            {
                // Publisher publisher = new Publisher();
                // publisher.PublisherName = "Sarasavi";

                // _context.Publishers.Add(publisher);
                // _context.SaveChanges();
                Publisher publisher = _context.Publishers.FirstOrDefault();
                // publisher.PublisherName = "Sarasavi Book Shop";
                _context.Publishers.Remove(publisher);
                _context.SaveChanges();

                return _context.Publishers.ToList();

            }
           // return new List<Publisher>();
        }
    }
}
