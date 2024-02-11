using System.ComponentModel.DataAnnotations;

namespace ETR.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation property for RequestList
        public ICollection<RequestList> RequestLists { get; set; }
    }
}
