using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_MucAnPhat
{
    [Table("DM_MUC_AN_PHAT")]
    public class DM_MucAnPhat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string MAP_NoiDung { get; set; }

        [MaxLength(10)]
        public string MAP_Code { get; set; }
        public int MAP_TuMucAn { get; set; }
        public int MAP_DenMucAn { get; set; }
        public bool MAP_IsActive { get; set; }
    }
}
