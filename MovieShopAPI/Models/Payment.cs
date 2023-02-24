using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("Payment")]
    public class Payment
    {
        public Guid PaymentId { get; set; }
        [Required]
        public string? ModeOfPayment { get; set; }
        public string? TransactionReference { get; set; }
        public decimal Amount { get; set; }
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public  Movie Movie { get; set; }
    }
}
