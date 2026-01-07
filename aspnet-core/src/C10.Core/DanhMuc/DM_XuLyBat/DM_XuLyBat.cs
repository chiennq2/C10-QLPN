using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_XuLyBat
{
    [Table("DM_XU_LY_BAT")]

    public class DM_XuLyBat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string XLB_NoiDung { get; set; }
        [MaxLength(10)]
        public string XLB_Code { get; set; }
        public bool XLB_IsActive { get; set; }
    }
}
