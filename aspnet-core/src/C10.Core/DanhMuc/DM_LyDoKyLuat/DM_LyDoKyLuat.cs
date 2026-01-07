using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LyDoKyLuat
{
    [Table("DM_LY_DO_KY_LUAT")]
    public class DM_LyDoKyLuat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LDKL_NoiDung { get; set; }
        [MaxLength(10)]
        public string LDKL_Code { get; set; }
        public bool LDKL_IsActive { get; set; }
    }
}
