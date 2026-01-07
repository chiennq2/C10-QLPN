using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_HocVan
{
    [Table("DM_HOC_VAN")]

    public class DM_HocVan : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string HV_NoiDung { get; set; }
        [MaxLength(10)]
        public string HV_Code { get; set; }
        public bool HV_IsActive { get; set; }
    }
   
}
