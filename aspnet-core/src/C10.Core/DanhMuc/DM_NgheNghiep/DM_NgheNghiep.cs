using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_NgheNghiep
{
    [Table("DM_NGHE_NGHIEP")]

    public class DM_NgheNghiep : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string NN_NoiDung { get; set; }
        [MaxLength(10)]
        public string NN_Code { get; set; }
        public bool NN_IsActive { get; set; }
    }
}
