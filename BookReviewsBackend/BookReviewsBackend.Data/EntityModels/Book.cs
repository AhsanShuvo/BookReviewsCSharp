using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewsBackend.Data.EntityModels
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public Guid CreatorUserId { get; set; }
        public decimal TotalRating { get; set; }
        public Guid LastModifiedUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int PersonRatingCount { get; set; }
        public string ImageName { get; set; }
        public int ViewCount { get; set; }
    }
}
