using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_QuocTich
{
    [Table("DM_QUOC_TICH")]

    public class DM_QuocTich : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string QT_NoiDung { get; set; }
        [MaxLength(10)]
        public string QT_Code { get; set; }
        public bool QT_IsActive { get; set; }
    }
}
