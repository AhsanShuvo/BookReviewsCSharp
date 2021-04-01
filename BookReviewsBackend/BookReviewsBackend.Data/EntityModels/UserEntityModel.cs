using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewsBackend.Data.EntityModels
{
    class UserEntityModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int TotalAddedBook { get; set; }
        public int TotalAddedLibrary { get; set; }
        public int ContributePoint { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
