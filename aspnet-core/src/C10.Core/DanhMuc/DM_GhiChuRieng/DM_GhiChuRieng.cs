using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_GhiChuRieng
{
    [Table("DM_GHI_CHU_RIENG")]
    public class DM_GhiChuRieng : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string GCR_NoiDung { get; set; }

        [MaxLength(10)]
        public string GCR_Code { get; set; }
        public bool GCR_IsActive { get; set; }

    }

}
