using Core.Enums;
using Core.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entitites
{
    public class Ship : BaseAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public required string ShipName { get; set; }
        public required string ShipNameNonUnicode { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// VNĐ/KM
        /// </summary>
        public float PricePerKm { get; set; }

        public string ShippingMethod { get; set; }
        public ICollection<Bill_Ship> BillShips { get; set; }

    }
}
