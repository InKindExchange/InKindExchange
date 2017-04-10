using System;

namespace InKindExchange.Website.Models
{
    public interface IListing
    {
        int Id { get; set; }
        ListingType ListingType { get; set; }
        string Name { get; set; }
        string Desc { get; set; }
        DateTime ListingDate { get; set; }
    }
}