using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_HinhThucChon
{
    [Table("DM_HINH_THUC_CHON")]

    public class DM_HinhThucChon : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string HTC_NoiDung { get; set; }
        [MaxLength(10)]
        public string HTC_Code { get; set; }
        public bool HTC_IsActive { get; set; }
    }
}
