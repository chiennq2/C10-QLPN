using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_HinhPhatBoSung
{
    [Table("DM_HINH_PHAT_BO_SUNG")]

    public class DM_HinhPhatBoSung : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string HPBS_NoiDung { get; set; }
        [MaxLength(10)]
        public string HPBS_Code { get; set; }
        public bool HPBS_IsActive { get; set; }
    }
}
