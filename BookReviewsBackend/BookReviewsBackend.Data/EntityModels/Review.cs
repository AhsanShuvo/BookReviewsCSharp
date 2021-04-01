using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewsBackend.Data.EntityModels
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewId { get; set; }
        public Guid CreatorUserId { get; set; }
        public string Description { get; set; }
        public string TypeOfSource { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
