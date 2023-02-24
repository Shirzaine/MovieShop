using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("CommunicationLogs")]
    public class CommunicationLogs
    {
        [Key]
        public Guid CommunicationLogId { get; set; }
        public Guid CommunicationTypeId { get; set; }
        public string? CommunicationTypeName { get; set; }
       
        public int IsSent { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Customer> Customers { get; set; }

    }
}
