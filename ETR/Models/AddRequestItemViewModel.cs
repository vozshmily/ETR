using ETR.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ETR.Models
{
    public class AddRequestItemViewModel
    {
        public string RequestNumber { get; set; }
        public string RequestorName { get; set; }
        public DateTime RequestDate { get; set; }

        // Property to hold the list of ItemList items
        public List<ItemListViewModel> ItemLists { get; set; }
    }

    public class ItemListViewModel
    {
        public string Time { get; set; }
        public EquipmentStatus EquipmentStatus { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
