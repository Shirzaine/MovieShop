using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApplication.Models
{
    [Table("CommonColumn")]
    public class CommonColumn
    {
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string? ModifiedBy { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
    }
}
