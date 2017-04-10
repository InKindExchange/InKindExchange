using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InKindExchange.Website.Models
{
    public class Listing : IListing
    {
        public int Id { get; set; }
        public DateTime ListingDate { get; set; }
        public ListingType ListingType { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        //public LinkedList<Guid> ImageNames { get; set; }
    }
}
