using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LyDoAnGiam
{
    [Table("DM_LY_DO_AN_GIAM")]

    public class DM_LyDoAnGiam : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LDAG_NoiDung { get; set; }
        [MaxLength(10)]
        public string LDAG_Code { get; set; }
        public bool LDAG_IsActive { get; set; }
    }
}
