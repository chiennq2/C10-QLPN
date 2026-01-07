using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LyDoKhongXetGiam
{
    [Table("DM_LY_DO_KHONG_XET_GIAM")]

    public class DM_LyDoKhongXetGiam : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LDKXG_NoiDung { get; set; }
        [MaxLength(10)]
        public string LDKXG_Code { get; set; }
        public bool LDKXG_IsActive { get; set; }
    }
}
