using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.Core.DanhMuc.DM_LoaiQDTDT
{
    [Table("DM_LOAI_QUYET_DINH_TAM_DINH_TRI")]

    public class DM_LoaiQDTDT : FullAuditedEntity<int>
    {
        [MaxLength(255)]
        public string LQDTDT_NoiDung { get; set; }
        [MaxLength(10)]
        public string LQDTDT_Code { get; set; }
        public bool LQDTDT_IsActive { get; set; }
    }
}
