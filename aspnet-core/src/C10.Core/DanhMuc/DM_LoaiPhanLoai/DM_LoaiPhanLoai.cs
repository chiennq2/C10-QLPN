using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LoaiPhanLoai
{
    [Table("DM_LOAI_PHAN_LOAI")]

    public class DM_LoaiPhanLoai : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LPL_NoiDung { get; set; }
        [MaxLength(10)]
        public string LPL_Code { get; set; }
        public bool LPL_IsActive { get; set; }
    }
}
