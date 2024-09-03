﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class Promotion
    {
        [Key]
        public int Id { get; set; }
        public required string PromotionName { get; set; }
        public required string PromotionNameNonUnicode { get; set; }
        public string Description { get; set; }
        public float DiscountPercentAmount { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        public ICollection<Promotion_Tag> Tags { get; set; }
    }
}
