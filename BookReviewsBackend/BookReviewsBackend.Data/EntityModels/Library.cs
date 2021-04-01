using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewsBackend.Data.EntityModels
{
    public class Library
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibraryId { get; set; }
        public string LibraryName { get; set; }
        public Guid CreatorUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalRating { get; set; }
        public int PersonRatingCount { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string ImageName { get; set; }
        public int BuyerCount { get; set; }
    }
}
