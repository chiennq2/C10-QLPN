using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LyDoGiamRPN
{
    [Table("DM_LY_DO_RIENG_GIAM_PHAM_NHAN")]
    public class DM_LyDoGiamRPN : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LDRGPN_NoiDung { get; set; }

        [MaxLength(10)]
        public string LDRGPN_Code { get; set; }
        public bool LDRGPN_IsActive { get; set; }
    }
}
