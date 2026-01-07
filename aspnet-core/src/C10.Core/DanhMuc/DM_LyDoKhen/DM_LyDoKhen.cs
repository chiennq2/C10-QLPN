using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LyDoKhen
{
    [Table("DM_LY_DO_KHEN")]
    public class DM_LyDoKhen : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LDK_NoiDung { get; set; }
        [MaxLength(10)]
        public string LDK_Code { get; set; }
        public bool LDK_IsActive { get; set; }
    }
}
