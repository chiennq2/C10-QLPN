using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LyDoTrichXuat
{
    [Table("DM_LY_DO_TRICH_XUAT")]

    public class DM_LyDoTrichXuat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LDTX_NoiDung { get; set; }
        [MaxLength(10)]
        public string LDTX_Code { get; set; }
        public bool LDTX_IsActive { get; set; }
    }
}
