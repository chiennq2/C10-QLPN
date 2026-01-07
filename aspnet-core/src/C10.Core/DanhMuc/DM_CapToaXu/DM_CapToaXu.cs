using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_CapToaXu
{
    [Table("DM_CAP_TOA_XU")]
    public class DM_CapToaXu : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string CTX_NoiDung { get; set; }
        [MaxLength(10)]
        public string CTX_Code { get; set; }
        public bool CTX_IsActive { get; set; }
    }
}
