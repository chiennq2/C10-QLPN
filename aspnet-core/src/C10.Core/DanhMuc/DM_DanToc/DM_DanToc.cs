using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_DanToc
{
    [Table("DM_DAN_TOC")]
    public class DM_DanToc : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string DT_NoiDung { get; set; }

        [MaxLength(10)]
        public string DT_Code { get; set; }
        public bool DT_IsActive { get; set; }
    }
}
