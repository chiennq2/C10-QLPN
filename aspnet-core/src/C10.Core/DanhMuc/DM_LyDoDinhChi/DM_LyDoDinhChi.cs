using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LyDoDinhChi
{
    [Table("DM_LY_DO_DINH_CHI")]

    public class DM_LyDoDinhChi : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LDDC_NoiDung { get; set; }
        [MaxLength(10)]
        public string LDDC_Code { get; set; }
        public bool LDDC_IsActive { get; set; }
    }
}
