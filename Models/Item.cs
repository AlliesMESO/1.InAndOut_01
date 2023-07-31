using System.ComponentModel.DataAnnotations;

namespace _1.InAndOut_01.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
    }
}
