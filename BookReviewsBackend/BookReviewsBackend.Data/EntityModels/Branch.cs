using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewsBackend.Data.EntityModels
{
    class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BranchId { get; set; }
        public int LibraryId { get; set; }
        public string Location { get; set; }
        public decimal TotalRating { get; set; }
        public int PersonRatingCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid LastModifiedUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
