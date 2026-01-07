using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_QuanHeVoiPN
{
    [Table("DM_QUAN_HE_VOI_PHAM_NHAN")]
    public class DM_QuanHeVoiPN : FullAuditedEntity<int>
    {
        [MaxLength(10)]
        public string QHVPN_Code { get; set; }
        [MaxLength(255)]
        public string QHVPN_NoiDung { get; set; }
        public int? QHVPN_GioiTinhId { get; set; }
        public bool QHVPN_IsActive { get; set; }
    }
}
