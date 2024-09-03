using Core.Enums;

namespace Infrastructure.Entitites
{
    public abstract class BaseAuditableEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        public DateTime? UpdatedDate { get; set; } = DateTime.Now;

        public long? UpdatedBy { get; set; } = 1;
        /// <summary>
        /// EState
        /// </summary>
        public int State { get; set; } = (int)EState.Active;

    }
}
