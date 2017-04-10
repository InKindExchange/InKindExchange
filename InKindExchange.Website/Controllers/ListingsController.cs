using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InKindExchange.Website.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InKindExchange.Website.Controllers
{
    [Route("api/[controller]")]
    public class ListingsController : Controller
    {
        private List<Listing> _listings;

        public ListingsController()
        {
            PopulateListings();
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Listing> Get()
        {
            return _listings;
        }

        // GET: api/values
        [HttpGet("haves")]
        public IEnumerable<Listing> Haves()
        {
            return _listings
                .Where(l => l.ListingType == ListingType.Have);
        }

        // GET: api/values
        [HttpGet("needs")]
        public IEnumerable<Listing> Needs()
        {
            return _listings
                .Where(l => l.ListingType == ListingType.Need);
        }

        // GET: api/values
        [HttpGet("recent/{count}")]
        public IEnumerable<Listing> Recent(int count)
        {
            var enumerable = _listings
                .OrderByDescending(l => l.ListingDate)
                .Take(count);

            return enumerable;
        }

        // GET: api/values
        [HttpGet("recenttypes/{listingType}/{count}")]
        public IEnumerable<Listing> RecentTypes(ListingType listingType, int count)
        {
            var enumerable = _listings
                .Where(l => l.ListingType == listingType)
                .OrderByDescending(l => l.ListingDate)
                .Take(count);

            return enumerable;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Listing Get(int id)
        {
            return _listings.SingleOrDefault(l => l.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Listing value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Listing value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        /// <summary>
        /// Hardcoded for now...
        /// </summary>
        private void PopulateListings()
        {
            _listings =
                new List<Listing>
                {
                    new Listing
                    {
                        Id = 1,
                        ListingDate = DateTime.Parse("1/1/15"),
                        ListingType = ListingType.Have,
                        Name = "Frances",
                        Desc =
                            "In eleifend pretium bibendum. Cras commodo commodo lorem, a consectetur quam porta a. Proin euismod, ex vel pharetra finibus, enim nunc egestas quam, scelerisque blandit nulla turpis vitae erat. Donec a mauris magna. Vivamus tellus tortor, volutpat eu vulputate nec, ullamcorper vel purus."
                    },
                    new Listing
                    {
                        Id = 2,
                        ListingDate = DateTime.Parse("1/2/15"),
                        ListingType = ListingType.Have,
                        Name = "Christian",
                        Desc =
                            "Praesent convallis purus nulla, quis interdum quam ullamcorper sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;."
                    },
                    new Listing
                    {
                        Id = 3,
                        ListingDate = DateTime.Parse("1/3/15"),
                        ListingType = ListingType.Need,
                        Name = "Olive",
                        Desc =
                            "In ante velit, sollicitudin nec venenatis in, aliquam sed tellus. Cras quis turpis nec metus euismod facilisis. Vivamus consequat mi eu quam porta luctus. Vestibulum felis quam, gravida quis dui id, ultrices lacinia tortor."
                    },
                    new Listing
                    {
                        Id = 4,
                        ListingDate = DateTime.Parse("1/1/15"),
                        ListingType = ListingType.Have,
                        Name = "Harry",
                        Desc =
                            "In eleifend pretium bibendum. Cras commodo commodo lorem, a consectetur quam porta a. Proin euismod, ex vel pharetra finibus, enim nunc egestas quam, scelerisque blandit nulla turpis vitae erat. Donec a mauris magna. Vivamus tellus tortor, volutpat eu vulputate nec, ullamcorper vel purus."
                    },
                    new Listing
                    {
                        Id = 5,
                        ListingDate = DateTime.Parse("1/2/15"),
                        ListingType = ListingType.Need,
                        Name = "Erick",
                        Desc =
                            "Praesent convallis purus nulla, quis interdum quam ullamcorper sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;."
                    },
                    new Listing
                    {
                        Id = 6,
                        ListingDate = DateTime.Parse("1/3/15"),
                        ListingType = ListingType.Need,
                        Name = "Ebbie",
                        Desc =
                            "In ante velit, sollicitudin nec venenatis in, aliquam sed tellus. Cras quis turpis nec metus euismod facilisis. Vivamus consequat mi eu quam porta luctus. Vestibulum felis quam, gravida quis dui id, ultrices lacinia tortor."
                    },
                    new Listing
                    {
                        Id = 7,
                        ListingDate = DateTime.Parse("1/1/15"),
                        ListingType = ListingType.Have,
                        Name = "Misty",
                        Desc =
                            "In eleifend pretium bibendum. Cras commodo commodo lorem, a consectetur quam porta a. Proin euismod, ex vel pharetra finibus, enim nunc egestas quam, scelerisque blandit nulla turpis vitae erat. Donec a mauris magna. Vivamus tellus tortor, volutpat eu vulputate nec, ullamcorper vel purus."
                    },
                    new Listing
                    {
                        Id = 8,
                        ListingDate = DateTime.Parse("1/2/15"),
                        ListingType = ListingType.Need,
                        Name = "Gerbilly",
                        Desc =
                            "Praesent convallis purus nulla, quis interdum quam ullamcorper sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;."
                    },
                    new Listing
                    {
                        Id = 9,
                        ListingDate = DateTime.Parse("1/3/15"),
                        ListingType = ListingType.Need,
                        Name = "Margo",
                        Desc =
                            "In ante velit, sollicitudin nec venenatis in, aliquam sed tellus. Cras quis turpis nec metus euismod facilisis. Vivamus consequat mi eu quam porta luctus. Vestibulum felis quam, gravida quis dui id, ultrices lacinia tortor."
                    },
                };
        }
    }
}