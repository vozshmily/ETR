using Azure.Core;
using ETR.Data.Enum;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETR.Models.Entities
{
    public class ItemList : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        // Foreign key for RequestList
        [ForeignKey("RequestList")]
        public int RequestID { get; set; }
        public RequestList RequestList { get; set; }

        public DateTime Time { get; set; }
        public string EquipmentStatus { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
