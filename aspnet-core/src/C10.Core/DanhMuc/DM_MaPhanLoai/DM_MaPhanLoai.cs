using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_MaPhanLoai
{
    [Table("DM_MA_PHAN_LOAI")]

    public class DM_MaPhanLoai : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string MPL_NoiDung { get; set; }
        [MaxLength(10)]
        public string MPL_Code { get; set; }
        public bool MPL_IsActive { get; set; }
    }
}
