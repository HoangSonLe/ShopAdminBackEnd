using Core.Enums;
using System.ComponentModel.DataAnnotations;

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

        public EShipMethodType ShippingMethodType { get; set; }
        public ICollection<Bill> Bills { get; set; }

    }
}
