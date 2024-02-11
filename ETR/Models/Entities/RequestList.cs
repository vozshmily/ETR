using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETR.Models.Entities
{
    public class RequestList
    {
        [Key]
        public int Id { get; set; }
        public string RequestorName { get; set; }
        public DateTime RequestDate { get; set; }
        public string ProjectName { get; set; }
        public string COG { get; set; }
        public string EquipmentNumber { get; set; }
        public string EquipmentType { get; set; }
        public string EquipmentYard { get; set; }
        public DateTime EquipmentRecordDate { get; set; }
        public DateTime DateEncoded { get; set; }
        public string FirstShiftOperatorName { get; set; }
        public string SecondShiftOperatorName { get; set; }

        // Foreign key for User
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        // Navigation property for ItemList
        public ICollection<ItemList> ItemLists { get; set; }
    }
}
