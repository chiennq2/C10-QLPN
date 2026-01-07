using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_HinhThucKyLuat
{
    [Table("DM_HINH_THUC_KY_LUAT")]

    public class DM_HinhThucKyLuat : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string HTKL_NoiDung { get; set; }
        [MaxLength(10)]
        public string HTKL_Code { get; set; }
        public bool HTKL_IsActive { get; set; }
    }
}
