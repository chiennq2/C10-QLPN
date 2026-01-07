using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_BenhTat
{
    [Table("DM_BENH_TAT")]

    public class DM_BenhTat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string BT_NoiDung { get; set; }

        [MaxLength(10)]
        public string BT_Code { get; set; }
        public bool BT_IsActive { get; set; }
    }
}
