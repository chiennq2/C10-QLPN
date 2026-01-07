using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_GioiTinh
{
    [Table("DM_GIOI_TINH")]
    public class DM_GioiTinh : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string GT_NoiDung { get; set; }

        [MaxLength(10)]
        public string GT_Code { get; set; }
        public bool GT_IsActive { get; set; }
    }
}
