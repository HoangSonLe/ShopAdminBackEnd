using Core.Enums;
using Core.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entitites
{
    public class Voucher : BaseAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public required string VoucherName { get; set; }
        public required string VoucherNameNonUnicode { get; set; }
        public string Description { get; set; }
        public float DiscountAmount { get; set; } 
        /// <summary>
        /// Giảm tối đa bao nhiêu tiền
        /// </summary>
        public float MaxPrice { get; set; }
        /// <summary>
        /// Đơn tối thiểu bao nhiêu tiền
        /// </summary>
        public float MinPriceBill { get; set; }
        public float DiscountPercent { get; set; } 
        public EVoucherType VoucherType { get; set; }
        /// <summary>
        /// Số lượt sử dụng
        /// </summary>
        public int UsesTimes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
