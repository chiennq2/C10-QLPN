using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_TruongHopBat
{
    [Table("DM_TRUONG_HOP_BAT")]

    public class DM_TruongHopBat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string THB_NoiDung { get; set; }
        [MaxLength(10)]
        public string THB_Code { get; set; }
        public bool THB_IsActive { get; set; }
    }
}
