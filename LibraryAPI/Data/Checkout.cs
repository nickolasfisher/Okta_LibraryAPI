using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryAPI.Data
{
    public class Checkout
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public bool Active { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }

        public DateTime? CheckinDate { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
